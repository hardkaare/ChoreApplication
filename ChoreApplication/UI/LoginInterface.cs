using System;
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
            emailInput.Text = "";
        }

        private void PwdTextbox_Click(object sender, EventArgs e)
        {
            pwdInput.Text = "";
            pwdInput.UseSystemPasswordChar = true;
        }

        private void NewUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var RegisterUserInterface = new RegisterUserInterface();
            RegisterUserInterface.Show();
        }
    }
}