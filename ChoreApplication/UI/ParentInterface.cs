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
        public ParentUser Session { get; set; }
        private Dictionary<int, string> StatusValues;
        private Dictionary<int, string> ChildrenNames;
        private List<Reocurring> ReoccurringChores;
        private List<Repeatable> RepeatableChores;
        private List<Concrete> ConcreteChoresApprovalPending;
        private List<Reward> Rewards;
        private readonly Font StandardFont = new Font("Microsoft Sans Serif", 10F);
        private readonly Font StandardFontBold = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
        public ParentInterface(ParentUser p)
        {
            Session = p;
            InitializeComponent();
            InitializeDictionaries();
            LoadAllChores();
            ChoresUI();
        }
        private void LoadAllChores()
        {
            ConcreteChoresApprovalPending = Concrete.Load("status=2 OR type='conc' ORDER BY status DESC");
            ReoccurringChores = Reocurring.Load("");
            RepeatableChores = Repeatable.Load("");
        }

        private void InitializeDictionaries()
        {
            StatusValues = new Dictionary<int, string>
            {
                { 1, "Active" },
                { 2, "Approval pending" },
                { 3, "Approved" },
                { 4, "Overdue" }
            };

            ChildrenNames = new Dictionary<int, string>();
            var Children = ChildUser.Load("");
            foreach (var child in Children)
            {
                ChildrenNames.Add(child.ChildId, child.FirstName);
            }
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
            int i = 0;
            int panelDistance = 95;

            foreach (var chore in ConcreteChoresApprovalPending)
            {
                var choreName = chore.Name.ToString();
                var choreAssignment = "Assigned to: " + ChildrenNames[chore.Assignment];
                var choreStatus = "Status: " + StatusValues[chore.Status];
                var choreType = "Type: Concrete";

                var choreNameLabel = AddLabel(choreName, true, 5, 5);
                var choreAssignmentLabel = AddLabel(choreAssignment, false, 10, choreNameLabel.Location.Y + 20);
                var choreStatusLabel = AddLabel(choreStatus, false, 10, choreAssignmentLabel.Location.Y + 20);
                var choreTypeLabel = AddLabel(choreType, false, 10, choreStatusLabel.Location.Y + 20);
                var panelHeight = choreNameLabel.Height + choreAssignmentLabel.Height + choreStatusLabel.Height + choreTypeLabel.Height;
                var individualChorePanel = new Panel
                {
                    Name = "panel" + chore.ID.ToString(),
                    Location = new Point(1, i * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(ChorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                ChorePanel.Controls.Add(individualChorePanel);
                individualChorePanel.Controls.Add(choreNameLabel);
                individualChorePanel.Controls.Add(choreAssignmentLabel);
                individualChorePanel.Controls.Add(choreStatusLabel);
                individualChorePanel.Controls.Add(choreTypeLabel);
                individualChorePanel.Controls.Add(AddApproveButton(200, 50));
                i++;
            }
            foreach (var chore in ReoccurringChores)
            {
                var choreName = chore.Name.ToString();
                var choreAssignment = "Assigned to: " + ChildrenNames[chore.Assignment];
                var choreStatus = "Status: Active";
                var choreType = "Type: Reoccurring";

                var choreNameLabel = AddLabel(choreName, true, 5, 5);
                var choreAssignmentLabel = AddLabel(choreAssignment, false, 10, choreNameLabel.Location.Y + 20);
                var choreStatusLabel = AddLabel(choreStatus, false, 10, choreAssignmentLabel.Location.Y + 20);
                var choreTypeLabel = AddLabel(choreType, false, 10, choreStatusLabel.Location.Y + 20);
                var panelHeight = choreNameLabel.Height + choreAssignmentLabel.Height + choreStatusLabel.Height + choreTypeLabel.Height;
                var individualChorePanel = new Panel
                {
                    Name = "panel" + chore.ID.ToString(),
                    Location = new Point(1, i * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(ChorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                ChorePanel.Controls.Add(individualChorePanel);
                individualChorePanel.Controls.Add(choreNameLabel);
                individualChorePanel.Controls.Add(choreAssignmentLabel);
                individualChorePanel.Controls.Add(choreStatusLabel);
                individualChorePanel.Controls.Add(choreTypeLabel);
                i++;
            }
            foreach (var chore in RepeatableChores)
            {
                var choreName = chore.Name.ToString();
                var choreAssignment = "Assigned to: " + ChildrenNames[chore.Assignment];
                var choreStatus = "Status: Active";
                var choreType = "Type: Repeatable";

                var choreNameLabel = AddLabel(choreName, true, 5, 5);
                var choreAssignmentLabel = AddLabel(choreAssignment, false, 10, choreNameLabel.Location.Y + 20);
                var choreStatusLabel = AddLabel(choreStatus, false, 10, choreAssignmentLabel.Location.Y + 20);
                var choreTypeLabel = AddLabel(choreType, false, 10, choreStatusLabel.Location.Y + 20);
                var panelHeight = choreNameLabel.Height + choreAssignmentLabel.Height + choreStatusLabel.Height + choreTypeLabel.Height;
                var individualChorePanel = new Panel
                {
                    Name = "panel" + chore.ID.ToString(),
                    Location = new Point(1, i * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(ChorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                ChorePanel.Controls.Add(individualChorePanel);
                individualChorePanel.Controls.Add(choreNameLabel);
                individualChorePanel.Controls.Add(choreAssignmentLabel);
                individualChorePanel.Controls.Add(choreStatusLabel);
                individualChorePanel.Controls.Add(choreTypeLabel);
                i++;
            }
        }

        private Control AddApproveButton(int x, int y)
        {
            var ApproveButton = new Button
            {
                Location = new Point(x, y - 15),
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.thumbs_up,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            ApproveButton.FlatAppearance.BorderSize = 0;
            ApproveButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;

            return ApproveButton;
        }

        private Control AddDenyButton(int x, int y)
        {
            var DenyButton = new Button
            {
                Location = new Point(x, y - 15),
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.thumb_down,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            DenyButton.FlatAppearance.BorderSize = 0;
            DenyButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;

            return DenyButton;
        }

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

  
    }
}
