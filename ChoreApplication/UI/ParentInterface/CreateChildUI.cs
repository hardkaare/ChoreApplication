using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    /// <summary>
    /// Displays the CreateChildUI that creates ChildUsers in the DB. 
    /// Designer adds textboxes for all userinput.
    /// Designer adds a button for Create.
    /// This class contains event handlers for Create button.
    /// </summary>
    public partial class CreateChildUI : Form
    {
        #region Constructor

        /// <summary>
        /// Creates and displays elements in the designer
        /// </summary>
        public CreateChildUI()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Validates user input and inserts a ChildUser to DB
        /// </summary>
        private void CreateChildButton_Click(object sender, EventArgs e)
        {
            try
            {
                // The first Regex.Match ensures that a childs name only can contain letters. 
                // The second Regex.Match ensures that a pincode always will be exactly 4 digits.
                if (Regex.IsMatch(childName.Text, @"^[ÆØÅæøåa-zA-Z]+$") && Regex.Match(childPincode.Text, @"^\d{4}$").Success)
                {
                    //Inserts a ParentUser from user input, closes this UI and displays confirmation MessageBox
                    Model.ChildUser.Insert(childName.Text, childPincode.Text);
                    this.Close();
                    MessageBox.Show("A child user has been created.", "Child User Created");
                }
            }

            //Displays error message if incorrect input
            catch (Exception)
            {
                MessageBox.Show("Incorrect input entered.", "Error");
            }
        }

        #endregion
    }
}