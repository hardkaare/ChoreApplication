using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoreApplication.UI
{
    public partial class CreateRewardUI : Form
    {
        public CreateRewardUI()
        {
            InitializeComponent();
            LoadChildren();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadChildren()
        {
            var children = ChildUser.Load("");
          
            foreach (var name in children)
            {
                this.assignment.Items.Add(name.FirstName);
            }
        }

        private void CreateReward_Click(object sender, EventArgs e)
        {
            var children = ChildUser.Load("");
            int id = 0;
            for (int i = 0; i < children.Count; i++)
            {
                if (children[i].FirstName == assignment.Text)
                {
                    id = children[i].ChildId;
                }
            }
            try
            {
                Reward.Insert(id, rewardName.Text, description.Text, Convert.ToInt32(pointsRequired.Text));
                this.Close();
                MessageBox.Show("A reward has been created");
                
            }
            catch (Exception)
            {

                MessageBox.Show($"Incorrect input entered.");

            }
        }
    }
}
