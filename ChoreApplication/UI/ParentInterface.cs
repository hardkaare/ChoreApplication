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
        public int UI;
        public ParentInterface()
        {
            InitializeComponent();
        }

        #region UserInterfaceMethods
        /// <summary>
        /// Sletter alle Control objekter i dynamicPanel & upperPanel
        /// </summary>
        public void ResetUI()
        {
            dynamicPanel.Controls.Clear();
            upperPanel.Controls.Clear();
            upperPanel.Controls.Add(titleText);
        }

        /// <summary>
        /// Brugt til at vise buttons i øverste panel.
        /// </summary>
        /// <param name="user">Hvis user button skal vises</param>
        /// <param name="create">Hvis create button skal vises</param>
        /// <param name="delete">Hvis delete button skal vises</param>
        /// <param name="sort">Hvis sort button skal vises</param>
        public void AddUpperButtons(bool user, bool create, bool delete, bool sort)
        {
            if (user == true)
            {
                upperPanel.Controls.Add(userButton);
                optionButton.BackgroundImage = global::ChoreApplication.Properties.Resources.user;
            }
            if (create == true)
            {
                upperPanel.Controls.Add(optionButton);
                optionButton.BackgroundImage = global::ChoreApplication.Properties.Resources.add;
            }
            if (delete == true)
            {
                upperPanel.Controls.Add(optionButton);
                optionButton.BackgroundImage = global::ChoreApplication.Properties.Resources.delete;
            }
            if (sort == true)
            {
                upperPanel.Controls.Add(optionButton);
                optionButton.BackgroundImage = global::ChoreApplication.Properties.Resources.menu;
            }
        }

        public void ChoresUI()
        {
            UI = 1;
            ResetUI();
            AddUpperButtons(true, true, false, false);
            titleText.Text = "Chores";
        }
        public void RewardsUI()
        {
            UI = 2;
            ResetUI();
            AddUpperButtons(true, true, false, false);
            titleText.Text = "Rewards";
        }

        public void LeaderboardsUI()
        {
            UI = 3;
            ResetUI();
            AddUpperButtons(true, false, false, true);
            titleText.Text = "Leaderboard";
        }

        public void UsersUI()
        {
            UI = 4;
            ResetUI();
            AddUpperButtons(true, true, false, false);
            titleText.Text = "Users";
        }

        public void NotificationsUI()
        {
            UI = 5;
            ResetUI();
            AddUpperButtons(true, false, false, false);
            titleText.Text = "Notifications";
        }
        #endregion

        #region ChoreUI
        #endregion

        #region RewardUI
        #endregion

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
    }
}
