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
                this.assignmentComboBox.Items.Add(name.FirstName);
            }
        }

        private void CreateReward_Click(object sender, EventArgs e)
        {
            var children = ChildUser.Load("");
            int id = 0;
            for (int i = 0; i < children.Count; i++)
            {
                if (children[i].FirstName == assignmentComboBox.Text)
                {
                    id = children[i].ChildID;
                }
            }
            if (!string.IsNullOrEmpty(assignmentComboBox.Text))
            {
                Reward.Insert(id, rewardNameTextBox.Text, descriptionRichTextBox.Text, Convert.ToInt32(pointsRequiredNumericUpDown.Text));
                this.Close();
                MessageBox.Show("A reward has been created", "Reward Created");
            }
            else
            {
                MessageBox.Show("You must assign the reward to a child.", "Error");
            }
        }
    }
}