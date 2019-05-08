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
            int childID = 0;
            int userID = 0;
            for (int i = 0; i < children.Count; i++)
            {
                if (children[i].FirstName == assignment.Text)
                {
                    childID = children[i].ChildId;
                    userID = children[i].Id;
                }
            }
            Reward.Insert(childID, rewardName.Text, description.Text, Convert.ToInt32(pointsRequired.Text));
            Notification.Insert(userID, "New reward available", "The reward '" + rewardName.Text + "' is now availble to you.");
            this.Close();
            MessageBox.Show("A reward has been created");
        }
    }
}
