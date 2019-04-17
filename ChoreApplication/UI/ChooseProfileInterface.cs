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
    public partial class ChooseProfileInterface : Form
    {
        public string Surname { get; set; }
        public ChooseProfileInterface()
        {
            InitializeComponent();
        }

        private void ChooseProfile_Load(object sender, EventArgs e)
        {
            Surname = "Andersen";

            surnameLabel.Text = "The " + Surname + "'s";
        }
    }
}
