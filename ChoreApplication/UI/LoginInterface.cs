using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChoreApplication.UI
{
    public partial class LoginInterface : Form
    {
        public static ChooseProfileInterface chooseProfile;

        public LoginInterface()
        {
            InitializeComponent();
        }

        private void LoginInterface_Load(object sender, EventArgs e)
        {
        }

        private void EmailTextbox_Click(object sender, EventArgs e)
        {
            //Få tekstbokse til at slette indhold ved første selection.
            emailInput.Text = "";
        }

        private void PwdTextbox_Click(object sender, EventArgs e)
        {
            pwdInput.Text = "";
            pwdInput.UseSystemPasswordChar = true;
        }

        private void NewUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var RegisterUserInterface = new RegisterUserInterface();
            RegisterUserInterface.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Emailinput = emailInput.Text;
            string passwordInput = pwdInput.Text;
            bool match = false;
            if(string.IsNullOrEmpty(Emailinput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter your E-mail and password.");
                return;
            }

            string loginQuery = "SELECT email, password FROM dbo.parent";
            SqlCommand cmd = new SqlCommand(loginQuery, DatabaseFunctions.DbConn);
            DatabaseFunctions.DbConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string email = reader["email"].ToString();
                string password = reader["password"].ToString();
                if(Emailinput == email && passwordInput == password)
                {
                    match = true;
                }
                else
                {
                    MessageBox.Show("Incorrect password or E-mail entered.");
                    DatabaseFunctions.DbConn.Close();
                    return;
                }
            }
            if (match == true)
            {
                DatabaseFunctions.DbConn.Close();
                chooseProfile = new ChooseProfileInterface();
                chooseProfile.Show();
                this.Close();
            }


        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}