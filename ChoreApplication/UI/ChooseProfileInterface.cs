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

            int i = 1;
            // pinPanel.Visible = false;
            List<Button> button = new List<Button>();
            foreach (ParentUser p in ParentUsers)
            {
                Button newButton = new Button();
                button.Add(newButton);
                //this.Controls.Add(newButton);
                this.profilesPanel.Controls.Add(newButton);
                newButton.Location = new Point(100, i * 50);
                newButton.Text = p.FirstName;
                newButton.Tag = p;
                i++;
            }
            foreach (ChildUser c in childUsers)
            {
                Button newButton = new Button();
                button.Add(newButton);
                //this.Controls.Add(newButton);
                this.profilesPanel.Controls.Add(newButton);
                newButton.Location = new Point(100, i * 50);
                newButton.Text = c.FirstName;
                newButton.Tag = c;
                i++;
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
    }
}
