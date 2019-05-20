using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    /// <summary>
    /// Displays the EditParentUI that edits a ParentUser in the DB. 
    /// Designer adds textboxes for all user input.
    /// Designer adds a button for Save.
    /// This class contains an event handler for Save button.
    /// </summary>
    public partial class EditParentUI : Form
    {
        #region Properties

        //ParentUser being editted
        private Model.ParentUser _parent { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Creates and displays elements in the designer.
        /// Fills in textboxes with existing information from DB
        /// </summary>
        public EditParentUI(Model.ParentUser parent)
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

        #endregion

        #region Event Handlers

        /// <summary>
        /// Validates inputs and updates ParentUser
        /// </summary>
        private void Save_Click(object sender, EventArgs e)
        {
            //Sets properties for ParentUser to user inputs
            _parent.FirstName = firstNameTextBox.Text;
            _parent.LastName = lastNameTextBox.Text;
            _parent.Password = passwordTextBox.Text;
            _parent.Pincode = pincodeTextBox.Text;
            _parent.Email = emailTextBox.Text;

            try
            {
                //Validates email. Max 50 chars long and must have this format: x@x.x
                if ((emailTextBox.Text.Length < 50) && Regex.Match(emailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
                {
                    //Validates first name.  Max 20 chars long and consist of letters
                    if ((firstNameTextBox.Text.Length < 20) && Regex.IsMatch(firstNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z]+$"))
                    {
                        //Validates last name.  Max 50 chars long and consist of letters
                        if ((lastNameTextBox.Text.Length < 50) && Regex.IsMatch(lastNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z\s]+$"))
                        {
                            //Validates password.  Between 6 and 20 chars long and consist of letters and/or numbers
                            if ((passwordTextBox.Text.Length < 20) && Regex.IsMatch(passwordTextBox.Text, @"^[ÆØÅæøåa-zA-Z0-9\s]+$") && Regex.IsMatch(passwordTextBox.Text, @"^\d{6}$"))
                            {
                                //Validates pincode. Must be 4 digits
                                if (Regex.IsMatch(pincodeTextBox.Text, @"^\d{4}$"))
                                {
                                    //Updates DB, closes form and displays confirmation message
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
                Functions.DatabaseFunctions.DatabaseConnection.Close();
            }
        }

        #endregion
    }
}