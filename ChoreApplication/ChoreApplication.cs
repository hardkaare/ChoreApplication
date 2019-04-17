﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Use MySQL stuff

namespace ChoreApplication
{
    public partial class ChoreApplication : Form
    {
        public ChoreApplication()
        {
            InitializeComponent();
            DatabaseFunctions.InitializeDB();
        }

        private static void LoadAllUsers()
        {
            List<ParentUser> parents = ParentUser.GetParents();
            List<ChildUser> children = ChildUser.GetChildren();
            
            foreach (var parent in parents)
            {
                MessageBox.Show(string.Format(parent.FirstName + parent.Pincode));
                
            }
            foreach (var child in children)
            {
                MessageBox.Show(string.Format(child.FirstName + child.Pincode));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(DateTime.Now.ToString()); //Ændr format for tid i SQL
            //Concrete.Insert("Æd lort", "Det skal være en stor en", 10, 1, DateTime.Now, "active", "Reoc");
        }

        private void TestButtonJoenler_Click(object sender, EventArgs e)
        {
            var LoginInterface = new LoginInterface();
            var RegisterUser = new RegisterUserInterface();
            var ChooseProfile = new ChooseProfileInterface();
            var ParentInterface = new ParentInterface();

            LoginInterface.Show();
            //RegisterUser.Show();
            //ChooseProfile.Show();
            //ParentInterface.Show();

            //DatabaseFunctions.RunStringQuery("SELECT * FROM dbo.users");
            //TestLabelJoenler.Text = DatabaseFunctions.RunQuery("SELECT * FROM dbo.chore");
            //Notification testNotification = new Notification("You have a new reward available", "Phillip");
            //TestLabelJoenler.Text = testNotification.ToString();
            //Reward testReward = new Reward("A good spanking", 100, "Phillip");
            //TestLabelJoenler.Text = testReward.ToString();
            //ParentUser testParent = new ParentUser("Hansen@lort.dk", "12334", "Hansen", "Jan", 1234);
            //TestLabelJoenler.Text = testParent.ToString();
            //ChildUser testChild = new ChildUser("Phillip", 1234);
            //TestLabelJoenler.Text = testChild.ToString();
        }

        private void Interface1_Click(object sender, EventArgs e)
        {
            var LoginInterface = new LoginInterface();
            var RegisterUser = new RegisterUserInterface();
            var ChooseProfile = new ChooseProfileInterface();
            var ParentInterface = new ParentInterface();

            //LoginInterface.Show();
            //RegisterUser.Show();
            //ChooseProfile.Show();
            ParentInterface.Show();
        }

        private void ChoreApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
