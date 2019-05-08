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
            emailTextBox.Text = parent.Email;
            password.Text = parent.Password;
            pincode.Text = parent.Pincode;

        }


        private void Save_Click(object sender, EventArgs e)

        {

            _parent.FirstName = parentName.Text;
            _parent.Lastname = parentLastName.Text;
            _parent.Password = password.Text;
            _parent.Pincode = pincode.Text;
            _parent.Email = emailTextBox.Text;

            /*
            try
            {

                string email = emailTextBox.Text;
                Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                Match match = regex.Match(email);
                if (match.Success)

                {
                    _parent.Update();
                    this.Close();
                    MessageBox.Show(email + " is correct"); }
                else
                { MessageBox.Show(email + " is incorrect"); }

            }
            catch
            {
                MessageBox.Show("noob");
            }
            */

            try
            {
                if (Regex.IsMatch(emailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))

                {
                    _parent.Update();
                    this.Close();
                    MessageBox.Show("Email has been changed");
                }
                else
                {
                    throw new System.ArgumentException("Incorrect input");
                }

              try
                {


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
                    MessageBox.Show("Please enter a valid firstname");

                }
            }

            
            finally
            {
                DatabaseFunctions.DbConn.Close();
            }
        }
    }
}
