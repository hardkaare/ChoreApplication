using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
                if(FirstNameInput.Text.Length > 20 && Regex.IsMatch(FirstNameInput.Text, @"^[ÆØÅæøåa-zA-Z]+$"))
                {
                    string firstName = FirstNameInput.Text;

                    //Validate last name
                    if (LastNameInput.Text.Length > 50 && Regex.IsMatch(LastNameInput.Text, @"^[ÆØÅæøåa-zA-Z]+$"))
                    {
                        string lastName = LastNameInput.Text;

                        //Validate email
                        if (EmailInput.Text.Length > 50 && Regex.IsMatch(EmailInput.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                        {
                            string email = EmailInput.Text;

                            //Validate password text
                            if (Password1Input.Text.Length > 20 && Regex.IsMatch(Password1Input.Text, @"^[ÆØÅæøåa-zA-Z]+$"))
                            {
                                string password = Password1Input.Text;

                                //Validate password2
                                if(password == Password2Input.Text)
                                {
                                    //Validate pincode
                                    if (Regex.IsMatch(PincodeInput.Text, @"^\d{4}$"))
                                    {
                                        string pincode = PincodeInput.Text;
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
                                MessageBox.Show("Please enter a valid password under 20 characters", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid email under 50 characters", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid last name under 50 characters", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid first name under 20 characters", "Error");
                }
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred. Please restart the program", "Error");
            }
        }
    }
}