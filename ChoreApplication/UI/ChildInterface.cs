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
    public partial class ChildInterface : Form
    {
        public ChildUser Session { get; set; }

        public ChildInterface(ChildUser c)
        {
            InitializeComponent();
            Session = c;
        }

        private void ChildInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
