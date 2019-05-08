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
            parentName.Text = parent.FirstName;
            parentLastName.Text = parent.Lastname;
            emailTextBox.Text = parent.Email;
            password.Text = parent.Password;
            pincode.Text = parent.Pincode;
            WelcomeLabel.Text = "Editing " + parent.FirstName;
        }


        private void Save_Click(object sender, EventArgs e)

        {

            _parent.FirstName = parentName.Text;
            _parent.Lastname = parentLastName.Text;
            _parent.Password = password.Text;
            _parent.Pincode = pincode.Text;
            _parent.Email = emailTextBox.Text;

            try
            {//Edit email
                if ((emailTextBox.Text.Length < 50) && Regex.Match(emailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
                {
                    //Edit Firstname
                    if ((parentName.Text.Length < 20) && Regex.IsMatch(parentName.Text, @"^[ÆØÅæøåa-zA-Z]+$"))
                    {
                        //Edit Lastname
                        if ((parentLastName.Text.Length < 50) && Regex.IsMatch(parentLastName.Text, @"^[ÆØÅæøåa-zA-Z\s]+$"))
                        {
                            //edit password
                            if ((password.Text.Length < 50) && Regex.IsMatch(password.Text, @"^[ÆØÅæøåa-zA-Z0-9\s]+$"))
                            {
                               
                                if(Regex.IsMatch(pincode.Text, @"^\d{4}$"))
                                    {
                                    _parent.Update();
                                    this.Close();
                                    MessageBox.Show("Parent has been edited");
                                }
                                else
                                {
                                    MessageBox.Show("Invalid pincode");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid password");
                            }
                              
                         
                        }
                        else
                        {
                            MessageBox.Show("Invalid last name");
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("Invalid first name");
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid email");
            }
            finally
            {
                DatabaseFunctions.DbConn.Close();
            }
                 
        }           
    }
}
