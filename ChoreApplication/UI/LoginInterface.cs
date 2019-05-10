using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChoreApplication.UI
{
    public partial class LoginInterface : Form
    {
        public static ChooseProfileInterface ChooseProfile;

        public LoginInterface()
        {
            InitializeComponent();
            testUsers();
        }

        private void testUsers()
        {
            bool users = true;
            string query = "SELECT user_id FROM users";
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
            DatabaseFunctions.DatabaseConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                users = false;
            }
            reader.Close();
            DatabaseFunctions.DatabaseConnection.Close();
            if (!users)
            {
                var registerUserInterface = new RegisterUserInterface();
                registerUserInterface.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void EmailTextbox_Click(object sender, EventArgs e)
        {
            //Få tekstbokse til at slette indhold ved første selection.
            EmailInput.Text = "";
        }

        private void PwdTextbox_Click(object sender, EventArgs e)
        {
            PasswordInput.Text = "";
            PasswordInput.UseSystemPasswordChar = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Emailinput = EmailInput.Text;
            string passwordInput = PasswordInput.Text;
            bool match = false;
            if (string.IsNullOrEmpty(Emailinput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter your E-mail and password.");
                return;
            }

            string loginQuery = "SELECT email, password FROM dbo.parent";
            SqlCommand cmd = new SqlCommand(loginQuery, DatabaseFunctions.DatabaseConnection);
            DatabaseFunctions.DatabaseConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string email = reader["email"].ToString();
                string password = reader["password"].ToString();
                if (Emailinput == email && passwordInput == password)
                {
                    match = true;
                }
                else
                {
                    MessageBox.Show("Incorrect password or E-mail entered.");
                    DatabaseFunctions.DatabaseConnection.Close();
                    return;
                }
            }
            if (match == true)
            {
                DatabaseFunctions.DatabaseConnection.Close();
                ChooseProfile = new ChooseProfileInterface();
                ChooseProfile.Show();
                this.Close();
            }
        }
    }
}