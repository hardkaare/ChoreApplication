using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChoreApplication.UI.GeneralInterface
{
    public partial class LoginInterface : Form
    {
        public LoginInterface()
        {
            InitializeComponent();
            Functions.DatabaseFunctions.InitializeDB();
            CheckIfUsersExist();
        }

        private void CheckIfUsersExist()
        {
            bool users = true;
            string query = "SELECT user_id FROM users";
            SqlCommand comd = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlDataReader reader = comd.ExecuteReader();
            if (!reader.HasRows)
            {
                users = false;
            }
            reader.Close();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            if (!users)
            {
                var registerUserInterface = new RegisterUserInterface();
                registerUserInterface.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void EmailTextbox_Click(object sender, EventArgs e)
        {
            //Få tekstbokse til at slette indhold ved første selection.
            emailTextBox.Text = "";
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string emailInput = emailTextBox.Text;
            string passwordInput = passwordTextBox.Text;
            bool isMatch = false;
            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter your E-mail and password.", "Error");
                return;
            }

            string loginQuery = "SELECT email, password FROM dbo.parent";
            SqlCommand command = new SqlCommand(loginQuery, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string email = reader["email"].ToString();
                string password = reader["password"].ToString();
                if (emailInput == email && passwordInput == password)
                {
                    isMatch = true;
                }
                else
                {
                    MessageBox.Show("Incorrect password or E-mail entered.");
                    Functions.DatabaseFunctions.DatabaseConnection.Close();
                    return;
                }
            }
            if (isMatch == true)
            {
                Functions.DatabaseFunctions.DatabaseConnection.Close();
                var chooseProfileUI = new ChooseProfileInterface();
                chooseProfileUI.Show();
                this.Hide();
            }
        }
    }
}