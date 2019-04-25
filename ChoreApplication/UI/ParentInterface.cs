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
        private CreateChoreUI CreateChoreUI;
        public ParentInterface()
        {
            CreateChoreUI = new CreateChoreUI();
            InitializeComponent();
            ChoresUI();
        }

        #region UserInterfaceMethods
        /// <summary>
        /// Brugt til at vise buttons i øverste panel.
        /// </summary>
        /// <param name="user">Hvis user button skal vises</param>
        /// <param name="create">Hvis create button skal vises</param>
        /// <param name="delete">Hvis delete button skal vises</param>
        /// <param name="sort">Hvis sort button skal vises</param>
        /// <param name="back">Hvis back button skal vises</param>
        public void AddUpperButtons(bool user, bool create, bool delete, bool sort, bool back)
        {
            if (user == true)
            {
                upperPanel.Controls.Add(UserButton);
                OptionButton.BackgroundImage = global::ChoreApplication.Properties.Resources.user;
            }
            if (create == true)
            {
                upperPanel.Controls.Add(OptionButton);
                OptionButton.BackgroundImage = global::ChoreApplication.Properties.Resources.add;
            }
            if (delete == true)
            {
                upperPanel.Controls.Add(OptionButton);
                OptionButton.BackgroundImage = global::ChoreApplication.Properties.Resources.delete;
            }
            if (sort == true)
            {
                upperPanel.Controls.Add(OptionButton);
                OptionButton.BackgroundImage = global::ChoreApplication.Properties.Resources.menu;
            }
            if (back == true)
            {
                upperPanel.Controls.Add(BackButton);
            }
        }
        #endregion


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
            ChorePanel.Visible = true;
            AddUpperButtons(true, true, false, false, false);
            titleText.Text = "Chores";
        }

        public void EditChoreUI()
        {
            UI = 12;
        }
        #endregion

        #region RewardUI
        public void RewardsUI()
        {
        }
        #endregion

        #region LeaderboardUI
        public void LeaderboardsUI()
        {
        }
        #endregion

        #region UsersUI
        public void UsersUI()
        {
        }
        #endregion

        #region NotificationsUI
        public void NotificationsUI()
        {
        }
        #endregion

        private void OptionButton_Click(object sender, EventArgs e)
        {
            switch (UI)
            {
                case 1:
                    CreateChoreUI.Show();
                    break;
                default:
                    break;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            switch (UI)
            {
                case 11:
                    ChoresUI();
                    break;
                case 12:
                    ChoresUI();
                    break;
                default:
                    break;
            }
        }
    }
}
