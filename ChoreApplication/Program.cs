﻿using System;
using System.Windows.Forms;

namespace ChoreApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Functions.DatabaseFunctions.InitializeDB();
            Application.Run(new TestForm());
        }
    }
}