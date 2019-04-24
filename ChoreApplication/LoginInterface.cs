using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoreApplication
{
    public partial class LoginInterface : Form
    {
        public LoginInterface()
        {
            InitializeComponent();
        }

        private void LoginInterface_Load(object sender, EventArgs e)
        {

        }

        private void EmailTextbox_Click(object sender, EventArgs e)
        {
            //Få tekstbokse til at slette indhold ved første selection.
            EmailTextbox.Text = "";
        }

        private void PwdTextbox_Click(object sender, EventArgs e)
        {
            PwdTextbox.Text = "";
            PwdTextbox.UseSystemPasswordChar = true;
        }

        private void NewUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var RegisterUserInterface = new RegisterUserInterface();
            RegisterUserInterface.Show();
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
