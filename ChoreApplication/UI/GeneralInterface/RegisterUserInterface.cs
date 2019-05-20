using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI.GeneralInterface
{
    /// <summary>
    /// Displays the RegisterUserInterface that creates a ParentUser in the DB. 
    /// Designer adds textboxes for all userinput.
    /// Designer adds a button for Register user.
    /// This class contains event handlers for Register user button.
    /// </summary>
    public partial class RegisterUserInterface : Form
    {
        #region Constructor 

        /// <summary>
        /// Creates and displays elements in the designer
        /// </summary>
        public RegisterUserInterface()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate first name. Cannot be longer than 20 chars and can only contain chars from the danish alphabet
                if ((firstNameTextBox.Text.Length < 20) && Regex.IsMatch(firstNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z]+$"))
                {
                    string firstName = firstNameTextBox.Text;

                    //Validate last name. Cannot be longer than 50 chars and can only contain chars from the danish alphabet
                    if ((lastNameTextBox.Text.Length < 50) && Regex.IsMatch(lastNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z\s]+$"))
                    {
                        string lastName = lastNameTextBox.Text;

                        //Validate email. Cannot be longer than 50 chars. 
                        //Must contain in order any number of chars, a @, any number of chars, a dot, and any number of chars
                        if ((emailTextBox.Text.Length < 50) && Regex.IsMatch(emailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                        {
                            string email = emailTextBox.Text;

                            //Validate password text. Cannot be longer than 20 chars. 
                            if ((password1TextBox.Text.Length < 20) && Regex.IsMatch(password1TextBox.Text, @"^[ÆØÅæøåa-zA-Z0-9]+$") && (password1TextBox.Text.Length >= 6))
                            {
                                string password = password1TextBox.Text;

                                //Checks that passwords match
                                if (password1TextBox.Text == password2TextBox.Text)
                                {
                                    //Validate pincode. Cannot be longer than 4 chars and must only contain numbers
                                    if (Regex.IsMatch(pincodeTextBox.Text, @"^\d{4}$"))
                                    {
                                        string pincode = pincodeTextBox.Text;

                                        //Inserts a ParentUser from user input and proceeds to loginInterface
                                        Model.ParentUser.Insert(firstName, lastName, email, password, pincode);
                                        var loginInterface = new LoginInterface();
                                        loginInterface.Show();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter a valid 4-digit pincode", "Error");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Your passwords don't match. Please reconfirm password", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid password with minimum 6 characters and maximum 20 characters", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid email with maximum 50 characters", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid last name with maximum 50 characters", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid first name with maximum 20 characters", "Error");
                }
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred. Please restart the program", "Error");
            }
        }

        #endregion
    }
}