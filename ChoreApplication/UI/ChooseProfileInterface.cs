using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ChoreApplication.UI
{
    public partial class ChooseProfileInterface : Form
    {
        public static int activeId;

        public string Surname { get; set; }

        public ChooseProfileInterface()
        {
            InitializeComponent();
        }

        private Control AddLabel(string labelText, bool bold, int posX, int posY)
        {
            var label = new Label
            {
                Text = labelText,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(posX, posY),
                Size = new Size(75, 20),
            };
            if (!bold)
            {
                label.Font = Properties.Settings.Default.StandardFont;
                return label;
            }
            if (bold)
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
            DatabaseFunctions.DatabaseConnection.Open();
            //Creates the SqlCommand and executes it
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Surname = reader["last_name"].ToString();
            }
            DatabaseFunctions.DatabaseConnection.Close();
            SurnameLabel.Text = "The " + Surname + "'s";

            #endregion Load last name

            #region Load Users

            List<ParentUser> ParentUsers = ParentUser.Load("");
            List<ChildUser> childUsers = ChildUser.Load("");

            #endregion Load Users

            int y = 1;
            int x = 1;
            foreach (ParentUser parent in ParentUsers)
            {
                Button UserButton = new Button
                {
                    Location = new Point(x * 120, y * 100 - 90),
                    Size = new Size(60, 60),
                    Tag = parent.Id,
                    FlatStyle = FlatStyle.Flat,
                    BackgroundImage = global::ChoreApplication.Properties.Resources.user,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Cursor = Cursors.Hand,
                };
                var NameLabel = AddLabel(parent.FirstName, true, UserButton.Location.X - 7, UserButton.Location.Y + UserButton.Height);
                UserButton.FlatAppearance.BorderColor = SystemColors.Window;
                UserButton.FlatAppearance.BorderSize = 0;
                UserButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
                UserButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
                UserButton.Click += new EventHandler(UserButton_Click);
                ProfilesPanel.Controls.Add(UserButton);
                ProfilesPanel.Controls.Add(NameLabel);
                if (x == 1)
                {
                    x = 2;
                }
                else if (x == 2)
                {
                    x = 1;
                    y++;
                }
            }
            foreach (ChildUser child in childUsers)
            {
                Button UserButton = new Button
                {
                    Location = new Point(x * 120, y * 100 - 90),
                    Size = new Size(60, 60),
                    Tag = child.Id,
                    FlatStyle = FlatStyle.Flat,
                    BackgroundImage = global::ChoreApplication.Properties.Resources.useregular,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Cursor = Cursors.Hand,
                };
                var NameLabel = AddLabel(child.FirstName, false, UserButton.Location.X - 7, UserButton.Location.Y + UserButton.Height);
                UserButton.FlatAppearance.BorderColor = SystemColors.Window;
                UserButton.FlatAppearance.BorderSize = 0;
                UserButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
                UserButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
                UserButton.Click += new EventHandler(UserButton_Click);
                ProfilesPanel.Controls.Add(UserButton);
                ProfilesPanel.Controls.Add(NameLabel);
                if (x == 1)
                {
                    x = 2;
                }
                else if (x == 2)
                {
                    x = 1;
                    y++;
                }
            }
        }

        private void UserButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            activeId = (int)clickedButton.Tag;
            var pincodeUI = new PinCodeInterface();
            pincodeUI.Show();
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