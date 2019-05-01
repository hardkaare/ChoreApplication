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
        public ParentUser Session { get; set; }
        public int UI = 0;
        private Dictionary<int, string> StatusValues;
        private Dictionary<int, string> ChildrenNames;
        private List<Chore> AllChores;
        private readonly Font StandardFont = new Font("Microsoft Sans Serif", 10F);
        public ParentInterface(ParentUser p)
        {
            InitializeDictionaries();
            LoadAllChores();
            InitializeComponent();
            ChoresUI();
            Session = p;
        }
        private void LoadAllChores()
        {
            var ConcreteChores = Concrete.Load("");
            var ReoccurringChores = Reocurring.Load("");
            var RepeatableChores = Repeatable.Load("");

            AllChores = new List<Chore>(ConcreteChores.Count +
                ReoccurringChores.Count +
                RepeatableChores.Count);
            AllChores.AddRange(ConcreteChores);
            AllChores.AddRange(ReoccurringChores);
            AllChores.AddRange(RepeatableChores);
        }

        private void InitializeDictionaries()
        {
            StatusValues = new Dictionary<int, string>
            {
                { 1, "Active" },
                { 2, "Approval pending" },
                { 3, "Approves" },
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
            foreach (var chore in AllChores)
            {
                var choreName = new Label
                {
                    Name = "choreTitle" + chore.ID.ToString(),
                    Font = StandardFont,
                    Text = chore.Name.ToString(),
                    Location = new Point(5, 5),
                    AutoSize = true,
                };
                var choreAssignment = new Label
                {
                    Name = "choreAssignment" + chore.ID.ToString(),
                    Font = StandardFont,
                    Text = "Assigned to: "
                           + ChildrenNames[chore.Assignment],
                    Location = new Point(10, choreName.Location.Y + 20),
                    AutoSize = true,
                };
                var choreStatus = new Label
                {
                    Name = "choreStatus" + chore.ID.ToString(),
                    Font = StandardFont,
                    Text = "Status: ",
                    Location = new Point(10, choreAssignment.Location.Y + 20),
                    AutoSize = true,
                };
                var panelHeight = choreName.Height + choreAssignment.Height + choreStatus.Height;
                var individualChorePanel = new Panel
                {
                    Name = "panel" + chore.ID.ToString(),
                    Location = new Point(1, i * 70),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(ChorePanel.Width - 5, panelHeight),
                    AutoSize = true,
                };
                //if (chore.Status == 2)
                //{
                //    individualChorePanel.Controls.Add(AddApproveButton(individualChorePanel.Width - 45, panelHeight / 2));
                //    individualChorePanel.Controls.Add(AddDenyButton(individualChorePanel.Width - 90, panelHeight / 2));
                //}
                ChorePanel.Controls.Add(individualChorePanel);
                individualChorePanel.Controls.Add(choreName);
                individualChorePanel.Controls.Add(choreAssignment);
                individualChorePanel.Controls.Add(choreStatus);
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
