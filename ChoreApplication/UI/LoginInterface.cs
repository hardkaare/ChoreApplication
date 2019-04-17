using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChoreApplication.UI
{
    public partial class LoginInterface : Form
    {
        private static SqlConnection dbConn = DatabaseFunctions.dbConn;

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
            if(string.IsNullOrEmpty(Emailinput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter your E-mail and password.");
                return;
            }

            string loginQuery = "SELECT email, password FROM dbo.parent";
            SqlCommand cmd = new SqlCommand(loginQuery, dbConn);
            dbConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string email = reader["email"].ToString();
                string password = reader["password"].ToString();
                if(Emailinput == email && passwordInput == password)
                {
                    
                    ParentInterface showInterface = new ParentInterface();
                    showInterface.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect password or E-mail entered.");
                    dbConn.Close();
                    return;
                }
            }
            dbConn.Close();


        }
    }
}