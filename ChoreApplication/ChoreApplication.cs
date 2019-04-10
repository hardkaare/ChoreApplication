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
    public partial class ChoreApplication : Form
    {
        public ChoreApplication()
        {
            InitializeComponent();

    }

        private void Button1_Click(object sender, EventArgs e)
        {
            Concrete testchore = new Concrete("Gør badeværelse rent", "Vask gulv, rengør kumme", 15, "Hans", "03-02-2019", "Active", "");
            TestLabelLuten.Text = testchore.ToString();
        }

        private void TestButtonJoenler_Click(object sender, EventArgs e)
        {
            Chore testchore2 = new Chore("Gør badeværelse rent", "Vask gulv, rengør kumme", 15, "Hans");
            TestLabelJoenler.Text = testchore2.ToString();
        }
    }
}
