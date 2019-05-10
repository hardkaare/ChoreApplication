﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChoreApplication.UI
{
    public partial class ChildInterface : Form
    {
        public int UI = 0;
        public ChildUser Session { get; set; }
        private Dictionary<int, string> _statusValues;
        private Dictionary<int, string> _childrenNames;
        private List<ChildUser> _childUsers;
        private List<Concrete> _activeConcreteChores;
        private List<Repeatable> _activeRepeatableChores;
        private List<Reward> _rewards;
        private List<Notification> _notifications;

        public ChildInterface(ChildUser child)
        {
            Session = child;
            InitializeComponent();
            InitializeDictionaries();
            LoadPoints();
            LoadAmountOfNotifications();
            ChoresUI();
            SystemFunctions.CheckTime(_childUsers);
        }

        private void LoadPoints()
        {
            childPointsLabel.Text = "Points: " + Session.Points.ToString();
        }

        private void InitializeDictionaries()
        {
            _statusValues = new Dictionary<int, string>
            {
                { 1, "Active" },
                { 2, "Approval pending" },
            };
            _childUsers = ChildUser.Load("");
            _childrenNames = new Dictionary<int, string>();
            foreach (var child in _childUsers)
            {
                _childrenNames.Add(child.ChildID, child.FirstName);
            }
        }

        private Control AddLabel(string labelText, bool isBold, int locationX, int locationY)
        {
            var label = new Label
            {
                Text = labelText,
                Location = new Point(locationX, locationY),
                MaximumSize = new Size(295, 20),
                AutoSize = true,
                AutoEllipsis = true,
            };
            if (!isBold)
            {
                label.Font = Properties.Settings.Default.StandardFont;
                return label;
            }
            if (isBold)
            {
                label.Font = Properties.Settings.Default.StandardFontBold;
                return label;
            }
            return label;
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
            _activeConcreteChores = Concrete.Load($"(status=1 OR status=2) AND ch.child_id={Session.ChildID} ORDER BY status ASC");
            _activeRepeatableChores = Repeatable.Load($"ch.child_id={Session.ChildID}");
            chorePanel.Controls.Clear();
            int i = 0;
            int panelDistance = 95;

            foreach (var chore in _activeConcreteChores)
            {
                var choreName = chore.Name.ToString();
                var chorePoints = "Points: " + chore.Points.ToString();
                var choreDescription = "Description: " + chore.Description.ToString();
                var choreStatus = "Status: " + _statusValues[chore.Status];
                var choreDueDate = "Due date: " + chore.DueDate.ToString(Properties.Settings.Default.ShortDateFormat);

                var choreNameLabel = AddLabel(choreName, true, 5, 5);
                var chorePointsLabel = AddLabel(chorePoints, false, 10, choreNameLabel.Location.Y + 20);
                var choreDescriptionLabel = AddLabel(choreDescription, false, 10, chorePointsLabel.Location.Y + 20);
                var choreDueDateLabel = AddLabel(choreDueDate, false, 10, choreDescriptionLabel.Location.Y + 20);
                var choreStatusLabel = AddLabel(choreStatus, false, 10, choreDescriptionLabel.Location.Y + 20);
                var panelHeight = choreNameLabel.Height + chorePointsLabel.Height + choreDescriptionLabel.Height + choreDueDateLabel.Height;
                var individualChorePanel = new Panel
                {
                    Name = "panel" + chore.ID.ToString(),
                    Location = new Point(1, i * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(chorePanel.Width - 25, panelHeight),
                    AutoSize = true,
                };
                chorePanel.Controls.Add(individualChorePanel);
                individualChorePanel.Controls.Add(choreNameLabel);
                individualChorePanel.Controls.Add(chorePointsLabel);
                individualChorePanel.Controls.Add(choreDescriptionLabel);
                individualChorePanel.Controls.Add(choreDueDateLabel);
                if (chore.Status == 1)
                {
                    individualChorePanel.Controls.Add(AddDoneChoreButton(330, individualChorePanel.Height / 2, chore));
                    individualChorePanel.Controls.Add(AddLabel("Completed?", false, 305, individualChorePanel.Height / 2 + 20));
                }
                if (chore.Status == 2)
                {
                    individualChorePanel.Controls.Remove(choreDueDateLabel);
                    individualChorePanel.Controls.Add(choreStatusLabel);
                }
                i++;
            }

            foreach (var chore in _activeRepeatableChores)
            {
                double calcDimishingReturn = chore.Points;
                for (int j = 0; j < chore.Completions; j++)
                {
                    calcDimishingReturn *= 0.75;
                }
                int diminishedPoints = (int)calcDimishingReturn;

                var choreName = chore.Name.ToString();
                var chorePoints = "Points: " + diminishedPoints.ToString();
                var choreDescription = "Description: " + chore.Description.ToString();
                var choreLimit = "Completion limit: " + chore.Limit.ToString();
                var choreCompletions = "Amount completed today: " + chore.Completions.ToString();

                var choreNameLabel = AddLabel(choreName, true, 5, 5);
                var chorePointsLabel = AddLabel(chorePoints, false, 10, choreNameLabel.Location.Y + 20);
                var choreDescriptionLabel = AddLabel(choreDescription, false, 10, chorePointsLabel.Location.Y + 20);
                var choreLimitLabel = AddLabel(choreLimit, false, 10, choreDescriptionLabel.Location.Y + 20);
                var choreCompletionsLabel = AddLabel(choreCompletions, false, 10, choreLimitLabel.Location.Y + 20);
                var panelHeight = choreNameLabel.Height + chorePointsLabel.Height + choreDescriptionLabel.Height + choreLimitLabel.Height + choreCompletionsLabel.Height;

                var individualChorePanel = new Panel
                {
                    Name = "panel" + chore.ID.ToString(),
                    Location = new Point(1, i * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(chorePanel.Width - 25, panelHeight),
                    AutoSize = true,
                };
                chorePanel.Controls.Add(individualChorePanel);
                individualChorePanel.Controls.Add(choreNameLabel);
                individualChorePanel.Controls.Add(chorePointsLabel);
                individualChorePanel.Controls.Add(choreDescriptionLabel);
                individualChorePanel.Controls.Add(choreLimitLabel);
                individualChorePanel.Controls.Add(choreCompletionsLabel);
                var repChoreDoneButton = AddRepDoneChoreButton(330, individualChorePanel.Height / 2, chore);
                individualChorePanel.Controls.Add(repChoreDoneButton);
                if (chore.Completions >= chore.Limit)
                {
                    var limitReachedLabel = AddLabel("Limit reached", false, 290, individualChorePanel.Height / 2);
                    limitReachedLabel.Enabled = false;
                    individualChorePanel.Controls.Add(limitReachedLabel);
                    individualChorePanel.Controls.Remove(repChoreDoneButton);
                }
                else
                {
                    individualChorePanel.Controls.Add(AddLabel("Completed?", false, 305, individualChorePanel.Height / 2 + 20));
                }
            }
        }

        private Button AddRepDoneChoreButton(int x, int y, Repeatable chore)
        {
            var RepDoneButton = new Button
            {
                Location = new Point(x, y - 15),
                Size = new Size(30, 30),
                Tag = chore,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.thumbs_up,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            RepDoneButton.Cursor = Cursors.Hand;
            RepDoneButton.FlatAppearance.BorderSize = 0;
            RepDoneButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            RepDoneButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            if (chore.Completions >= chore.Limit)
            {
                RepDoneButton.Enabled = false;
            }
            RepDoneButton.Click += new EventHandler(RepDoneButton_Click);
            return RepDoneButton;
        }

        private void RepDoneButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Repeatable currentChore = (Repeatable)clickedButton.Tag;
            double calcDimishingReturn = currentChore.Points;
            for (int i = 0; i < currentChore.Completions; i++)
            {
                calcDimishingReturn *= 0.75;
            }
            int diminishedPoints = (int)calcDimishingReturn;

            Concrete.Insert(currentChore.Name, currentChore.Description, diminishedPoints, currentChore.Assignment, new DateTime(2000, 1, 1, 0, 0, 0), "rep");
            currentChore.Completions++;
            currentChore.Update();
            Notification.Insert(1, $"{_childrenNames[currentChore.Assignment]} completed a chore.", $"{_childrenNames[currentChore.Assignment]} completed the chore {currentChore.Name}.");
            LoadAmountOfNotifications();
            LoadChores();
        }

        private Control AddDoneChoreButton(int x, int y, Concrete chore)
        {
            var DoneButton = new Button
            {
                Location = new Point(x, y - 15),
                Size = new Size(30, 30),
                Tag = chore,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.thumbs_up,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            DoneButton.Cursor = Cursors.Hand;
            DoneButton.FlatAppearance.BorderSize = 0;
            DoneButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            DoneButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            DoneButton.Click += new EventHandler(DoneButton_Click);
            return DoneButton;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Concrete currentChore = (Concrete)clickedButton.Tag;
            currentChore.Status = 2;
            currentChore.Update();
            Notification.Insert(1, $"{_childrenNames[currentChore.Assignment]} completed a chore.", $"{_childrenNames[currentChore.Assignment]} completed the chore {currentChore.Name}.");
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

        #endregion RewardUI

        private void LoadRewards()
        {
            _rewards = Reward.Load("child_id=" + Session.ChildID);
            RewardPanel.Controls.Clear();
            int distanceCounter = 0;
            int panelDistance = 72;

            foreach (Reward reward in _rewards)
            {
                var rewardName = reward.Name.ToString();
                var rewardPointsRequired = "Points required: " + reward.PointsRequired.ToString();
                var childPoints = (double)Session.Points;
                var requiredPoints = (double)reward.PointsRequired;
                var progressBarValue = (childPoints / requiredPoints) * 100;

                var rewardNameLabel = AddLabel(rewardName, true, 5, 5);
                var rewardPointsRequiredLabel = AddLabel(rewardPointsRequired, false, 10, rewardNameLabel.Location.Y + 20);
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
                var individualRewardPanel = new Panel
                {
                    Location = new Point(1, distanceCounter * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(RewardPanel.Width - 25, panelHeight),
                    AutoSize = true,
                };
                RewardPanel.Controls.Add(individualRewardPanel);
                individualRewardPanel.Controls.Add(rewardNameLabel);
                individualRewardPanel.Controls.Add(rewardPointsRequiredLabel);
                individualRewardPanel.Controls.Add(rewardProgressBar);
                if (rewardProgressBar.Value == 100)
                {
                    individualRewardPanel.Controls.Add(AddClaimRewardButton(335, individualRewardPanel.Height / 2, reward));
                    individualRewardPanel.Controls.Add(AddLabel("Claim reward", false, 305, individualRewardPanel.Height / 2 + 20));
                }
                distanceCounter++;
            }
        }

        private Control AddClaimRewardButton(int locationX, int locationY, Reward reward)
        {
            var claimButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = reward,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.check,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            claimButton.Cursor = Cursors.Hand;
            claimButton.FlatAppearance.BorderSize = 0;
            claimButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            claimButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            claimButton.Click += new EventHandler(ClaimRewardButton_Click);
            return claimButton;
        }

        private void ClaimRewardButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Reward currentReward = (Reward)clickedButton.Tag;

            var confirmDelete = MessageBox.Show("Are you sure you want to claim this reward?", "Claim Reward", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                Session.Points -= currentReward.PointsRequired;
                Session.Update();
                currentReward.Delete();
                LoadPoints();
                LoadRewards();
                Notification.Insert(1, "Reward has been claimed.", $"The reward {currentReward.Name}: {currentReward.Description} " +
                    $"has been claimed by {_childrenNames[currentReward.ChildID]}");
                LoadAmountOfNotifications();
            }
        }

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
            var totalPointsEarnedLabel = AddLabel("Total Points Earned", true, 140, leaderboardLocationY);
            this.leaderboardPanel.Controls.Add(totalPointsEarnedLabel);
            leaderboardLocationY += totalPointsEarnedLabel.Height + panelDistance;

            //Add Total Points panel
            var totalPointsStatisticPanel = SystemFunctions.LoadTotalPoints(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
            this.leaderboardPanel.Controls.Add(totalPointsStatisticPanel);
            leaderboardLocationY += totalPointsStatisticPanel.Height + panelDistance;

            //Add Total Chores Approved title
            var totalChoresApprovedLabel = AddLabel("Total Chores Approved", true, 140, leaderboardLocationY);
            this.leaderboardPanel.Controls.Add(totalChoresApprovedLabel);
            leaderboardLocationY += totalChoresApprovedLabel.Height + panelDistance;

            //Add Total Chores Approved panel
            var totalChoresApprovedStatisticPanel = SystemFunctions.LoadTotalChoresApproved(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
            this.leaderboardPanel.Controls.Add(totalChoresApprovedStatisticPanel);
            leaderboardLocationY += totalChoresApprovedStatisticPanel.Height + panelDistance;

            //Add Completion Rate title
            var completionRateLabel = AddLabel("Completion Rate", true, 140, leaderboardLocationY);
            this.leaderboardPanel.Controls.Add(completionRateLabel);
            leaderboardLocationY += completionRateLabel.Height + panelDistance;

            //Add Completion Rate panel
            var completionRateStatisticPanel = SystemFunctions.LoadCompletionRate(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
            this.leaderboardPanel.Controls.Add(completionRateStatisticPanel);
            leaderboardLocationY += completionRateStatisticPanel.Height + panelDistance;

            //Add Longest streak title
            var longestStreakLabel = AddLabel("Longest Streak", true, 140, leaderboardLocationY);
            this.leaderboardPanel.Controls.Add(longestStreakLabel);
            leaderboardLocationY += longestStreakLabel.Height + panelDistance;

            //Add Longest Strea panel
            var longestStreakStatisticPanel = SystemFunctions.LoadLongestStreak(new Point(0, leaderboardLocationY),
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
            LoadNotification();
        }

        private void LoadNotification()
        {
            _notifications = Notification.Load("user_id=" + Session.ID);
            notificationPanel.Controls.Clear();
            int distanceCounter = 0;
            int panelDistance = 50;

            foreach (Notification notification in _notifications)
            {
                var notificationTitle = notification.Title;
                var notificationDescription = notification.Description;

                var notificationTitleLabel = AddLabel(notificationTitle, true, 5, 5);
                var notificationDescriptionLabel = AddLabel(notificationDescription, false, 10, notificationTitleLabel.Location.Y + 20);
                var panelHeight = notificationTitleLabel.Height + notificationDescriptionLabel.Height;
                var individualNotificationPanel = new Panel
                {
                    Location = new Point(1, distanceCounter * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(chorePanel.Width - 25, panelHeight),
                    AutoSize = true,
                };
                individualNotificationPanel.Controls.Add(notificationTitleLabel);
                individualNotificationPanel.Controls.Add(notificationDescriptionLabel);
                individualNotificationPanel.Controls.Add(AddNotificationDeleteButton(365, individualNotificationPanel.Height / 2, notification));
                notificationPanel.Controls.Add(individualNotificationPanel);
                distanceCounter++;
            }
        }

        private Control AddNotificationDeleteButton(int locationX, int locationY, Notification notification)
        {
            var deleteButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = notification,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.delete,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            deleteButton.Click += new EventHandler(NotificationDeleteButton_Click);
            return deleteButton;
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
            _notifications = Notification.Load("user_id=" + Session.ID);
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
            var loginInterface = new LoginInterface();
            Session = default;
            loginInterface.Show();
            this.Close();
        }

        #endregion UpperPanel
    }
}