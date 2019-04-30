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

           // pinPanel.Visible = false;
            List<Button> button = new List<Button>();
            for (int i = 0; i < 10; i++)


            {
                Button newButton = new Button();
                button.Add(newButton);
                this.Controls.Add(newButton);
                newButton.Location = new Point(100, i * 50);
                newButton.Text = i.ToString();










            }
        }

        private void ChooseProfileLabel_Click(object sender, EventArgs e)
        {

        }

        private void SurnameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
