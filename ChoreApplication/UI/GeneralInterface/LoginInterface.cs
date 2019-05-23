using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChoreApplication.UI.GeneralInterface
{
    /// <summary>
    /// This is the first UI in the program, the LoginInterface.
    /// Designer adds a textbox for email and password userinput.
    /// Designer adds button for Login
    /// </summary>
    public partial class LoginInterface : Form
    {
        #region Constructor

        /// <summary>
        /// Creates and displays elements in designer.
        /// Initializes DB.
        /// If there are no Users in DB, leads to RegisterUserInterface
        /// </summary>
        public LoginInterface()
        {
            InitializeComponent();
            CheckIfUsersExist();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Checks if there are Users in the DB. If not opens a new RegisterUserInterface
        /// </summary>
        private void CheckIfUsersExist()
        {
            //True if Users in DB; otherwise false.
            bool users = true;

            //Creates a query that selects all user_id's
            string query = "SELECT user_id FROM users";
            SqlCommand comd = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlDataReader reader = comd.ExecuteReader();

            //If there are no rows in DB users becomes false
            if (!reader.HasRows)
            {
                users = false;
            }

            //Clean up
            reader.Close();
            Functions.DatabaseFunctions.DatabaseConnection.Close();

            //If there are no Users in DB a new RegisterUserInterface is created and this is hidden
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

        #endregion

        #region Event Handlers

        /// <summary>
        /// Deletes text in emailTextBox when clicked.
        /// </summary>
        private void EmailTextbox_Click(object sender, EventArgs e)
        {
            emailTextBox.Text = "";
        }

        /// <summary>
        /// Deletes text in passwordTextBox when clicked
        /// </summary>
        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
        }

        /// <summary>
        /// Validates user input and logs in if correct
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Pulls user input
            string emailInput = emailTextBox.Text;
            string passwordInput = passwordTextBox.Text;

            //True if user input match DB
            bool isMatch = false;

            //Displays error message if no input in one or more textbox
            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter your E-mail and password.", "Error");
                return;
            }

            //Creates  query that selects email and password from DB
            string loginQuery = "SELECT email, password FROM dbo.parent";
            SqlCommand command = new SqlCommand(loginQuery, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            //Reads loaded data from DB
            while (reader.Read())
            {
                //Sets email and password from DB
                string email = reader["email"].ToString();
                string password = reader["password"].ToString();

                //Checks if input matches DB and sets isMatch to true if so
                if (emailInput == email && passwordInput == password)
                {
                    isMatch = true;
                }

                //Displays error message if no match
                else
                {
                    MessageBox.Show("Incorrect password or E-mail entered.", "Error");
                    Functions.DatabaseFunctions.DatabaseConnection.Close();
                    return;
                }
            }

            //If user input and DB match proceeds to ChooseProfileInterface
            if (isMatch == true)
            {
                Functions.DatabaseFunctions.DatabaseConnection.Close();
                var chooseProfileUI = new ChooseProfileInterface();
                chooseProfileUI.Show();
                this.Hide();
            }
        }

        #endregion
    }
}