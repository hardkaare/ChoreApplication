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
    public partial class ParentInterface : Form
    {
        public int UI = 0;
        public ParentInterface()
        {
            InitializeComponent();
            ChoresUI();
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            switch (UI)
            {
                case 1:
                    //CreateChore
                    break;
                case 2:
                    //CreateReward
                    break;
                case 4:
                //CreateUser
                default:
                    break;
            }
        }

        #region NavigationPanel
        private void ChoreNavButton_Click(object sender, EventArgs e)
        {
            ChoresUI();
        }

        private void RewardNavButton_Click(object sender, EventArgs e)
        {
            RewardsUI();
        }

        private void LeadboardNavButton_Click(object sender, EventArgs e)
        {
            LeaderboardsUI();
        }

        private void UsersNavButton_Click(object sender, EventArgs e)
        {
            UsersUI();
        }

        private void NotificationsNavButton_Click(object sender, EventArgs e)
        {
            NotificationsUI();
        }
        #endregion

        #region ChoreUI
        public void ChoresUI()
        {
            UI = 1;
            this.ChorePanel.Visible = true;
            this.ChorePanel.BringToFront();
            titleText.Text = "Chores";
            LoadChores();
        }

        public void LoadChores()
        {
            var ConcreteChores = Concrete.Load("");
            var Children = ChildUser.Load("");
            var ChildrenNames = new Dictionary<int, string>();

            foreach (var child in Children)
            {
                ChildrenNames.Add(child.ChildId, child.FirstName);
            }

            foreach (var chore in ConcreteChores)
            {
                var individualChorePanel = new Panel
                {
                    Name = "panel" + chore.ID.ToString(),
                    Location = new Point(10, 10),
                    BorderStyle = BorderStyle.FixedSingle,
                };
                var choreName = new Label
                {
                    Name = "choreTitle" + chore.ID.ToString(),
                    Text = chore.Name.ToString(),
                    Location = new Point(10, 10),
                };
                var choreAssignment = new Label
                {
                    Name = "choreAssignment" + chore.ID.ToString(),
                    Text = "Assigned to: " + ChildrenNames[chore.Assignment],
                    Location = new Point(10, 30),
                };
                var choreStatus = new Label
                {
                    Name = "choreStatus" + chore.ID.ToString(),
                    Text = "Status: " + chore.Status.ToString(),
                    Location = new Point(10, 60),
                };
                ChorePanel.Controls.Add(individualChorePanel);
                individualChorePanel.Controls.Add(choreName);
                individualChorePanel.Controls.Add(choreAssignment);
                individualChorePanel.Controls.Add(choreStatus);
            }
        }
        #endregion

        #region RewardUI
        public void RewardsUI()
        {
            UI = 2;
            titleText.Text = "Rewards";
        }
        #endregion

        #region LeaderboardUI
        public void LeaderboardsUI()
        {
            UI = 3;
            titleText.Text = "Leaderboards";
            this.SortButton.Show();
        }
        #endregion

        #region UsersUI
        public void UsersUI()
        {
            titleText.Text = "Users";
        }
        #endregion

        #region NotificationsUI
        public void NotificationsUI()
        {
            titleText.Text = "Notifications";
        }
        #endregion

        private void SortButton_Click(object sender, EventArgs e)
        {

        }

        private void ParentInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
