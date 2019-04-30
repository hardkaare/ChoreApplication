using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChoreApplication.UI
{
    public partial class ChooseProfileInterface : Form
    {
        List<Button> button;
        int activeId;

        public string Surname { get; set; }
        public ChooseProfileInterface()
        {
            InitializeComponent();
        }

        private void ChooseProfile_Load(object sender, EventArgs e)
        {
            #region Load last name

            string query = "SELECT last_name FROM parent";
            DatabaseFunctions.dbConn.Open();

            //Creates the SqlCommand and executes it
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Surname = reader["last_name"].ToString();
            }
            
            DatabaseFunctions.dbConn.Close();
            surnameLabel.Text = "The " + Surname + "'s";

            #endregion

            #region Load Users

            List<ParentUser> ParentUsers = ParentUser.Load("");
            List<ChildUser> childUsers = ChildUser.Load("");

            #endregion

            int y = 1;
            int x = 1;

            // pinPanel.Visible = false;
            button = new List<Button>();
            foreach (ParentUser p in ParentUsers)
            {
                Button newButton = new Button();
                button.Add(newButton);
                this.profilesPanel.Controls.Add(newButton);
                newButton.Location = new Point(x * 150, y * 75 - 75);
                newButton.Width = 125;
                newButton.Height = 50;
                newButton.Text = p.FirstName;
                newButton.Tag = p.Id;
                newButton.Click += new EventHandler(newButton_Click);
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
            foreach (ChildUser c in childUsers)
            {
                Button newButton = new Button();
                button.Add(newButton);
                this.profilesPanel.Controls.Add(newButton);
                newButton.Location = new Point(x * 150, y * 75 - 75);
                newButton.Text = c.FirstName;
                newButton.Width = 125;
                newButton.Height = 50;
                newButton.Tag = c.Id;
                newButton.Click += new EventHandler(newButton_Click);
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

        private void ChooseProfileLabel_Click(object sender, EventArgs e)
        {

        }

        private void SurnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProfilesPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void newButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            activeId = (int)clickedButton.Tag;
            MessageBox.Show(activeId.ToString());
        }
    }
}
