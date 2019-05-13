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

        private Control AddLabel(string labelText, bool isBold, int locationX, int locationY)
        {
            var label = new Label
            {
                Text = labelText,
                MaximumSize = new Size(310, 20),
                AutoEllipsis = true,
                AutoSize = true,
            };
            label.Location = new Point(locationX, locationY);
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
            _concreteChoresApprovalPending = Model.Concrete.Load("status=2 OR (type='conc' AND status=1) ORDER BY status DESC");
            _reoccurringChores = Model.Reocurring.Load("");
            _repeatableChores = Model.Repeatable.Load("");
            chorePanel.Controls.Clear();
            int distanceCounter = 0;
            int panelDistance = 95;

            foreach (var chore in _concreteChoresApprovalPending)
            {
                var choreName = chore.Name.ToString();
                var choreAssignment = "Assigned to: " + _childrenNames[chore.Assignment];
                var choreStatus = "Status: " + _statusValues[chore.Status];
                var choreType = "Type: Concrete";

                var choreNameLabel = AddLabel(choreName, true, 5, 5);
                var choreAssignmentLabel = AddLabel(choreAssignment, false, 10, choreNameLabel.Location.Y + 20);
                var choreStatusLabel = AddLabel(choreStatus, false, 10, choreAssignmentLabel.Location.Y + 20);
                var choreTypeLabel = AddLabel(choreType, false, 10, choreStatusLabel.Location.Y + 20);
                var panelHeight = choreNameLabel.Height + choreAssignmentLabel.Height + choreStatusLabel.Height + choreTypeLabel.Height;
                var individualChorePanel = new Panel
                {
                    Name = "panel" + chore.ID.ToString(),
                    Location = new Point(1, distanceCounter * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(chorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };

                chorePanel.Controls.Add(individualChorePanel);
                individualChorePanel.Controls.Add(choreNameLabel);
                individualChorePanel.Controls.Add(choreAssignmentLabel);
                individualChorePanel.Controls.Add(choreStatusLabel);
                individualChorePanel.Controls.Add(choreTypeLabel);
                if (chore.Status == 2)
                {
                    individualChorePanel.Controls.Add(AddApproveChoreButton(330, individualChorePanel.Height / 2, chore));
                    individualChorePanel.Controls.Add(AddDenyChoreButton(365, individualChorePanel.Height / 2, chore));
                }
                else
                {
                    individualChorePanel.Controls.Add(AddEditChoreButton(330, individualChorePanel.Height / 2, chore));
                    individualChorePanel.Controls.Add(AddDeleteChoreButton(365, individualChorePanel.Height / 2, chore));
                }
                distanceCounter++;
            }
            foreach (var chore in _reoccurringChores)
            {
                var choreName = chore.Name.ToString();
                var choreAssignment = "Assigned to: " + _childrenNames[chore.Assignment];
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
                    Location = new Point(1, distanceCounter * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(chorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                chorePanel.Controls.Add(individualChorePanel);
                individualChorePanel.Controls.Add(choreNameLabel);
                individualChorePanel.Controls.Add(choreAssignmentLabel);
                individualChorePanel.Controls.Add(choreStatusLabel);
                individualChorePanel.Controls.Add(choreTypeLabel);
                individualChorePanel.Controls.Add(AddEditChoreButton(330, individualChorePanel.Height / 2, chore));
                individualChorePanel.Controls.Add(AddDeleteChoreButton(365, individualChorePanel.Height / 2, chore));
                distanceCounter++;
            }
            foreach (var chore in _repeatableChores)
            {
                var choreName = chore.Name.ToString();
                var choreAssignment = "Assigned to: " + _childrenNames[chore.Assignment];
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
                    Location = new Point(1, distanceCounter * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(chorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                chorePanel.Controls.Add(individualChorePanel);
                individualChorePanel.Controls.Add(choreNameLabel);
                individualChorePanel.Controls.Add(choreAssignmentLabel);
                individualChorePanel.Controls.Add(choreStatusLabel);
                individualChorePanel.Controls.Add(choreTypeLabel);
                individualChorePanel.Controls.Add(AddEditChoreButton(330, individualChorePanel.Height / 2, chore));
                individualChorePanel.Controls.Add(AddDeleteChoreButton(365, individualChorePanel.Height / 2, chore));
                distanceCounter++;
            }
        }

        private Control AddApproveChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            var approveButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = chore,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.thumbs_up,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            approveButton.Cursor = Cursors.Hand;
            approveButton.FlatAppearance.BorderSize = 0;
            approveButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            approveButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            approveButton.Click += new EventHandler(ApproveChoreButton_Click);
            return approveButton;
        }

        private Control AddDenyChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            var denyButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = chore,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.thumb_down,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            denyButton.Cursor = Cursors.Hand;
            denyButton.FlatAppearance.BorderSize = 0;
            denyButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            denyButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
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
                var editSelectedChoreUI = new EditChoreUI(selectedChore);
                editSelectedChoreUI.Show();
                editSelectedChoreUI.FormClosing += ChoreNavigationButton_Click;
            }
            catch
            {
                try
                {
                    Model.Reocurring selectedChore = (Model.Reocurring)clickedButton.Tag;
                    var editSelectedChoreUI = new EditChoreUI(selectedChore);
                    editSelectedChoreUI.Show();
                    editSelectedChoreUI.FormClosing += ChoreNavigationButton_Click;
                }
                catch
                {
                    try
                    {
                        Model.Repeatable selectedChore = (Model.Repeatable)clickedButton.Tag;
                        var editSelectedChoreUI = new EditChoreUI(selectedChore);
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
            int distanceCounter = 0;
            int panelDistance = 72;

            foreach (Model.Reward reward in _rewards)
            {
                var rewardName = reward.Name.ToString();
                var rewardAssignment = "Assigned to: " + _childrenNames[reward.ChildID];
                var rewardStatus = "Status: Active";

                var rewardNameLabel = AddLabel(rewardName, true, 5, 5);
                var rewardAssignmentLabel = AddLabel(rewardAssignment, false, 10, rewardNameLabel.Location.Y + 20);
                var rewardStatusLabel = AddLabel(rewardStatus, false, 10, rewardAssignmentLabel.Location.Y + 20);
                var panelHeight = rewardNameLabel.Height + rewardAssignmentLabel.Height + rewardStatusLabel.Height;
                var individualRewardPanel = new Panel
                {
                    Location = new Point(1, distanceCounter * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(chorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                individualRewardPanel.Controls.Add(rewardNameLabel);
                individualRewardPanel.Controls.Add(rewardAssignmentLabel);
                individualRewardPanel.Controls.Add(rewardStatusLabel);
                individualRewardPanel.Controls.Add(AddEditRewardButton(330, individualRewardPanel.Height / 2, reward));
                individualRewardPanel.Controls.Add(AddDeleteRewardButton(365, individualRewardPanel.Height / 2, reward));
                rewardPanel.Controls.Add(individualRewardPanel);
                distanceCounter++;
            }
        }

        private Control AddEditRewardButton(int locationX, int locationY, Model.Reward reward)
        {
            var editRewardButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = reward,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.pencil,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            editRewardButton.Cursor = Cursors.Hand;
            editRewardButton.FlatAppearance.BorderSize = 0;
            editRewardButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            editRewardButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            editRewardButton.Click += new EventHandler(EditRewardButton_Click);
            return editRewardButton;
        }

        private Control AddDeleteRewardButton(int locationX, int locationY, Model.Reward reward)
        {
            var deleteRewardButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = reward,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.delete,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            deleteRewardButton.Cursor = Cursors.Hand;
            deleteRewardButton.FlatAppearance.BorderSize = 0;
            deleteRewardButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            deleteRewardButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
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
                var totalPointsEarnedLabel = AddLabel("Total Points Earned", true, 140, leaderboardLocationY);
                this.leaderboardPanel.Controls.Add(totalPointsEarnedLabel);
                leaderboardLocationY += totalPointsEarnedLabel.Height + panelDistance;

                //Add Total Points panel
                var totalPointsStatisticPanel = Functions.SystemFunctions.LeaderboardFunctions.LoadTotalPoints(new Point(0, leaderboardLocationY),
                    leaderboardPanel.Width, _childrenNames, _childUsers);
                this.leaderboardPanel.Controls.Add(totalPointsStatisticPanel);
                leaderboardLocationY += totalPointsStatisticPanel.Height + panelDistance;

                //Add Total Chores Approved title
                var totalChoresApprovedLabel = AddLabel("Total Chores Approved", true, 140, leaderboardLocationY);
                this.leaderboardPanel.Controls.Add(totalChoresApprovedLabel);
                leaderboardLocationY += totalChoresApprovedLabel.Height + panelDistance;

                //Add Total Chores Approved panel
                var totalChoresApprovedStatisticPanel = Functions.SystemFunctions.LeaderboardFunctions.LoadTotalChoresApproved(new Point(0, leaderboardLocationY),
                    leaderboardPanel.Width, _childrenNames, _childUsers);
                this.leaderboardPanel.Controls.Add(totalChoresApprovedStatisticPanel);
                leaderboardLocationY += totalChoresApprovedStatisticPanel.Height + panelDistance;

                //Add Completion Rate title
                var completionRateLabel = AddLabel("Completion Rate", true, 140, leaderboardLocationY);
                this.leaderboardPanel.Controls.Add(completionRateLabel);
                leaderboardLocationY += completionRateLabel.Height + panelDistance;

                //Add Completion Rate panel
                var completionRateStatisticPanel = Functions.SystemFunctions.LeaderboardFunctions.LoadCompletionRate(new Point(0, leaderboardLocationY),
                    leaderboardPanel.Width, _childrenNames, _childUsers);
                this.leaderboardPanel.Controls.Add(completionRateStatisticPanel);
                leaderboardLocationY += completionRateStatisticPanel.Height + panelDistance;

                //Add Longest streak title
                var longestStreakLabel = AddLabel("Longest Streak", true, 140, leaderboardLocationY);
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
            int distanceCounter = 0;
            int panelDistance = 65;

            foreach (Model.ParentUser parent in _parentUsers)
            {
                var userFirstName = parent.FirstName.ToString();

                var userFirstNameLabel = AddLabel(userFirstName, true, 5, 5);
                var panelHeight = userFirstNameLabel.Height + 40;
                var individualUserPanel = new Panel
                {
                    Location = new Point(1, distanceCounter * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(chorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                individualUserPanel.Controls.Add(userFirstNameLabel);
                userPanel.Controls.Add(individualUserPanel);
                individualUserPanel.Controls.Add(AddEditParentButton(365, individualUserPanel.Height / 2, parent));
                distanceCounter++;
            }

            foreach (Model.ChildUser child in _childUsers)
            {
                var userFirstName = child.FirstName.ToString();

                var userFirstNameLabel = AddLabel(userFirstName, false, 5, 5);
                var panelHeight = userFirstNameLabel.Height + 40;
                var individualUserPanel = new Panel
                {
                    Location = new Point(1, distanceCounter * panelDistance),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(chorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                individualUserPanel.Controls.Add(userFirstNameLabel);
                userPanel.Controls.Add(individualUserPanel);
                individualUserPanel.Controls.Add(AddEditChildButton(330, individualUserPanel.Height / 2, child));
                individualUserPanel.Controls.Add(AddDeleteChildButton(365, individualUserPanel.Height / 2, child));
                distanceCounter++;
            }
        }

        private Control AddEditChildButton(int locationX, int locationY, Model.ChildUser childUser)
        {
            var editChildButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = childUser,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.pencil,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            editChildButton.Cursor = Cursors.Hand;
            editChildButton.FlatAppearance.BorderSize = 0;
            editChildButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            editChildButton.Click += new EventHandler(EditChildButton_Click);
            return editChildButton;
        }

        private Control AddEditParentButton(int locationX, int locationY, Model.ParentUser parentUser)
        {
            var editParentButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = parentUser,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.pencil,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            editParentButton.Cursor = Cursors.Hand;
            editParentButton.FlatAppearance.BorderSize = 0;
            editParentButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            editParentButton.Click += new EventHandler(EditParentButton_Click);
            return editParentButton;
        }

        private Control AddDeleteChildButton(int locationX, int locationY, Model.ChildUser childUser)
        {
            var deleteChildButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = childUser,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.delete,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            deleteChildButton.Cursor = Cursors.Hand;
            deleteChildButton.FlatAppearance.BorderSize = 0;
            deleteChildButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
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
            LoadNotification();
            LoadAmountOfNotifications();
        }

        private void LoadNotification()
        {
            _notifications = Model.Notification.Load("user_id=" + _session.ID);
            notificationPanel.Controls.Clear();
            int distanceCounter = 0;
            int panelDistance = 50;

            foreach (Model.Notification notification in _notifications)
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
                    Size = new Size(chorePanel.Width - 20, panelHeight),
                    AutoSize = true,
                };
                individualNotificationPanel.Controls.Add(notificationTitleLabel);
                individualNotificationPanel.Controls.Add(notificationDescriptionLabel);
                individualNotificationPanel.Controls.Add(AddDeleteNotificationButton(365, individualNotificationPanel.Height / 2, notification));
                notificationPanel.Controls.Add(individualNotificationPanel);
                distanceCounter++;
            }
        }

        private Control AddDeleteNotificationButton(int locationX, int locationY, Model.Notification notification)
        {
            var deleteNotificationButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = notification,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.delete,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            deleteNotificationButton.Cursor = Cursors.Hand;
            deleteNotificationButton.FlatAppearance.BorderSize = 0;
            deleteNotificationButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
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