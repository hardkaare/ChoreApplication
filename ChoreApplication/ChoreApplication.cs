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
            Chore testchore = new Chore("Rengør værelse", "Ryd op, tør støv af og støvsug", 10, "Mikkel");
            label1.Text = testchore.ToString();
        }
    }
}
