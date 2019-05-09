﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChoreApplication.UI
{
    public partial class PinCodeInterface : Form
    {
        public User Session;
        public PinCodeInterface()
        {
            InitializeComponent();
        }


        private void OneButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            enterpinTextBox.Text = enterpinTextBox.Text + button.Text;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            enterpinTextBox.Text = "";
        }


        private void AcceptButton_click(object sender, EventArgs e)
        {
            int pincode;
            bool correctpin = false;
            bool conversion = Int32.TryParse(enterpinTextBox.Text, out pincode);

            if (conversion)
            {
                string query = string.Format("SELECT pincode FROM users WHERE user_id={0}", ChooseProfileInterface.activeId);
                DatabaseFunctions.DbConn.Open();

                //Creates the SqlCommand and executes it
                SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DbConn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int enteredpin = Convert.ToInt32(reader["pincode"]);
                    if (enteredpin == pincode)
                    {
                        correctpin = true;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect pincode");
                    }
                }
            }
            else
            {
                //Skrevet af Alexander Munk Petersen all rights reserved
                MessageBox.Show("Please enter numbers in your pincode");
            }
            DatabaseFunctions.DbConn.Close();
            if (correctpin == true)
            {
                if (ChooseProfileInterface.activeId == 1)
                {
                    var sessionList = ParentUser.Load("");
                    Session = sessionList[0];
                    var parentUI = new ParentInterface(sessionList[0]);//måske ok
                    parentUI.Show();
                }
                else
                {
                    var sessionList = ChildUser.Load("u.user_id=" + ChooseProfileInterface.activeId.ToString());
                    Session = sessionList[0];
                    var childUI = new ChildInterface(sessionList[0]);//sikkert ikke done
                    childUI.Show();
                }
                LoginInterface.ChooseProfile.Close();
                this.Close();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var chooseProfile = new ChooseProfileInterface();
            chooseProfile.Show();
            this.Close();
        }
    }
}
