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
    public partial class EditRewardUI : Form
    {
        private Reward _reward;
        public EditRewardUI(Reward reward)
        {
            InitializeComponent();
            LoadChildren();
            _reward = reward;
            rewardName.Text = _reward.Name;
            description.Text = _reward.Description;
            pointsRequired.Value = _reward.PointsReq;
            foreach (var child in ChildUser.Load($"c.child_id = {_reward.ChildId}"))
            {
                assignment.Text = child.FirstName;
            }
        }
        private void LoadChildren()
        {
            var children = ChildUser.Load("");
            var childrenarray = new string[children.Count];
            var i = 0;
            foreach (var name in children)
            {
                childrenarray[i] = name.FirstName;
                this.assignment.Items.Add(childrenarray[i]);
                i++;
            }

        }

        private void SaveReward_Click(object sender, EventArgs e)
        {
            _reward.Name = rewardName.Text;
            _reward.Description = description.Text;
            _reward.PointsReq = (int)pointsRequired.Value;
            int id = 0;
            foreach (var child in ChildUser.Load($"u.first_name = '{assignment.Text}'"))
            {
                id = child.ChildId;
            }
            _reward.ChildId = id;
            _reward.Update();
            this.Close();
            MessageBox.Show("The reward has been updated.");
        }
    }
}
