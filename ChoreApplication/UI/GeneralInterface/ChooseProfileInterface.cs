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

        private Control AddLabel(string labelText, bool isBold, int locationX, int locationY)
        {
            var label = new Label
            {
                Text = labelText,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(locationX, locationY),
                Size = new Size(75, 20),
            };
            if (!isBold)
            {
                label.Font = Properties.Settings.Default.StandardFont;
                return label;
            }
            if (isBold)
            {
                label.Font = Properties.Settings.Default.StandardFontBold;
                return label;
            }
            return label;
        }

        private void ChooseProfile_Load(object sender, EventArgs e)
        {
            #region Load last name

            string query = "SELECT last_name FROM parent";
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();
            //Creates the SqlCommand and executes it
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Surname = reader["last_name"].ToString();
            }
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
            surnameLabel.Text = "The " + Surname + "'s";

            #endregion Load last name

            #region Load Users

            var parentUsers = Model.ParentUser.Load("");
            var childUsers = Model.ChildUser.Load("");

            #endregion Load Users

            int locationCounter1 = 1;
            int locationCounter2 = 1;
            foreach (Model.ParentUser parent in parentUsers)
            {
                Button userButton = new Button
                {
                    Location = new Point(locationCounter2 * 120, locationCounter1 * 100 - 90),
                    Size = new Size(60, 60),
                    Tag = parent.ID,
                    FlatStyle = FlatStyle.Flat,
                    BackgroundImage = global::ChoreApplication.Properties.Resources.user,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Cursor = Cursors.Hand,
                };
                var nameLabel = AddLabel(parent.FirstName, true, userButton.Location.X - 7, userButton.Location.Y + userButton.Height);
                userButton.FlatAppearance.BorderColor = SystemColors.Window;
                userButton.FlatAppearance.BorderSize = 0;
                userButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
                userButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
                userButton.Click += new EventHandler(UserButton_Click);
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
                Button userButton = new Button
                {
                    Location = new Point(locationCounter2 * 120, locationCounter1 * 100 - 90),
                    Size = new Size(60, 60),
                    Tag = child.ID,
                    FlatStyle = FlatStyle.Flat,
                    BackgroundImage = global::ChoreApplication.Properties.Resources.useregular,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Cursor = Cursors.Hand,
                };
                var nameLabel = AddLabel(child.FirstName, false, userButton.Location.X - 7, userButton.Location.Y + userButton.Height);
                userButton.FlatAppearance.BorderColor = SystemColors.Window;
                userButton.FlatAppearance.BorderSize = 0;
                userButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
                userButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
                userButton.Click += new EventHandler(UserButton_Click);
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