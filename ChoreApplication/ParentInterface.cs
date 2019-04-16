using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoreApplication
{
    public partial class ParentInterface : Form
    {
        public ParentInterface()
        {
            InitializeComponent();
        }

        public void MakeVisible(string input)
        {
           
        }

        public void ChoreInterface()
        {
            titleLabel.Text = "Chores";
            chorePanel.Visible = true;
        }

        public void RewardInterface()
        {
            titleLabel.Text = "Rewards";
        }

        public void LeaderboardInterface()
        {
            titleLabel.Text = "Leaderboards";
        }

        public void UsersInterface()
        {
            titleLabel.Text = "Users";
        }

        public void NotificationInterface()
        {
            titleLabel.Text = "Notifications";
        }

        private void ChoreNavButton_Click(object sender, EventArgs e)
        {
            ChoreInterface();
        }

        private void RewardNavButton_Click(object sender, EventArgs e)
        {
            RewardInterface();
        }

        private void LeadboardNavButton_Click(object sender, EventArgs e)
        {
            LeaderboardInterface();
        }

        private void UsersNavButton_Click(object sender, EventArgs e)
        {
            UsersInterface();
        }

        private void NotificationsNavButton_Click(object sender, EventArgs e)
        {
            NotificationInterface();
        }
    }
}
