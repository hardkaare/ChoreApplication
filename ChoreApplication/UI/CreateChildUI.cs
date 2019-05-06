using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ChoreApplication.UI
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
                if (Regex.IsMatch(childName.Text, @"^[a-zA-Z]+$") && Regex.Match(childPincode.Text, @"^\d{4}$").Success)
                {
                    ChildUser.Insert(childName.Text, childPincode.Text);
                    this.Close();
                    MessageBox.Show("A child has been created.");
                }
                else
                {
                    throw new System.ArgumentException("");
                }
            }
            catch (ArgumentException)
            {

                MessageBox.Show("Incorrect input entered.");
            }
        }
    }
}
