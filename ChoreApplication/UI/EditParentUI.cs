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
    public partial class EditParentUI : Form
    {
        private ParentUser _parent;
        public EditParentUI(ParentUser parent)
        {
            InitializeComponent();
            _parent = parent;
            parentName.Text = parent.FirstName;
            parentLastName.Text = parent.Lastname;
            email.Text = parent.Email;
            password.Text = parent.Password;
            pincode.Text = parent.Pincode;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                _parent.FirstName = parentName.Text;
                _parent.Lastname = parentLastName.Text;
                _parent.Email = email.Text;
                _parent.Password = password.Text;
                _parent.Pincode = pincode.Text;

                if (Regex.IsMatch(parentName.Text, @"^[ÆØÅæøåa-zA-Z]+$") && Regex.Match(pincode.Text, @"^\d{4}$").Success)

                {
                    _parent.Update();
                    this.Close();
                    MessageBox.Show("Parent information changed.");
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
