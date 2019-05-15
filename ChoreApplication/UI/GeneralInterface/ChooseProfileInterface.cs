using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ChoreApplication.UI.GeneralInterface
{
    public partial class ChooseProfileInterface : Form
    {
        public static int ActiveID;

        private string Surname { get; set; }

        public ChooseProfileInterface()
        {
            InitializeComponent();
        }

        private void ChooseProfile_Load(object sender, EventArgs e)
        {
            string query = "SELECT last_name FROM parent";
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Surname = reader["last_name"].ToString();
            }
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
            surnameLabel.Text = "The " + Surname + "'s";

            var parentUsers = Model.ParentUser.Load("");
            var childUsers = Model.ChildUser.Load("");

            int locationCounter1 = 1;
            int locationCounter2 = 1;
            foreach (Model.ParentUser parent in parentUsers)
            {
                Button userButton = UILibrary.StandardElements.AddImageButton(new Point(locationCounter2 * 120, locationCounter1 * 100 - 90), parent.ID, global::ChoreApplication.Properties.Resources.user);
                userButton.Size = new Size(60, 60);
                userButton.Click += new EventHandler(UserButton_Click);
                var nameLabel = UILibrary.StandardElements.AddLabel(parent.FirstName, true, new Point(userButton.Location.X - 7, userButton.Location.Y + userButton.Height));
                profilesPanel.Controls.Add(userButton);
                profilesPanel.Controls.Add(nameLabel);
                if (locationCounter2 == 1)
                {
                    locationCounter2 = 2;
                }
                else if (locationCounter2 == 2)
                {
                    locationCounter2 = 1;
                    locationCounter1++;
                }
            }
            foreach (Model.ChildUser child in childUsers)
            {
                Button userButton = UILibrary.StandardElements.AddImageButton(new Point(locationCounter2 * 120, locationCounter1 * 100 - 90), child.ID, global::ChoreApplication.Properties.Resources.user);
                userButton.Size = new Size(60, 60);
                userButton.Click += new EventHandler(UserButton_Click);
                var nameLabel = UILibrary.StandardElements.AddLabel(child.FirstName, false, new Point(userButton.Location.X - 7, userButton.Location.Y + userButton.Height));
                profilesPanel.Controls.Add(userButton);
                profilesPanel.Controls.Add(nameLabel);
                if (locationCounter2 == 1)
                {
                    locationCounter2 = 2;
                }
                else if (locationCounter2 == 2)
                {
                    locationCounter2 = 1;
                    locationCounter1++;
                }
            }
        }

        private void UserButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ActiveID = (int)clickedButton.Tag;
            var pinCodeUI = new PinCodeInterface();
            pinCodeUI.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var loginUI = new LoginInterface();
            loginUI.Show();
            this.Close();
        }
    }
}