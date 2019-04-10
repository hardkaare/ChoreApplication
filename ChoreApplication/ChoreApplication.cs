﻿using System;
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
            Repeatable testchore1 = new Repeatable("Gå tur med hunden", "Husk poser og snor", 5, "Hans");
            TestLabelLuten.Text = testchore1.ToString();
            testchore1.GenerateConcreteChore();
            
        }

        private void TestButtonJoenler_Click(object sender, EventArgs e)
        {
            ChildUser testChild = new ChildUser("Phillip", 1234);
            TestLabelJoenler.Text = testChild.ToString();
        }
    }
}
