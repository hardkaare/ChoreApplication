using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ChoreApplication.UI
{
    public partial class EditChildUI : Form
    {
        private ChildUser _child;
        public EditChildUI(ChildUser child)
        {
            InitializeComponent();
            _child = child;
            ChildFirstnameInput.Text = child.FirstName;
            ChildPincodeInput.Text = child.Pincode;
            WelcomeLabel.Text = "Edit " + child.FirstName;
        }
       
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                _child.FirstName = ChildFirstnameInput.Text;
                _child.Pincode = ChildPincodeInput.Text;
                // The first !Regex.Match ensures that a childs name only can contain letters. The second Regex.Match ensures that a pincode always will be exactly 4 digits. 
                if (Regex.IsMatch(ChildFirstnameInput.Text, @"^[ÆØÅæøåa-zA-Z]+$") && Regex.Match(ChildPincodeInput.Text, @"^\d{4}$").Success)
                {
                    _child.Update();
                    this.Close();
                    MessageBox.Show("Child information changed.");
                }
                else
                {
                    throw new System.ArgumentException("");
                }

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please enter a valid first name or four digits in the pincode field");
            }
            finally
            {
                DatabaseFunctions.DbConn.Close();
            }
        }
    }
}
