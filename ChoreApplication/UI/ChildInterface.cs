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
        public ChildUser Session { get; set; }
        private Dictionary<int, string> StatusValues;
        private List<Concrete> ConcreteChores;
        private List<ChildUser> ChildUsers;
        //  private List<Reward> Rewards;
        private readonly Font StandardFont = new Font("Microsoft Sans Serif", 10F);
        private readonly Font StandardFontBold = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
        public ChildInterface()

        {
            InitializeComponent();
            ChoreUI();
            LoadAll();
            InitializeDictionaries();
        }

        private void LoadAll()
        {
            ConcreteChores = Concrete.Load("status=1 OR (type='conc' AND status=2) ORDER BY status DESC");
            ChildUsers = ChildUser.Load("");

        }

        private void InitializeDictionaries()
        {
            StatusValues = new Dictionary<int, string>
            {
                { 1, "Active" },
                { 2, "Approval pending" },
            };
        }

            #region ChoreUi
            public void ChoreUI()
        {
            UI = 1;
            this.ChorePanel.Visible = true;
            this.ChorePanel.BringToFront();
            titleText.Text = "Chores";
            LoadChores();

        }
        #endregion

        public void LoadChores()
        {
            ChorePanel.Controls.Clear();
            LoadAll();
            int i = 0;
            int panelDistance = 95;

            foreach (var chore in ConcreteChores)
            {
                var choreName = chore.Name.ToString();
                var chorePoints = chore.Points.ToString();
                var choreDescription = chore.Description.ToString();
                var choreStatus = "Status: " + StatusValues[chore.Status];

                var choreNamelabel = AddLabel(choreName, true, 5, 5);
                var chorePointslabel = AddLabel(chorePoints, true, 5, 5);
                var choreStatusLabel = AddLabel(choreStatus, false, 10, choreNamelabel.Location.Y +20);
                var panelHeight = choreNamelabel.Height + chorePointslabel.Height + choreStatusLabel.Height + choreStatusLabel.Height;
                var individualChorePanel = new Panel
                {
                    Name = "panel" + chore.ID.ToString(),
                    Location = new Point(1, i * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(ChorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                 individualChorePanel.Controls.Add(choreNamelabel);
                 individualChorePanel.Controls.Add(choreStatusLabel);






            }


        }
        #region RewardUI
        public void RewardUI()
        {
            UI = 2;
            titleText.Text = "Rewards";
        }
        #endregion
        private Control AddLabel(string labelText, bool bold, int posX, int posY)
        {
            var label = new Label
            {
                Text = labelText,
                Location = new Point(posX, posY),
                AutoSize = true,
            };
            if (!bold)
            {
                label.Font = StandardFont;
                return label;
            }
            if (bold)
            {
                label.Font = StandardFontBold;
                return label;
            }
            return label;
        }



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
