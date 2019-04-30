using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                ChildUser.Insert(childName.Text);
                this.Close();
                MessageBox.Show("A child has been created.");
            }
            catch (Exception)
            {

                MessageBox.Show("Incorrect input entered.");
            }
        }
    }
}
