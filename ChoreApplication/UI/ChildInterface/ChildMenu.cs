using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChoreApplication.UI.ChildUI
{
    public partial class ChildMenu : Form
    {
        public int UI = 0;
        private Model.ChildUser _session;
        private Dictionary<int, string> _statusValues;
        private Dictionary<int, string> _childrenNames;
        private List<Model.ChildUser> _childUsers;
        private List<Model.Concrete> _activeConcreteChores;
        private List<Model.Repeatable> _activeRepeatableChores;
        private List<Model.Reward> _rewards;
        private List<Model.Notification> _notifications;

        public ChildMenu(Model.ChildUser child)
        {
            _session = child;
            InitializeComponent();
            InitializeDictionaries();
            LoadPoints();
            LoadAmountOfNotifications();
            ChoresUI();
        }

        private void LoadPoints()
        {
            childPointsLabel.Text = "Points: " + _session.Points.ToString();
        }

        private void InitializeDictionaries()
        {
            _statusValues = new Dictionary<int, string>
            {
                { 1, "Active" },
                { 2, "Approval pending" },
            };
            _childUsers = Model.ChildUser.Load("");
            _childrenNames = new Dictionary<int, string>();
            foreach (var child in _childUsers)
            {
                _childrenNames.Add(child.ChildID, child.FirstName);
            }
        }

        #region ChoreUI

        public void ChoresUI()
        {
            UI = 1;
            this.chorePanel.Visible = true;
            this.chorePanel.BringToFront();
            titleText.Text = "Chores";
            LoadChores();
        }

        public void LoadChores()
        {
            _activeConcreteChores = Model.Concrete.Load($"(status=1 OR status=2) AND ch.child_id={_session.ChildID} ORDER BY status ASC");
            _activeRepeatableChores = Model.Repeatable.Load($"ch.child_id={_session.ChildID}");
            chorePanel.Controls.Clear();
            int choreLocationY = 0;
            int panelDistance = 5;

            foreach (var chore in _activeConcreteChores)
            {
                Panel currentPanel = LoadConcreteChore(chore, chorePanel.Width - 20, choreLocationY);
                chorePanel.Controls.Add(currentPanel);
                choreLocationY += currentPanel.Height + panelDistance;
            }

            foreach (var chore in _activeRepeatableChores)
            {
                Panel currentPanel = LoadRepeatableChore(chore, chorePanel.Width - 20, choreLocationY);
                chorePanel.Controls.Add(currentPanel);
                choreLocationY += currentPanel.Height + panelDistance;
            }
        }

        private Panel LoadChore(Model.Chore chore, Point location, int points, string label1, string label2)
        {
            int yLoc = 5;
            int labelDist = 0;

            var choreName = chore.Name;
            var choreDescription = "Description: " + chore.Description;
            var chorePoints = "Points: " + points.ToString();

            var choreNameLabel = UILibrary.StandardElements.AddLabel(choreName, true, new Point(5, yLoc));
            yLoc += choreNameLabel.Height + labelDist;
            var choreDescriptionLabel = UILibrary.StandardElements.AddLabel(choreDescription, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + labelDist;
            var chorePointsLabel = UILibrary.StandardElements.AddLabel(chorePoints, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + labelDist;
            var choreLimitLabel = UILibrary.StandardElements.AddLabel(label1, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + labelDist;
            var choreCompletionsLabel = UILibrary.StandardElements.AddLabel(label2, false, new Point(10, yLoc));
            var panelHeight = choreNameLabel.Height + chorePointsLabel.Height + choreDescriptionLabel.Height + choreLimitLabel.Height + choreCompletionsLabel.Height;

            var individualChorePanel = UILibrary.StandardElements.AddPanel(location, chorePanel.Width - 25, panelHeight);

            chorePanel.Controls.Add(individualChorePanel);
            individualChorePanel.Controls.Add(choreNameLabel);
            individualChorePanel.Controls.Add(chorePointsLabel);
            individualChorePanel.Controls.Add(choreDescriptionLabel);
            individualChorePanel.Controls.Add(choreLimitLabel);
            individualChorePanel.Controls.Add(choreCompletionsLabel);

            return individualChorePanel;
        }

        private Panel LoadRepeatableChore(Model.Repeatable chore, int width, int yLocation)
        {
            double calcDimishingReturn = chore.Points;
            for (int j = 0; j < chore.Completions; j++)
            {
                calcDimishingReturn *= 0.75;
            }
            int diminishedPoints = (int)calcDimishingReturn;

            var chorePoints = "Points: " + diminishedPoints.ToString();
            var choreLimit = "Completion limit: " + chore.Limit.ToString();
            var choreCompletions = "Amount completed today: " + chore.Completions.ToString();

            var individualChorePanel = LoadChore(chore, new Point(1, yLocation), diminishedPoints, choreLimit, choreCompletions);

            var repChoreDoneButton = AddRepeatableChoreDoneButton(330, individualChorePanel.Height / 2, chore);
            if (chore.Completions >= chore.Limit)
            {
                var limitReachedLabel = UILibrary.StandardElements.AddLabel("Limit reached", false, new Point(290, individualChorePanel.Height / 2));
                limitReachedLabel.Enabled = false;
                individualChorePanel.Controls.Add(limitReachedLabel);
            }
            else
            {
                individualChorePanel.Controls.Add(repChoreDoneButton);
                individualChorePanel.Controls.Add(UILibrary.StandardElements.AddLabel("Completed?", false, new Point(305, individualChorePanel.Height / 2 + 20)));
            }

            return individualChorePanel;
        }

        private Panel LoadConcreteChore(Model.Concrete chore, int width, int yLocation)
        {
            var choreStatus = "Status: " + _statusValues[chore.Status];
            var choreDueDate = "Due date: " + chore.DueDate.ToString(Properties.Settings.Default.ShortDateFormat);

            var individualChorePanel = LoadChore(chore, new Point(1, yLocation), chore.Points, choreStatus, choreDueDate);

            if (chore.Status == 1)
            {
                individualChorePanel.Controls.Add(AddConcreteChoreDoneButton(330, individualChorePanel.Height / 2, chore));
                individualChorePanel.Controls.Add(UILibrary.StandardElements.AddLabel("Completed?", false, new Point(305, individualChorePanel.Height / 2 + 20)));
            }

            return individualChorePanel;
        }

        private Button AddRepeatableChoreDoneButton(int locationX, int locationY, Model.Repeatable chore)
        {
            var reatableChoreDoneButton = UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), chore, global::ChoreApplication.Properties.Resources.thumbs_up);
            if (chore.Completions >= chore.Limit)
            {
                reatableChoreDoneButton.Enabled = false;
            }
            reatableChoreDoneButton.Click += new EventHandler(RepeatableChoreDoneButton_Click);
            return reatableChoreDoneButton;
        }

        private void RepeatableChoreDoneButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Model.Repeatable currentChore = (Model.Repeatable)clickedButton.Tag;
            double calculateDiminishingReturn = currentChore.Points;
            for (int i = 0; i < currentChore.Completions; i++)
            {
                calculateDiminishingReturn *= 0.75;
            }
            int diminishedPoints = (int)calculateDiminishingReturn;

            Model.Concrete.Insert(currentChore.Name, currentChore.Description, diminishedPoints, currentChore.Assignment, new DateTime(2000, 1, 1, 0, 0, 0), "rep");
            currentChore.Completions++;
            currentChore.Update();
            Model.Notification.Insert(1, $"{_childrenNames[currentChore.Assignment]} completed a chore.", $"{_childrenNames[currentChore.Assignment]} completed the chore {currentChore.Name}.");
            LoadAmountOfNotifications();
            LoadChores();
        }
        
        private Control AddConcreteChoreDoneButton(int locationX, int locationY, Model.Concrete chore)
        {
            var concreteChoreDoneButton = UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), chore, global::ChoreApplication.Properties.Resources.thumbs_up);
            concreteChoreDoneButton.Click += new EventHandler(ConcreteChoreDoneButton_Click);
            return concreteChoreDoneButton;
        }

        private void ConcreteChoreDoneButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Model.Concrete currentChore = (Model.Concrete)clickedButton.Tag;
            currentChore.Status = 2;
            currentChore.Update();
            Model.Notification.Insert(1, $"{_childrenNames[currentChore.Assignment]} completed a chore.", $"{_childrenNames[currentChore.Assignment]} completed the chore {currentChore.Name}.");
            LoadAmountOfNotifications();
            LoadChores();
        }

        #endregion ChoreUI

        #region RewardUI

        private void RewardsUI()
        {
            UI = 2;
            this.RewardPanel.Visible = true;
            this.RewardPanel.BringToFront();
            titleText.Text = "Rewards";
            LoadRewards();
        }

        private void LoadRewards()
        {
            _rewards = Model.Reward.Load("child_id=" + _session.ChildID);
            RewardPanel.Controls.Clear();
            int yLoc = 0;
            int panelDist = 5;

            foreach (Model.Reward reward in _rewards)
            {
                Panel currentPanel = LoadReward(reward, yLoc);
                RewardPanel.Controls.Add(currentPanel);
                yLoc += currentPanel.Height + panelDist;
            }
        }

        private Panel LoadReward(Model.Reward reward, int yLocation)
        {
            var rewardName = reward.Name;
            var rewardPointsRequired = "Points required: " + reward.PointsRequired.ToString();
            var childPoints = (double)_session.Points;
            var requiredPoints = (double)reward.PointsRequired;
            var progressBarValue = (childPoints / requiredPoints) * 100;

            var rewardNameLabel = UILibrary.StandardElements.AddLabel(rewardName, true, new Point(5, 5));
            var rewardPointsRequiredLabel = UILibrary.StandardElements.AddLabel(rewardPointsRequired, false, new Point(10, rewardNameLabel.Location.Y + 20));
            var rewardProgressBar = new ProgressBar
            {
                Location = new Point(10, rewardPointsRequiredLabel.Location.Y + 20),
                Size = new Size(250, 25),
                Tag = reward,
            };
            if (progressBarValue > 100)
            {
                rewardProgressBar.Value = 100;
            }
            else
            {
                rewardProgressBar.Value = (int)progressBarValue;
            }
            var panelHeight = rewardNameLabel.Height + rewardPointsRequiredLabel.Height + rewardProgressBar.Height;
            var individualRewardPanel = UILibrary.StandardElements.AddPanel(new Point(1, yLocation), RewardPanel.Width - 25, panelHeight);

            individualRewardPanel.Controls.Add(rewardNameLabel);
            individualRewardPanel.Controls.Add(rewardPointsRequiredLabel);
            individualRewardPanel.Controls.Add(rewardProgressBar);
            if (rewardProgressBar.Value == 100)
            {
                individualRewardPanel.Controls.Add(AddClaimRewardButton(335, individualRewardPanel.Height / 2, reward));
                individualRewardPanel.Controls.Add(UILibrary.StandardElements.AddLabel("Claim reward", false, new Point(305, individualRewardPanel.Height / 2 + 20)));
            }

            return individualRewardPanel;
        }

        private Control AddClaimRewardButton(int locationX, int locationY, Model.Reward reward)
        {
            var claimButton = UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), reward, global::ChoreApplication.Properties.Resources.check);
            claimButton.Click += new EventHandler(ClaimRewardButton_Click);
            return claimButton;
        }

        private void ClaimRewardButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Model.Reward currentReward = (Model.Reward)clickedButton.Tag;

            var confirmDelete = MessageBox.Show("Are you sure you want to claim this reward?", "Claim Reward", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                _session.Points -= currentReward.PointsRequired;
                _session.Update();
                currentReward.Delete();
                LoadPoints();
                LoadRewards();
                Model.Notification.Insert(1, "Reward has been claimed.", $"The reward {currentReward.Name}: {currentReward.Description} " +
                    $"has been claimed by {_childrenNames[currentReward.ChildID]}");
                LoadAmountOfNotifications();
            }
        }

        #endregion RewardUI

        #region LeaderBoardUI

        public void LeaderboardUI()
        {
            UI = 3;
            titleText.Text = "Leaderboard";
            this.leaderboardPanel.Visible = true;
            this.leaderboardPanel.BringToFront();
            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            leaderboardPanel.Controls.Clear();
            int panelDistance = 20;
            int leaderboardLocationY = 10;

            //Add Total Points title
            var totalPointsEarnedLabel = UILibrary.StandardElements.AddLabel("Total Points Earned", true, new Point(140, leaderboardLocationY));
            this.leaderboardPanel.Controls.Add(totalPointsEarnedLabel);
            leaderboardLocationY += totalPointsEarnedLabel.Height + panelDistance;

            //Add Total Points panel
            var totalPointsStatisticPanel = Functions.UIFunctions.LoadTotalPoints(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
            this.leaderboardPanel.Controls.Add(totalPointsStatisticPanel);
            leaderboardLocationY += totalPointsStatisticPanel.Height + panelDistance;

            //Add Total Chores Approved title
            var totalChoresApprovedLabel = UILibrary.StandardElements.AddLabel("Total Chores Approved", true, new Point(140, leaderboardLocationY));
            this.leaderboardPanel.Controls.Add(totalChoresApprovedLabel);
            leaderboardLocationY += totalChoresApprovedLabel.Height + panelDistance;

            //Add Total Chores Approved panel
            var totalChoresApprovedStatisticPanel = Functions.UIFunctions.LoadTotalChoresApproved(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
            this.leaderboardPanel.Controls.Add(totalChoresApprovedStatisticPanel);
            leaderboardLocationY += totalChoresApprovedStatisticPanel.Height + panelDistance;

            //Add Completion Rate title
            var completionRateLabel = UILibrary.StandardElements.AddLabel("Completion Rate", true, new Point(140, leaderboardLocationY));
            this.leaderboardPanel.Controls.Add(completionRateLabel);
            leaderboardLocationY += completionRateLabel.Height + panelDistance;

            //Add Completion Rate panel
            var completionRateStatisticPanel = Functions.UIFunctions.LoadCompletionRate(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
            this.leaderboardPanel.Controls.Add(completionRateStatisticPanel);
            leaderboardLocationY += completionRateStatisticPanel.Height + panelDistance;

            //Add Longest streak title
            var longestStreakLabel = UILibrary.StandardElements.AddLabel("Longest Streak", true, new Point(140, leaderboardLocationY));
            this.leaderboardPanel.Controls.Add(longestStreakLabel);
            leaderboardLocationY += longestStreakLabel.Height + panelDistance;

            //Add Longest Streak panel
            var longestStreakStatisticPanel = Functions.UIFunctions.LoadLongestStreak(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
            this.leaderboardPanel.Controls.Add(longestStreakStatisticPanel);
        }

        #endregion LeaderBoardUI

        #region NotificationUI

        public void NotificationUI()
        {
            UI = 4;
            titleText.Text = "Notifications";
            this.notificationPanel.Visible = true;
            this.notificationPanel.BringToFront();
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            _notifications = Model.Notification.Load("user_id=" + _session.ID);
            notificationPanel.Controls.Clear();
            int panelDistance = 5;
            int notificationLocationY = 0;

            foreach (Model.Notification notification in _notifications)
            {
                var individualNotificationPanel = Functions.UIFunctions.LoadNotification(notification, chorePanel.Width - 20, notificationLocationY);
                individualNotificationPanel.Controls.Add(AddDeleteNotificationButton(365, individualNotificationPanel.Height / 2, notification));
                notificationPanel.Controls.Add(individualNotificationPanel);
                notificationLocationY += individualNotificationPanel.Height + panelDistance;
            }
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
            NotificationUI();
        }

        private void LoadAmountOfNotifications()
        {
            _notifications = Model.Notification.Load("user_id=" + _session.ID);
            notificationAmount.Text = "";
            if (_notifications.Count == 0)
            {
                notificationAmount.Visible = false;
            }
            else
            {
                notificationAmount.Text = _notifications.Count.ToString();
            }
        }

        #endregion NotificationUI

        #region NavigationMenu

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
            LeaderboardUI();
        }

        private void NotificationsNavButton_Click(object sender, EventArgs e)
        {
            NotificationUI();
        }

        #endregion NavigationMenu

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