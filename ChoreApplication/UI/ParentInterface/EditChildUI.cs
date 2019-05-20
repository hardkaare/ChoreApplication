using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    /// <summary>
    /// Displays the EditChildUI that edits a ChildUser in the DB. 
    /// Designer adds textboxes for all userinput.
    /// Designer adds a button for Save changes.
    /// This class contains an event handler for Save changes button.
    /// </summary>
    public partial class EditChildUI : Form
    {
        #region Properties

        //The ChildUser that is being editted
        private Model.ChildUser _child { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Creates and displays elements in the designer.
        /// Sets _child and edits label texts.
        /// </summary>
        public EditChildUI(Model.ChildUser child)
        {
            InitializeComponent();
            _child = child;
            childFirstNameTextbox.Text = child.FirstName;
            childPincodeTextBox.Text = child.Pincode;
            welcomeLabel.Text = "Editing " + child.FirstName;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Validates inputs and updates ChildUser
        /// </summary>
        private void Save_Click(object sender, EventArgs e)
        {
            //Validates user input
            try
            {
                _child.FirstName = childFirstNameTextbox.Text;
                _child.Pincode = childPincodeTextBox.Text;

                // The first !Regex.Match ensures that a childs name only can contain letters. 
                // The second Regex.Match ensures that a pincode always will be exactly 4 digits.
                if (Regex.IsMatch(childFirstNameTextbox.Text, @"^[ÆØÅæøåa-zA-Z]+$") && Regex.Match(childPincodeTextBox.Text, @"^\d{4}$").Success)
                {
                    //Updates ChildUser in DB and displays confirmation message. Closes this form.
                    _child.Update();
                    this.Close();
                    MessageBox.Show("Child has been edited.", "Edit Complete");
                }
                else
                {
                    throw new System.ArgumentException("");
                }
            }

            //Displays error message if incorrect input
            catch (ArgumentException)
            {
                MessageBox.Show("Please enter a valid first name and four digits in the pincode field", "Error");
            }

            //Clean up
            finally
            {
                Functions.DatabaseFunctions.DatabaseConnection.Close();
            }
        }

        #endregion
    }
}