using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI
{
    public partial class EditParentUI : Form
    {
        private ParentUser _parent;

        public EditParentUI(ParentUser parent)
        {
            InitializeComponent();
            _parent = parent;
            firstNameTextBox.Text = parent.FirstName;
            lastNameTextBox.Text = parent.LastName;
            emailTextBox.Text = parent.Email;
            passwordTextBox.Text = parent.Password;
            pincodeTextBox.Text = parent.Pincode;
            welcomeLabel.Text = "Editing " + parent.FirstName;
        }

        private void Save_Click(object sender, EventArgs e)

        {
            _parent.FirstName = firstNameTextBox.Text;
            _parent.LastName = lastNameTextBox.Text;
            _parent.Password = passwordTextBox.Text;
            _parent.Pincode = pincodeTextBox.Text;
            _parent.Email = emailTextBox.Text;

            try
            {//Edit email
                if ((emailTextBox.Text.Length < 50) && Regex.Match(emailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
                {
                    //Edit Firstname
                    if ((firstNameTextBox.Text.Length < 20) && Regex.IsMatch(firstNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z]+$"))
                    {
                        //Edit Lastname
                        if ((lastNameTextBox.Text.Length < 50) && Regex.IsMatch(lastNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z\s]+$"))
                        {
                            //edit password
                            if ((passwordTextBox.Text.Length < 20) && Regex.IsMatch(passwordTextBox.Text, @"^[ÆØÅæøåa-zA-Z0-9\s]+$") && Regex.IsMatch(passwordTextBox.Text, @"^\d{6}$"))
                            {
                                if (Regex.IsMatch(pincodeTextBox.Text, @"^\d{4}$"))
                                {
                                    _parent.Update();
                                    this.Close();
                                    MessageBox.Show("Parent has been edited", "Edit Complete");
                                }
                                else
                                {
                                    MessageBox.Show("Invalid pincode", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid password", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid last name", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid first name", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", "Error");
            }
            finally
            {
                Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
            }
        }
    }
}