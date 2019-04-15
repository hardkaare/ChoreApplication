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
    public partial class ParentInterface : Form
    {
        public ParentInterface()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NavRewardButton_Click(object sender, EventArgs e)
        {
            InterfaceTitle.Text = "Rewards";
        }
    }
}
