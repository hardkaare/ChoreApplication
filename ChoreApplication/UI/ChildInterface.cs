﻿using System;
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
        public ChildUser CurrentUser { get; set; }
        private Dictionary<int, string> StatusValues;
        private List<Concrete> ActiveConcreteChores;
        private List<Reward> Rewards;
        private List<Notification> Notifications;
        private readonly Font StandardFont = new Font("Microsoft Sans Serif", 10F);
        private readonly Font StandardFontBold = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
        public ChildInterface(ChildUser child)
        {
            CurrentUser = child;
            InitializeComponent();
            InitializeDictionaries();
            LoadPoints();
            LoadAmountOfNotifications();
            ChoresUI();
        }

        private void LoadPoints()
        {
            ChildPointsLabel.Text = "Points: " + CurrentUser.Points.ToString();
        }

        private void InitializeDictionaries()
        {
            StatusValues = new Dictionary<int, string>
            {
                { 1, "Active" },
                { 2, "Approval pending" },
            };
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

        #region ChoreUI
        public void ChoresUI()
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
            ActiveConcreteChores = Concrete.Load($"status=1 OR (type='conc' AND status=2) AND child_id={CurrentUser.ChildId} ORDER BY status ASC");
            ChorePanel.Controls.Clear();
            int i = 0;
            int panelDistance = 95;

            foreach (var chore in ActiveConcreteChores)
            {
                var choreName = chore.Name.ToString();
                var chorePoints = "Points: " + chore.Points.ToString();
                var choreDescription = "Description: " + chore.Description.ToString();
                var choreStatus = "Status: " + StatusValues[chore.Status];
                var choreDueDate = "Due date: " + chore.DueDate.ToString();

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
                    Size = new Size(ChorePanel.Width - 25, panelHeight),
                    AutoSize = true,
                };
                ChorePanel.Controls.Add(individualChorePanel);
                individualChorePanel.Controls.Add(choreNameLabel);
                individualChorePanel.Controls.Add(chorePointsLabel);
                individualChorePanel.Controls.Add(choreDescriptionLabel);
                individualChorePanel.Controls.Add(choreDueDateLabel);
                if (chore.Status == 1)
                {
                    individualChorePanel.Controls.Add(AddDoneChoreButton(330, individualChorePanel.Height / 2, chore));
                    individualChorePanel.Controls.Add(AddLabel("Completed?", false, 305, individualChorePanel.Height/2 + 20));
                }
                if (chore.Status == 2)
                {
                    individualChorePanel.Controls.Remove(choreDueDateLabel);
                    individualChorePanel.Controls.Add(choreStatusLabel);
                }
                i++;
            }
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
            LoadChores();
        }

        #region RewardUI
        private void RewardsUI()
        {
            UI = 2;
            this.RewardPanel.Visible = true;
            this.RewardPanel.BringToFront();
            titleText.Text = "Rewards";
            LoadRewards();
        }
        #endregion

        private void LoadRewards()
        {
            Rewards = Reward.Load("child_id=" + CurrentUser.ChildId);
            RewardPanel.Controls.Clear();
            int i = 0;
            int panelDistance = 72;

            foreach (Reward reward in Rewards)
            {
                var rewardName = reward.Name.ToString();
                var rewardPointsRequired = "Points required: " + reward.PointsReq.ToString();
                var childPoints = (double)CurrentUser.Points;
                var requiredPoints = (double)reward.PointsReq;
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
                    Location = new Point(1, i * panelDistance),
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
                i++;
            }
        }

        private Control AddClaimRewardButton(int x, int y, Reward reward)
        {
            var ClaimButton = new Button
            {
                Location = new Point(x, y - 15),
                Size = new Size(30, 30),
                Tag = reward,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.check,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            ClaimButton.Cursor = Cursors.Hand;
            ClaimButton.FlatAppearance.BorderSize = 0;
            ClaimButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            ClaimButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            ClaimButton.Click += new EventHandler(ClaimButton_Click);
            return ClaimButton;
        }

        private void ClaimButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Reward currentReward = (Reward)clickedButton.Tag;

            var confirmDelete = MessageBox.Show("Are you sure you want to claim this reward?", "Claim Reward", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                CurrentUser.Points -= currentReward.PointsReq;
                CurrentUser.Update();
                currentReward.Delete();
                LoadPoints();
                LoadRewards();
            }
        }

        #region LeaderBoardUI
        public void LeaderboardUI()
        {
            UI = 3;
            titleText.Text = "Leaderboard";
            this.LeaderboardPanel.Visible = true;
            this.LeaderboardPanel.BringToFront();
        }
        #endregion

        #region NotificationUI
        public void NotificationUI()
        {
            UI = 4;
            titleText.Text = "Notifications";
            this.NotificationPanel.Visible = true;
            this.NotificationPanel.BringToFront();
            LoadNotification();
        }
        private void LoadNotification()
        {
            Notifications = Notification.Load("user_id=" + CurrentUser.Id);
            NotificationPanel.Controls.Clear();
            int i = 0;
            int panelDistance = 50;

            foreach (Notification notification in Notifications)
            {
                var notificationTitle = notification.Title;
                var notificationDescription = notification.Description;

                var notificationTitleLabel = AddLabel(notificationTitle, true, 5, 5);
                var notificationDescriptionLabel = AddLabel(notificationDescription, false, 10, notificationTitleLabel.Location.Y + 20);
                var panelHeight = notificationTitleLabel.Height + notificationDescriptionLabel.Height;
                var individualNotificationPanel = new Panel
                {
                    Location = new Point(1, i * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(ChorePanel.Width - 25, panelHeight),
                    AutoSize = true,
                };
                individualNotificationPanel.Controls.Add(notificationTitleLabel);
                individualNotificationPanel.Controls.Add(notificationDescriptionLabel);
                individualNotificationPanel.Controls.Add(AddNotificationDeleteButton(365, individualNotificationPanel.Height / 2, notification));
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
            Notifications = Notification.Load("user_id=" + CurrentUser.Id);
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
        #endregion

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
        #endregion
    }
}
