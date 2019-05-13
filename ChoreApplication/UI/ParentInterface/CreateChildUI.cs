using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    public partial class CreateChildUI : Form
    {
        public CreateChildUI()
        {
            InitializeComponent();
        }

        private void CreateChildButton_Click(object sender, EventArgs e)
        {
            try
            {
                // The first !Regex.Match ensures that a childs name only can contain letters. The second Regex.Match ensures that a pincode always will be exactly 4 digits.
                if (Regex.IsMatch(childName.Text, @"^[ÆØÅæøåa-zA-Z]+$") && Regex.Match(childPincode.Text, @"^\d{4}$").Success)
                {
                    Model.ChildUser.Insert(childName.Text, childPincode.Text);
                    this.Close();
                    MessageBox.Show("A child user has been created.", "Child User Created");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input entered.", "Error");
            }
        }
    }
}