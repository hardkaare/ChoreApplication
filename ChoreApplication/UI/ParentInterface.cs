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
        public EditChoreUI EditSelectedChore { get; set; }
        private Dictionary<int, string> StatusValues;
        private Dictionary<int, string> ChildrenNames;
        private List<Reocurring> ReoccurringChores;
        private List<Repeatable> RepeatableChores;
        private List<Concrete> ConcreteChoresApprovalPending;
        private List<Reward> Rewards;
        private List<ParentUser> ParentUsers;
        private List<ChildUser> ChildUsers;
        private List<Notification> Notifications;
        public readonly Font StandardFont = new Font("Microsoft Sans Serif", 10F);
        public readonly Font StandardFontBold = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
        public ParentInterface(ParentUser p)
        {
            Session = p;
            InitializeComponent();
            LoadAll();
            InitializeDictionaries();
            ChoresUI();
            LoadAmountOfNotifications();
        }

        private void LoadAll()
        {
            ConcreteChoresApprovalPending = Concrete.Load("status=2 OR (type='conc' AND status=1) ORDER BY status DESC");
            ReoccurringChores = Reocurring.Load("");
            RepeatableChores = Repeatable.Load("");
            Rewards = Reward.Load("");
            ParentUsers = ParentUser.Load("");
            ChildUsers = ChildUser.Load("");
            Notifications = Notification.Load("");
        }

        private void InitializeDictionaries()
        {
            StatusValues = new Dictionary<int, string>
            {
                { 1, "Active" },
                { 2, "Approval pending" },
            };

            ChildrenNames = new Dictionary<int, string>();
            foreach (var child in ChildUsers)
            {
                ChildrenNames.Add(child.ChildId, child.FirstName);
            }
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            switch (UI)
            {
                case 1:
                    var createChore = new CreateChoreUI();
                    createChore.Show();
                    break;
                case 2:
                    var createReward = new CreateRewardUI();
                    createReward.Show();
                    break;
                case 4:
                    var createChild = new CreateChildUI();
                    createChild.Show();
                    break;
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
            LoadAmountOfNotifications();
            UI = 1;
            this.ChorePanel.Visible = true;
            this.ChorePanel.BringToFront();
            this.SortButton.Visible = false;
            this.OptionButton.Visible = true;
            titleText.Text = "Chores";
            LoadChores();
        }

        public void LoadChores()
        {
            ChorePanel.Controls.Clear();
            LoadAll();
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
                if (chore.Status == 2)
                {
                    individualChorePanel.Controls.Add(AddApproveButton(330, individualChorePanel.Height / 2, chore));
                    individualChorePanel.Controls.Add(AddDenyButton(365, individualChorePanel.Height / 2, chore));
                }
                else
                {
                    individualChorePanel.Controls.Add(AddEditChoreButton(330, individualChorePanel.Height / 2, chore));
                    individualChorePanel.Controls.Add(AddDeleteChoreButton(365, individualChorePanel.Height / 2, chore));
                }
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
                individualChorePanel.Controls.Add(AddEditChoreButton(330, individualChorePanel.Height / 2, chore));
                individualChorePanel.Controls.Add(AddDeleteChoreButton(365, individualChorePanel.Height / 2, chore));
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
                individualChorePanel.Controls.Add(AddEditChoreButton(330, individualChorePanel.Height / 2, chore));
                individualChorePanel.Controls.Add(AddDeleteChoreButton(365, individualChorePanel.Height / 2, chore));
                i++;
            }
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

        private Control AddApproveButton(int x, int y, Chore c)
        {
            var ApproveButton = new Button
            {
                Location = new Point(x, y - 15),
                Size = new Size(30, 30),
                Tag = c,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.thumbs_up,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            ApproveButton.Cursor = Cursors.Hand;
            ApproveButton.FlatAppearance.BorderSize = 0;
            ApproveButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            ApproveButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            ApproveButton.Click += new EventHandler(ApproveButton_Click);
            return ApproveButton;
        }

        private Control AddDenyButton(int x, int y, Chore c)
        {
            var DenyButton = new Button
            {
                Location = new Point(x, y - 15),
                Size = new Size(30, 30),
                Tag = c,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.thumb_down,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            DenyButton.Cursor = Cursors.Hand;
            DenyButton.FlatAppearance.BorderSize = 0;
            DenyButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            DenyButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            DenyButton.Click += new EventHandler(DenyButton_Click);
            return DenyButton;
        }

        private Control AddEditChoreButton(int x, int y, Chore c)
        {
            var EditChoreButton = new Button
            {
                Location = new Point(x, y - 15),
                Size = new Size(30, 30),
                Tag = c,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.pencil,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            EditChoreButton.Cursor = Cursors.Hand;
            EditChoreButton.FlatAppearance.BorderSize = 0;
            EditChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            EditChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            EditChoreButton.Click += new EventHandler(EditChoreButton_Click);
            return EditChoreButton;
        }

        private Control AddDeleteChoreButton(int x, int y, Chore chore)
        {
            var DeleteChoreButton = new Button
            {
                Location = new Point(x, y - 15),
                Size = new Size(30, 30),
                Tag = chore,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.delete,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            DeleteChoreButton.Cursor = Cursors.Hand;
            DeleteChoreButton.FlatAppearance.BorderSize = 0;
            DeleteChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            DeleteChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            DeleteChoreButton.Click += new EventHandler(DeleteChoreButton_Click);
            return DeleteChoreButton;
        }

        private void DeleteChoreButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this chore?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    Concrete selectedChore = (Concrete)clickedButton.Tag;
                    selectedChore.Delete();
                    ChoresUI();
                }
                catch
                {
                    try
                    {
                        Reocurring selectedChore = (Reocurring)clickedButton.Tag;
                        selectedChore.Delete();
                        ChoresUI();
                    }
                    catch
                    {
                        try
                        {
                            Repeatable selectedChore = (Repeatable)clickedButton.Tag;
                            selectedChore.Delete();
                            ChoresUI();
                        }
                        catch
                        {
                            MessageBox.Show("Could not delete selected chore: Conversion failed", "Error");
                        }
                    }
                }
            }
        }

        private void EditChoreButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            try
            {
                Concrete selectedChore = (Concrete)clickedButton.Tag;
                EditSelectedChore = new EditChoreUI(selectedChore);
                EditSelectedChore.Show();
            }
            catch
            {
                try
                {
                    Reocurring selectedChore = (Reocurring)clickedButton.Tag;
                    EditSelectedChore = new EditChoreUI(selectedChore);
                    EditSelectedChore.Show();
                }
                catch
                {
                    try
                    {
                        Repeatable selectedChore = (Repeatable)clickedButton.Tag;
                        EditSelectedChore = new EditChoreUI(selectedChore);
                        EditSelectedChore.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Could not edit chore: Conversion failed", "Error");
                    }
                }
            }
        }

        private void ApproveButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Concrete currentChore = (Concrete)clickedButton.Tag;
            currentChore.Status = 3;
            currentChore.ApprovalDate = DateTime.Now;
            currentChore.Update();

            var currentChild = ChildUser.Load("child_id=" + currentChore.Assignment);
            currentChild[0].Points += currentChore.Points;
            currentChild[0].Update();

            LoadChores();
        }

        private void DenyButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Concrete currentChore = (Concrete)clickedButton.Tag;

            if (currentChore.Type == "rep")
            {
                currentChore.Delete();
            }
            else
            {
                currentChore.DueDate = DateTime.Now.AddDays(1);
                currentChore.Status = 1;
                currentChore.Update();
            }
            LoadChores();
        }

        #endregion

        #region RewardUI
        private void RewardsUI()
        {
            LoadAmountOfNotifications();
            UI = 2;
            this.RewardPanel.Visible = true;
            this.RewardPanel.BringToFront();
            this.SortButton.Visible = false;
            this.OptionButton.Visible = true;
            titleText.Text = "Rewards";
            LoadRewards();
        }

        private void LoadRewards()
        {
            RewardPanel.Controls.Clear();
            int i = 0;
            int panelDistance = 72;

            foreach (Reward r in Rewards)
            {
                var rewardName = r.Name.ToString();
                var rewardAssignment = "Assigned to: " + ChildrenNames[r.ChildId];
                var rewardStatus = "Status: Active";

                var rewardNameLabel = AddLabel(rewardName, true, 5, 5);
                var rewardAssignmentLabel = AddLabel(rewardAssignment, false, 10, rewardNameLabel.Location.Y + 20);
                var rewardStatusLabel = AddLabel(rewardStatus, false, 10, rewardAssignmentLabel.Location.Y + 20);
                var panelHeight = rewardNameLabel.Height + rewardAssignmentLabel.Height + rewardStatusLabel.Height;
                var individualRewardPanel = new Panel
                {
                    Location = new Point(1, i * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(ChorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                individualRewardPanel.Controls.Add(rewardNameLabel);
                individualRewardPanel.Controls.Add(rewardAssignmentLabel);
                individualRewardPanel.Controls.Add(rewardStatusLabel);
                RewardPanel.Controls.Add(individualRewardPanel);
                i++;
            }
        }
        #endregion

        #region LeaderboardUI
        private void LeaderboardsUI()
        {
            LoadAmountOfNotifications();
            UI = 3;
            titleText.Text = "Leaderboard";
            this.LeaderboardPanel.Visible = true;
            this.LeaderboardPanel.BringToFront();
            this.SortButton.Visible = true;
            this.OptionButton.Visible = false;
            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            ProgressBar test = new ProgressBar();
            test.Location = new Point(20, 20);
            test.Value = 45;
            test.Name = "myProgressbar";
            test.Height = 50;
            test.Width = 200;
            this.LeaderboardPanel.Controls.Add(test);
        }
        #endregion

        #region UsersUI
        private void UsersUI()
        {
            LoadAmountOfNotifications();
            UI = 4;
            titleText.Text = "Users";
            this.UserPanel.Visible = true;
            this.UserPanel.BringToFront();
            this.SortButton.Visible = false;
            this.OptionButton.Visible = true;
            LoadUsers();
        }

        public void LoadUsers()
        {
            LoadAll();
            UserPanel.Controls.Clear();
            int i = 0;
            int panelDistance = 65;

            foreach (ParentUser p in ParentUsers)
            {
                var userFirstName = p.FirstName.ToString();

                var userFirstNameLabel = AddLabel(userFirstName, true, 5, 5);
                var panelHeight = userFirstNameLabel.Height + 40;
                var individualUserPanel = new Panel
                {
                    Location = new Point(1, i * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(ChorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                individualUserPanel.Controls.Add(userFirstNameLabel);
                UserPanel.Controls.Add(individualUserPanel);
                i++;
            }

            foreach (ChildUser c in ChildUsers)
            {
                var userFirstName = c.FirstName.ToString();

                var userFirstNameLabel = AddLabel(userFirstName, false, 5, 5);
                var panelHeight = userFirstNameLabel.Height + 40;
                var individualUserPanel = new Panel
                {
                    Location = new Point(1, i * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(ChorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                individualUserPanel.Controls.Add(userFirstNameLabel);
                UserPanel.Controls.Add(individualUserPanel);
                individualUserPanel.Controls.Add(AddChildDeleteButton(350, individualUserPanel.Height / 2, c));
                i++;
            }
        }

        private Control AddChildDeleteButton(int x, int y, ChildUser user)
        {
            var DeleteButton = new Button
            {
                Location = new Point(x, y - 15),
                Size = new Size(30, 30),
                Tag = user,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.delete,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            DeleteButton.Click += new EventHandler(ChildDeleteButton_Click);
            return DeleteButton;
        }



        private void ChildDeleteButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ChildUser currentUser = (ChildUser)clickedButton.Tag;

            var confirmDelete = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                currentUser.Delete();
                LoadUsers();
            }
        }

        #endregion

        #region NotificationsUI
        private void NotificationsUI()
        {
            LoadAmountOfNotifications();
            UI = 5;
            titleText.Text = "Notifications";
            this.NotificationPanel.Visible = true;
            this.NotificationPanel.BringToFront();
            this.OptionButton.Visible = false;
            this.SortButton.Visible = false;
            LoadNotification();
        }

        private void LoadNotification()
        {
            Notifications = Notification.Load("");
            NotificationPanel.Controls.Clear();
            int i = 0;
            int panelDistance = 50;

            foreach (Notification n in Notifications)
            {
                var notificationTitle = n.Title;
                var notificationDescription = n.Description;

                var notificationTitleLabel = AddLabel(notificationTitle, true, 5, 5);
                var notificationDescriptionLabel = AddLabel(notificationDescription, false, 10, notificationTitleLabel.Location.Y + 20);
                var panelHeight = notificationTitleLabel.Height + notificationDescriptionLabel.Height;
                var individualNotificationPanel = new Panel
                {
                    Location = new Point(1, i * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(ChorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                individualNotificationPanel.Controls.Add(notificationTitleLabel);
                individualNotificationPanel.Controls.Add(notificationDescriptionLabel);
                individualNotificationPanel.Controls.Add(AddNotificationDeleteButton(365, individualNotificationPanel.Height / 2, n));
                NotificationPanel.Controls.Add(individualNotificationPanel);
                i++;
            }
        }


        private Control AddNotificationDeleteButton(int x, int y, Notification notification)
        {
            var DeleteButton = new Button
            {
                Location = new Point(x, y - 15),
                Size = new Size(30, 30),
                Tag = notification,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.delete,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            DeleteButton.Click += new EventHandler(NotificationDeleteButton_Click);
            return DeleteButton;
        }

        private void NotificationDeleteButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Notification currentNotification = (Notification)clickedButton.Tag;
            currentNotification.Delete();
            LoadNotification();
            LoadAmountOfNotifications();
        }

        private void LoadAmountOfNotifications()
        {
            Notifications = Notification.Load("");
            NotificationAmount.Text = "";
            if (Notifications.Count == 0)
            {
                NotificationAmount.Visible = false;
            }
            else
            {
                NotificationAmount.Text = Notifications.Count.ToString();
            }
        }

        public void MyTestMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Notification.Insert(1, $"Chore {i.ToString()} completed", "Hello test test");
            }
        }
        #endregion


    }
}
