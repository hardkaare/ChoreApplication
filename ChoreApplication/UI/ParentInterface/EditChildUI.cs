using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    public partial class EditChildUI : Form
    {
        private Model.ChildUser _child;

        public EditChildUI(Model.ChildUser child)
        {
            InitializeComponent();
            _child = child;
            childFirstNameTextbox.Text = child.FirstName;
            childPincodeTextBox.Text = child.Pincode;
            welcomeLabel.Text = "Editing " + child.FirstName;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                _child.FirstName = childFirstNameTextbox.Text;
                _child.Pincode = childPincodeTextBox.Text;
                // The first !Regex.Match ensures that a childs name only can contain letters. The second Regex.Match ensures that a pincode always will be exactly 4 digits.
                if (Regex.IsMatch(childFirstNameTextbox.Text, @"^[ÆØÅæøåa-zA-Z]+$") && Regex.Match(childPincodeTextBox.Text, @"^\d{4}$").Success)
                {
                    _child.Update();
                    this.Close();
                    MessageBox.Show("Child has been edited.", "Edit Complete");
                }
                else
                {
                    throw new System.ArgumentException("");
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please enter a valid first name or four digits in the pincode field", "Error");
            }
            finally
            {
                Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
            }
        }
    }
}