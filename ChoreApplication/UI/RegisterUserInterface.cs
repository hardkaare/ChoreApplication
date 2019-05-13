using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI
{
    public partial class RegisterUserInterface : Form
    {
        public RegisterUserInterface()
        {
            InitializeComponent();
        }

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate first name
                if ((firstNameTextBox.Text.Length < 20) && Regex.IsMatch(firstNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z]+$"))
                {
                    string firstName = firstNameTextBox.Text;

                    //Validate last name
                    if ((lastNameTextBox.Text.Length < 50) && Regex.IsMatch(lastNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z\s]+$"))
                    {
                        string lastName = lastNameTextBox.Text;

                        //Validate email
                        if ((emailTextBox.Text.Length < 50) && Regex.IsMatch(emailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                        {
                            string email = emailTextBox.Text;

                            //Validate password text
                            if ((password1TextBox.Text.Length < 20) && Regex.IsMatch(password1TextBox.Text, @"^[ÆØÅæøåa-zA-Z0-9]+$") && (password1TextBox.Text.Length >= 6))
                            {
                                string password = password1TextBox.Text;

                                //Validate password2
                                if (password1TextBox.Text == password2TextBox.Text)
                                {
                                    //Validate pincode
                                    if (Regex.IsMatch(pincodeTextBox.Text, @"^\d{4}$"))
                                    {
                                        string pincode = pincodeTextBox.Text;
                                        ParentUser.Insert(firstName, lastName, email, password, pincode);
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
    }
}