using System;
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
            int id = 0;
            for (int i = 0; i < children.Count; i++)
            {
                if (children[i].FirstName == assignment.Text)
                {
                    id = children[i].ChildId;
                }
            }
            if (!string.IsNullOrEmpty(assignment.Text))
            {
                Reward.Insert(id, rewardName.Text, description.Text, Convert.ToInt32(pointsRequired.Text));
                this.Close();
                MessageBox.Show("A reward has been created");
            }
            else
            {
                MessageBox.Show("You must assign the reward to a child.");
            }
        }
    }
}
