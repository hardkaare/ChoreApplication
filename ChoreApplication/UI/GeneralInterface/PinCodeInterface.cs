using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChoreApplication.UI.GeneralInterface
{
    public partial class PinCodeInterface : Form
    {
        private Model.User _session;

        public PinCodeInterface()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            enterpinTextBox.Text += button.Text;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            enterpinTextBox.Text = "";
        }

        private void AcceptButton_click(object sender, EventArgs e)
        {
            bool correctpin = false;
            bool conversion = Int32.TryParse(enterpinTextBox.Text, out int pincode);

            if (conversion)
            {
                string query = string.Format("SELECT pincode FROM users WHERE user_id={0}", ChooseProfileInterface.ActiveID);
                Functions.DatabaseFunctions.DatabaseConnection.Open();

                //Creates the SqlCommand and executes it
                SqlCommand cmd = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int enteredpin = Convert.ToInt32(reader["pincode"]);
                    if (enteredpin == pincode)
                    {
                        correctpin = true;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect pincode");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter numbers in your pincode");
            }
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            if (correctpin == true)
            {
                if (ChooseProfileInterface.ActiveID == 1)
                {
                    var sessionList = Model.ParentUser.Load("");
                    _session = sessionList[0];
                    var parentUI = new ParentUI.ParentMenu(sessionList[0]);
                    parentUI.Show();
                    this.Close();
                }
                else
                {
                    var sessionList = Model.ChildUser.Load("u.user_id=" + ChooseProfileInterface.ActiveID.ToString());
                    _session = sessionList[0];
                    var childUI = new UI.ChildMenu(sessionList[0]);
                    childUI.Show();
                    this.Close();
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var chooseProfile = new ChooseProfileInterface();
            chooseProfile.Show();
            this.Close();
        }
    }
}