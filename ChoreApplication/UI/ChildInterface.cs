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
    public partial class ChildInterface : Form
    {
        public int UI = 0;
        private readonly Font StandardFont = new Font("Microsoft Sans Serif", 10F);
        public ChildInterface()
        {
            InitializeComponent();
            ChoreUI();
        }
        #region ChoreUi
        public void ChoreUI()
        {
            UI = 1;
            titleText.Text = "Chores";
            this.ChorePanel.Visible = true;

        }
        #endregion

        public void loadChores()
        {

        }
        #region RewardUI
        public void RewardUI()
        {
            UI = 2;
            titleText.Text = "Rewards";
        }
        #endregion

        #region LeaderBoardUI
        public void LeaderboardUI()
        {
            UI = 3;
            titleText.Text = "Leaderboard";
        }
        #endregion

        #region NotificationUI
        public void NotificationUI()
        {
            UI = 4;
            titleText.Text = "Notification";

        }
        #endregion

        #region NavigationMenu
        private void ChoreNavButton_Click(object sender, EventArgs e)
        {
            ChoreUI();
        }

        
        private void RewardNavButton_Click(object sender, EventArgs e)
        {
            RewardUI();
        }

        private void LeadboardNavButton_Click(object sender, EventArgs e)
        {
            LeaderboardUI();
        }

        private void NotificationsNavButton_Click(object sender, EventArgs e)
        {
            NotificationUI();
        }
        #endregion
    }
}
