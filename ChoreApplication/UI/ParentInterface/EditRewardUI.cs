using System;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    public partial class EditRewardUI : Form
    {
        private Model.Reward _reward;

        public EditRewardUI(Model.Reward reward)
        {
            InitializeComponent();
            LoadChildren();
            _reward = reward;
            rewardNameTextBox.Text = _reward.Name;
            descriptionRichTextBox.Text = _reward.Description;
            pointsRequiredNumericUpDown.Value = _reward.PointsRequired;
            foreach (var child in Model.ChildUser.Load($"c.child_id = {_reward.ChildID}"))
            {
                childAssignedComboBox.Text = child.FirstName;
            }
        }

        private void LoadChildren()
        {
            var children = Model.ChildUser.Load("");
            var childrenarray = new string[children.Count];
            var i = 0;
            foreach (var name in children)
            {
                childrenarray[i] = name.FirstName;
                this.childAssignedComboBox.Items.Add(childrenarray[i]);
                i++;
            }
        }

        private void SaveReward_Click(object sender, EventArgs e)
        {
            _reward.Name = rewardNameTextBox.Text;
            _reward.Description = descriptionRichTextBox.Text;
            _reward.PointsRequired = (int)pointsRequiredNumericUpDown.Value;
            int id = 0;
            foreach (var child in Model.ChildUser.Load($"u.first_name = '{childAssignedComboBox.Text}'"))
            {
                id = child.ChildID;
            }
            _reward.ChildID = id;
            _reward.Update();
            this.Close();
            MessageBox.Show("The reward has been updated.");
        }
    }
}