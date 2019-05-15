using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    public partial class ParentMenu : Form
    {
        public int UI = 0;
        private Model.ParentUser _session;
        private Dictionary<int, string> _statusValues;
        private Dictionary<int, string> _childrenNames;
        private List<Model.Reocurring> _reoccurringChores;
        private List<Model.Repeatable> _repeatableChores;
        private List<Model.Concrete> _concreteChoresApprovalPending;
        private List<Model.Reward> _rewards;
        private List<Model.ParentUser> _parentUsers;
        private List<Model.ChildUser> _childUsers;
        private List<Model.Notification> _notifications;

        public ParentMenu(Model.ParentUser currentUser)
        {
            _session = currentUser;
            InitializeComponent();
            InitializeStatusValues();
            LoadChildrenNames();
            LoadAmountOfNotifications();
            ChoresUI();
        }

        private void InitializeStatusValues()
        {
            _statusValues = new Dictionary<int, string>
            {
                { 1, "Active" },
                { 2, "Approval pending" },
            };
        }

        private void LoadChildrenNames()
        {
            _childUsers = Model.ChildUser.Load("");
            _childrenNames = new Dictionary<int, string>();
            foreach (var child in _childUsers)
            {
                _childrenNames.Add(child.ChildID, child.FirstName);
            }
        }

        #region General Controls

        private void OptionButton_Click(object sender, EventArgs e)
        {
            switch (UI)
            {
                case 1:
                    this.Enabled = false;
                    var createChore = new CreateChoreUI();
                    createChore.Show();
                    createChore.FormClosing += ChoreNavigationButton_Click;
                    break;

                case 2:
                    this.Enabled = false;
                    var createReward = new CreateRewardUI();
                    createReward.Show();
                    createReward.FormClosing += RewardNavigationButton_Click;
                    break;

                case 4:
                    this.Enabled = false;
                    var createChild = new CreateChildUI();
                    createChild.Show();
                    createChild.FormClosing += UsersNavigationButton_Click;
                    break;
            }
        }

        #endregion General Controls

        #region NavigationPanel

        private void ChoreNavigationButton_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            ChoresUI();
        }

        private void RewardNavigationButton_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            RewardsUI();
        }

        private void LeadboardNavigationButton_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            LeaderboardsUI();
        }

        private void UsersNavigationButton_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            UsersUI();
        }

        private void NotificationsNavigationButton_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            NotificationsUI();
        }

        #endregion NavigationPanel

        #region ChoreUI

        public void ChoresUI()
        {
            LoadAmountOfNotifications();
            UI = 1;
            this.chorePanel.Visible = true;
            this.chorePanel.BringToFront();
            this.optionButton.Visible = true;
            titleText.Text = "Chores";
            LoadChores();
        }

        public void LoadChores()
        {
            LoadChildrenNames();
            chorePanel.Controls.Clear();
            _concreteChoresApprovalPending = Model.Concrete.Load("status=2 OR (type='conc' AND status=1) ORDER BY status DESC");
            _reoccurringChores = Model.Reocurring.Load("");
            _repeatableChores = Model.Repeatable.Load("");
            int panelDistance = 5;
            int choreLocationY = 0;

            foreach (var chore in _concreteChoresApprovalPending)
            {
                Panel currentPanel = LoadConcreteChore(chore, chorePanel.Width - 20, choreLocationY);
                chorePanel.Controls.Add(currentPanel);
                choreLocationY += currentPanel.Height + panelDistance;
            }
            foreach (var chore in _reoccurringChores)
            {
                Panel currentPanel = LoadReocurringChore(chore, chorePanel.Width - 20, choreLocationY);
                chorePanel.Controls.Add(currentPanel);
                choreLocationY += currentPanel.Height + panelDistance;
            }
            foreach (var chore in _repeatableChores)
            {
                Panel currentPanel = LoadRepeatableChore(chore, chorePanel.Width - 20, choreLocationY);
                chorePanel.Controls.Add(currentPanel);
                choreLocationY += currentPanel.Height + panelDistance;
            }
        }

        private Panel LoadChore(Model.Chore chore, int width, int yLocation, string status, string type)
        {
            int yLoc = 5;
            int LabelDistance = 2;

            string choreName = chore.Name;
            string choreAssignment = "Assigned to: " + _childrenNames[chore.Assignment];
            string choreStatus = "Status: " + status;
            string choreType = "Type: " + type;

            var choreNameLabel = UILibrary.StandardElements.AddLabel(choreName, true, new Point(5, yLoc));
            yLoc += choreNameLabel.Height + LabelDistance;
            var choreAssignmentLabel = UILibrary.StandardElements.AddLabel(choreAssignment, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + LabelDistance;
            var choreStatusLabel = UILibrary.StandardElements.AddLabel(choreStatus, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + LabelDistance;
            var choreTypeLabel = UILibrary.StandardElements.AddLabel(choreType, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + LabelDistance;
            var panelHeight = choreNameLabel.Height + choreAssignmentLabel.Height + choreStatusLabel.Height + choreTypeLabel.Height;

            var currentPanel = UILibrary.StandardElements.AddPanel(new Point(1, yLocation), width, panelHeight);

            currentPanel.Controls.Add(choreNameLabel);
            currentPanel.Controls.Add(choreAssignmentLabel);
            currentPanel.Controls.Add(choreStatusLabel);
            currentPanel.Controls.Add(choreTypeLabel);

            return currentPanel;
        }

        public Panel LoadRepeatableChore(Model.Repeatable chore, int width, int yLocation)
        {
            string status = "Active";
            string type = "Repeatable";

            Panel currentPanel = LoadChore(chore, width, yLocation, status, type);
            currentPanel.Controls.Add(AddEditChoreButton(330, currentPanel.Height / 2, chore));
            currentPanel.Controls.Add(AddDeleteChoreButton(365, currentPanel.Height / 2, chore));

            return currentPanel;
        }

        public Panel LoadReocurringChore(Model.Reocurring chore, int width, int yLocation)
        {
            string status = "Active";
            string type = "Reocurring";

            Panel currentPanel = LoadChore(chore, width, yLocation, status, type);
            currentPanel.Controls.Add(AddEditChoreButton(330, currentPanel.Height / 2, chore));
            currentPanel.Controls.Add(AddDeleteChoreButton(365, currentPanel.Height / 2, chore));

            return currentPanel;
        }

        public Panel LoadConcreteChore(Model.Concrete chore, int width, int yLocation)
        {
            string status = _statusValues[chore.Status];
            string type = "Concrete";

            Panel currentPanel = LoadChore(chore, width, yLocation, status, type);
            if (chore.Status == 1)
            {
                currentPanel.Controls.Add(AddEditChoreButton(330, currentPanel.Height / 2, chore));
                currentPanel.Controls.Add(AddDeleteChoreButton(365, currentPanel.Height / 2, chore));
            }
            else if (chore.Status == 2)
            {
                currentPanel.Controls.Add(AddApproveChoreButton(330, currentPanel.Height / 2, chore));
                currentPanel.Controls.Add(AddDenyChoreButton(365, currentPanel.Height / 2, chore));
            }
            return currentPanel;
        }

        private Control AddApproveChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            var approveButton = UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), chore, global::ChoreApplication.Properties.Resources.thumbs_up);
            approveButton.Click += new EventHandler(ApproveChoreButton_Click);
            return approveButton;
        }

        private Control AddDenyChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            var denyButton = UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), chore, global::ChoreApplication.Properties.Resources.thumb_down);
            denyButton.Click += new EventHandler(DenyChoreButton_Click);
            return denyButton;
        }

        private Control AddEditChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            var editChoreButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = chore,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.pencil,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            editChoreButton.Cursor = Cursors.Hand;
            editChoreButton.FlatAppearance.BorderSize = 0;
            editChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            editChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            editChoreButton.Click += new EventHandler(EditChoreButton_Click);
            return editChoreButton;
        }

        private Control AddDeleteChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            var deleteChoreButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = chore,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.delete,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            deleteChoreButton.Cursor = Cursors.Hand;
            deleteChoreButton.FlatAppearance.BorderSize = 0;
            deleteChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            deleteChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            deleteChoreButton.Click += new EventHandler(DeleteChoreButton_Click);
            return deleteChoreButton;
        }

        private void ApproveChoreButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Model.Concrete currentChore = (Model.Concrete)clickedButton.Tag;
            currentChore.Status = 3;
            currentChore.ApprovalDate = DateTime.Now;
            currentChore.Update();

            var currentChild = Model.ChildUser.Load("child_id=" + currentChore.Assignment);
            currentChild[0].Points += currentChore.Points;
            currentChild[0].Update();
            Model.Notification.Insert(currentChild[0].ID, "Chore Approved", $"The chore {currentChore.Name} has been approved." +
                $"\n{currentChore.Points.ToString()} points has been added to your account");
            LoadAmountOfNotifications();
            LoadChores();
        }

        private void DenyChoreButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Model.Concrete currentChore = (Model.Concrete)clickedButton.Tag;
            var currentChild = Model.ChildUser.Load("child_id=" + currentChore.Assignment);

            if (currentChore.Type == "rep")
            {
                currentChore.Delete();
            }
            else
            {
                currentChore.DueDate = DateTime.Now.AddDays(1);
                currentChore.Status = 1;
                currentChore.Reminder = 0;
                currentChore.Update();
            }
            Model.Notification.Insert(currentChild[0].ID, "Chore Denied", $"The chore {currentChore.Name} has been denied.");
            LoadAmountOfNotifications();
            LoadChores();
        }

        private void EditChoreButton_Click(object sender, System.EventArgs e)
        {
            this.Enabled = false; //Disable ParentUI
            Button clickedButton = (Button)sender;
            try
            {
                Model.Concrete selectedChore = (Model.Concrete)clickedButton.Tag;
                var editSelectedChoreUI = new UI.ParentUI.EditChoreUI(selectedChore);
                editSelectedChoreUI.Show();
                editSelectedChoreUI.FormClosing += ChoreNavigationButton_Click;
            }
            catch
            {
                try
                {
                    Model.Reocurring selectedChore = (Model.Reocurring)clickedButton.Tag;
                    var editSelectedChoreUI = new UI.ParentUI.EditChoreUI(selectedChore);
                    editSelectedChoreUI.Show();
                    editSelectedChoreUI.FormClosing += ChoreNavigationButton_Click;
                }
                catch
                {
                    try
                    {
                        Model.Repeatable selectedChore = (Model.Repeatable)clickedButton.Tag;
                        var editSelectedChoreUI = new UI.ParentUI.EditChoreUI(selectedChore);
                        editSelectedChoreUI.Show();
                        editSelectedChoreUI.FormClosing += ChoreNavigationButton_Click;
                    }
                    catch
                    {
                        MessageBox.Show("Could not edit chore: Conversion failed", "Error");
                    }
                }
            }
        }

        private void DeleteChoreButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this chore?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    Model.Concrete selectedChore = (Model.Concrete)clickedButton.Tag;
                    selectedChore.Delete();
                    LoadChores();
                }
                catch
                {
                    try
                    {
                        Model.Reocurring selectedChore = (Model.Reocurring)clickedButton.Tag;
                        selectedChore.Delete();
                        LoadChores();
                    }
                    catch
                    {
                        try
                        {
                            Model.Repeatable selectedChore = (Model.Repeatable)clickedButton.Tag;
                            selectedChore.Delete();
                            LoadChores();
                        }
                        catch
                        {
                            MessageBox.Show("Could not delete selected chore: Conversion failed", "Error");
                        }
                    }
                }
            }
        }

    #endregion ChoreUI

        #region RewardUI

    private void RewardsUI()
        {
            LoadAmountOfNotifications();
            UI = 2;
            this.rewardPanel.Visible = true;
            this.rewardPanel.BringToFront();
            this.optionButton.Visible = true;
            titleText.Text = "Rewards";
            LoadRewards();
        }

        private void LoadRewards()
        {
            _rewards = Model.Reward.Load("");
            rewardPanel.Controls.Clear();
            int panelDistance = 5;
            int rewardLocationY = 0;

            foreach (Model.Reward reward in _rewards)
            {
                Panel currentReward = LoadReward(reward, rewardLocationY);
                rewardPanel.Controls.Add(currentReward);
                rewardLocationY += currentReward.Height + panelDistance;
            }
        }

        private Panel LoadReward(Model.Reward reward, int yLocation)
        {
            int yLoc = 5;
            int labelDist = 0;

            var rewardName = reward.Name;
            var rewardAssignment = "Assigned to: " + _childrenNames[reward.ChildID];
            var rewardStatus = "Status: Active";

            var rewardNameLabel = UILibrary.StandardElements.AddLabel(rewardName, true, new Point(5, yLoc));
            yLoc += rewardNameLabel.Height + labelDist;
            var rewardAssignmentLabel = UILibrary.StandardElements.AddLabel(rewardAssignment, false, new Point(10, yLoc));
            yLoc += rewardNameLabel.Height + labelDist;
            var rewardStatusLabel = UILibrary.StandardElements.AddLabel(rewardStatus, false, new Point(10, yLoc));
            yLoc += rewardNameLabel.Height + labelDist;

            var panelHeight = rewardNameLabel.Height + rewardAssignmentLabel.Height + rewardStatusLabel.Height;
            var individualRewardPanel = UILibrary.StandardElements.AddPanel(new Point(1, yLocation), chorePanel.Width - 20, panelHeight);

            individualRewardPanel.Controls.Add(rewardNameLabel);
            individualRewardPanel.Controls.Add(rewardAssignmentLabel);
            individualRewardPanel.Controls.Add(rewardStatusLabel);
            individualRewardPanel.Controls.Add(AddEditRewardButton(330, individualRewardPanel.Height / 2, reward));
            individualRewardPanel.Controls.Add(AddDeleteRewardButton(365, individualRewardPanel.Height / 2, reward));

            return individualRewardPanel;
        }

        private Control AddEditRewardButton(int locationX, int locationY, Model.Reward reward)
        {
            var editRewardButton = UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), reward, global::ChoreApplication.Properties.Resources.pencil);
            editRewardButton.Click += new EventHandler(EditRewardButton_Click);
            return editRewardButton;
        }

        private Control AddDeleteRewardButton(int locationX, int locationY, Model.Reward reward)
        {
            var deleteRewardButton = UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), reward, global::ChoreApplication.Properties.Resources.delete);
            deleteRewardButton.Click += new EventHandler(DeleteRewardButton_Click);
            return deleteRewardButton;
        }

        private void EditRewardButton_Click(object sender, System.EventArgs e)
        {
            this.Enabled = false; //Disable ParentUI
            Button clickedButton = (Button)sender;
            try
            {
                Model.Reward selectedReward = (Model.Reward)clickedButton.Tag;
                var editSelectedRewardUI = new EditRewardUI(selectedReward);
                editSelectedRewardUI.Show();
                editSelectedRewardUI.FormClosing += RewardNavigationButton_Click;
            }
            catch
            {
                MessageBox.Show("Could not edit reward: Reward not found", "Error");
            }
        }

        private void DeleteRewardButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Model.Reward selectedReward = (Model.Reward)clickedButton.Tag;

            var confirmDelete = MessageBox.Show("Are you sure you want to delete this reward?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                selectedReward.Delete();
                LoadRewards();
            }
        }

        #endregion RewardUI

        #region LeaderboardUI

        private void LeaderboardsUI()
        {
            LoadAmountOfNotifications();
            UI = 3;
            titleText.Text = "Leaderboard";
            this.leaderboardPanel.Visible = true;
            this.leaderboardPanel.BringToFront();
            this.optionButton.Visible = false;
            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            leaderboardPanel.Controls.Clear();
            if (_childUsers.Count != 0)
            {
                int panelDistance = 20;
                int leaderboardLocationY = 10;

                //Add Total Points title
                var totalPointsEarnedLabel = UILibrary.StandardElements.AddLabel("Total Points Earned", true, new Point(140, leaderboardLocationY));
                this.leaderboardPanel.Controls.Add(totalPointsEarnedLabel);
                leaderboardLocationY += totalPointsEarnedLabel.Height + panelDistance;

                //Add Total Points panel
                var totalPointsStatisticPanel = Functions.SystemFunctions.LeaderboardFunctions.LoadTotalPoints(new Point(0, leaderboardLocationY),
                    leaderboardPanel.Width, _childrenNames, _childUsers);
                this.leaderboardPanel.Controls.Add(totalPointsStatisticPanel);
                leaderboardLocationY += totalPointsStatisticPanel.Height + panelDistance;

                //Add Total Chores Approved title
                var totalChoresApprovedLabel = UILibrary.StandardElements.AddLabel("Total Chores Approved", true, new Point(140, leaderboardLocationY));
                this.leaderboardPanel.Controls.Add(totalChoresApprovedLabel);
                leaderboardLocationY += totalChoresApprovedLabel.Height + panelDistance;

                //Add Total Chores Approved panel
                var totalChoresApprovedStatisticPanel = Functions.SystemFunctions.LeaderboardFunctions.LoadTotalChoresApproved(new Point(0, leaderboardLocationY),
                    leaderboardPanel.Width, _childrenNames, _childUsers);
                this.leaderboardPanel.Controls.Add(totalChoresApprovedStatisticPanel);
                leaderboardLocationY += totalChoresApprovedStatisticPanel.Height + panelDistance;

                //Add Completion Rate title
                var completionRateLabel = UILibrary.StandardElements.AddLabel("Completion Rate", true, new Point(140, leaderboardLocationY));
                this.leaderboardPanel.Controls.Add(completionRateLabel);
                leaderboardLocationY += completionRateLabel.Height + panelDistance;

                //Add Completion Rate panel
                var completionRateStatisticPanel = Functions.SystemFunctions.LeaderboardFunctions.LoadCompletionRate(new Point(0, leaderboardLocationY),
                    leaderboardPanel.Width, _childrenNames, _childUsers);
                this.leaderboardPanel.Controls.Add(completionRateStatisticPanel);
                leaderboardLocationY += completionRateStatisticPanel.Height + panelDistance;

                //Add Longest streak title
                var longestStreakLabel = UILibrary.StandardElements.AddLabel("Longest Streak", true, new Point(140, leaderboardLocationY));
                this.leaderboardPanel.Controls.Add(longestStreakLabel);
                leaderboardLocationY += longestStreakLabel.Height + panelDistance;

                //Add Longest Strea panel
                var longestStreakStatisticPanel = Functions.SystemFunctions.LeaderboardFunctions.LoadLongestStreak(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
                this.leaderboardPanel.Controls.Add(longestStreakStatisticPanel);
            }
        }

        #endregion LeaderboardUI

        #region UsersUI

        private void UsersUI()
        {
            LoadAmountOfNotifications();
            UI = 4;
            titleText.Text = "Users";
            this.userPanel.Visible = true;
            this.userPanel.BringToFront();
            this.optionButton.Visible = true;
            LoadUsers();
        }

        public void LoadUsers()
        {
            _childUsers = Model.ChildUser.Load("");
            _parentUsers = Model.ParentUser.Load("");
            userPanel.Controls.Clear();
            int panelDistance = 5;
            int userLocationY = 0;

            foreach (Model.ParentUser parent in _parentUsers)
            {
                Panel currentPanel = LoadParent(parent, userLocationY);
                userPanel.Controls.Add(currentPanel);
                userLocationY += currentPanel.Height + panelDistance;
            }

            foreach (Model.ChildUser child in _childUsers)
            {
                Panel currentPanel = LoadChild(child, userLocationY);
                userPanel.Controls.Add(currentPanel);
                userLocationY += currentPanel.Height + panelDistance;
            }
        }

        private Panel LoadChild(Model.ChildUser child, int yLocation)
        {
            var individualUserPanel = LoadUser(child, yLocation);
            individualUserPanel.Controls.Add(AddEditChildButton(330, individualUserPanel.Height / 2, child));
            individualUserPanel.Controls.Add(AddDeleteChildButton(365, individualUserPanel.Height / 2, child));
            return individualUserPanel;
        }

        private Panel LoadParent(Model.ParentUser parent, int yLocation)
        {
            var individualUserPanel = LoadUser(parent, yLocation);
            individualUserPanel.Controls.Add(AddEditParentButton(365, individualUserPanel.Height / 2, parent));
            return individualUserPanel;
        }

        private Panel LoadUser(Model.User user, int yLocation)
        {
            var userFirstName = user.FirstName.ToString();

            var userFirstNameLabel = UILibrary.StandardElements.AddLabel(userFirstName, true, new Point(5, 5));
            var panelHeight = userFirstNameLabel.Height + 40;
            var individualUserPanel = UILibrary.StandardElements.AddPanel(new Point(1, yLocation), chorePanel.Width - 20, panelHeight);
            individualUserPanel.Controls.Add(userFirstNameLabel);

            return individualUserPanel;
        }

        private Control AddEditChildButton(int locationX, int locationY, Model.ChildUser childUser)
        {
            var editChildButton = UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), childUser, global::ChoreApplication.Properties.Resources.pencil);
            editChildButton.Click += new EventHandler(EditChildButton_Click);
            return editChildButton;
        }

        private Control AddEditParentButton(int locationX, int locationY, Model.ParentUser parentUser)
        {
            var editParentButton = UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), parentUser, global::ChoreApplication.Properties.Resources.pencil);
            editParentButton.Click += new EventHandler(EditParentButton_Click);
            return editParentButton;
        }

        private Control AddDeleteChildButton(int locationX, int locationY, Model.ChildUser childUser)
        {
            var deleteChildButton = UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), childUser, global::ChoreApplication.Properties.Resources.delete);
            deleteChildButton.Click += new EventHandler(DeleteChildButton_Click);
            return deleteChildButton;
        }

        private void DeleteChildButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Model.ChildUser selectedUser = (Model.ChildUser)clickedButton.Tag;

            var confirmDelete = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                selectedUser.Delete();
                UsersUI();
            }
        }

        private void EditParentButton_Click(object sender, System.EventArgs e)
        {
            this.Enabled = false; //Disable ParentUI
            Button clickedButton = (Button)sender;
            try
            {
                Model.ParentUser selectedParent = (Model.ParentUser)clickedButton.Tag;
                var editSelectedParentUI = new EditParentUI(selectedParent);
                editSelectedParentUI.Show();
                editSelectedParentUI.FormClosing += UsersNavigationButton_Click;
            }
            catch
            {
                MessageBox.Show("Could not edit Parent: Parent not found", "Error");
            }
        }

        private void EditChildButton_Click(object sender, System.EventArgs e)
        {
            this.Enabled = false; //Disable ParentUI
            Button clickedButton = (Button)sender;
            try
            {
                Model.ChildUser selectedChild = (Model.ChildUser)clickedButton.Tag;
                var editSelectedChildUI = new EditChildUI(selectedChild);
                editSelectedChildUI.Show();
                editSelectedChildUI.FormClosing += UsersNavigationButton_Click;
            }
            catch
            {
                MessageBox.Show("Could not edit child: Child not found", "Error");
            }
        }

        #endregion UsersUI

        #region NotificationsUI

        private void NotificationsUI()
        {
            UI = 5;
            titleText.Text = "Notifications";
            this.notificationPanel.Visible = true;
            this.notificationPanel.BringToFront();
            this.optionButton.Visible = false;
            LoadNotifications();
            LoadAmountOfNotifications();
        }

        private void LoadNotifications()
        {
            _notifications = Model.Notification.Load("user_id=" + _session.ID);
            notificationPanel.Controls.Clear();
            int panelDistance = 5;
            int notificationLocationY = 0;

            foreach (Model.Notification notification in _notifications)
            {
                var individualNotificationPanel = LoadNotification(notification, notificationLocationY);
                notificationPanel.Controls.Add(individualNotificationPanel);
                notificationLocationY += individualNotificationPanel.Height + panelDistance;
            }
        }

        private Panel LoadNotification(Model.Notification notification, int yLocation)
        {
            int labelDistance = 0;
            int yLoc = 5;

            var notificationTitle = notification.Title;
            var notificationDescription = notification.Description;

            var notificationTitleLabel = UILibrary.StandardElements.AddLabel(notificationTitle, true, new Point(5, yLoc));
            yLoc += notificationTitleLabel.Height + labelDistance;
            var notificationDescriptionLabel = UILibrary.StandardElements.AddLabel(notificationDescription, false, new Point(10, yLoc));
            var panelHeight = notificationTitleLabel.Height + notificationDescriptionLabel.Height;
            var individualNotificationPanel = UILibrary.StandardElements.AddPanel(new Point(1, yLocation), chorePanel.Width - 20, panelHeight);

            individualNotificationPanel.Controls.Add(notificationTitleLabel);
            individualNotificationPanel.Controls.Add(notificationDescriptionLabel);
            individualNotificationPanel.Controls.Add(AddDeleteNotificationButton(365, individualNotificationPanel.Height / 2, notification));

            return individualNotificationPanel;
        }

        private Control AddDeleteNotificationButton(int locationX, int locationY, Model.Notification notification)
        {
            var deleteNotificationButton = UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), notification, global::ChoreApplication.Properties.Resources.delete);
            deleteNotificationButton.Click += new EventHandler(NotificationDeleteButton_Click);
            return deleteNotificationButton;
        }

        private void NotificationDeleteButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Model.Notification currentNotification = (Model.Notification)clickedButton.Tag;
            currentNotification.Delete();
            NotificationsUI();
        }

        private void LoadAmountOfNotifications()
        {
            _notifications = Model.Notification.Load("user_id=" + _session.ID);
            notificationAmountLabel.Text = "";
            if (_notifications.Count == 0)
            {
                notificationAmountLabel.Visible = false;
            }
            else
            {
                notificationAmountLabel.Text = _notifications.Count.ToString();
            }
        }

        #endregion NotificationsUI

        #region UpperPanel

        private void UserButton_Click(object sender, EventArgs e)
        {
            var loginInterface = new GeneralInterface.LoginInterface();
            _session = default;
            loginInterface.Show();
            this.Close();
        }

        #endregion UpperPanel
    }
}