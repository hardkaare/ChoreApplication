using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChoreApplication.UI
{
    /// <summary>
    /// Displays the ChildMenu. 
    /// Designer adds upper panel with a title and a log out button.
    /// Designer adds the navigation panel which is a menu bar.
    /// Designer adds one panel for each button in the menu. All are hidden except the panel corresponding to the last menu option clicked.
    /// The region for private helpers contains a method for initializing dictionaries and status values.
    /// Forthermore the class contains a region handling the upper panel, the navigation panel and each of the 4 menu options.
    /// </summary>
    public partial class ChildMenu : Form
    {
        #region Properties

        //Which Childuser is logged in
        private Model.ChildUser _session { get; set; }

        //Dictionary for int status value and string status name
        private Dictionary<int, string> _statusValues { get; set; }

        //Dictionary for child ID's and names
        private Dictionary<int, string> _childrenNames { get; set; }

        //List of all ChildUsers in DB. Used to display leaderboard
        private List<Model.ChildUser> _childUsers { get; set; }

        //List of all active Concrete Chores assigned to _session
        private List<Model.Concrete> _activeConcreteChores { get; set; }

        //List of all Repeatable Chores assigned to _session
        private List<Model.Repeatable> _activeRepeatableChores { get; set; }

        //List of all Rewards assigned to _session
        private List<Model.Reward> _rewards { get; set; }

        //List of all  Notifications assigned to _session
        private List<Model.Notification> _notifications { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Creates and displays elements in the designer.
        /// Initializes helpers and sets UI to ChoresUI by default.
        /// </summary>
        public ChildMenu(Model.ChildUser child)
        {
            //Creates session
            _session = child;

            //Creates and displays elements in designer
            InitializeComponent();

            //Initializes _statusValues and _childrenNames dictionary
            InitializeDictionaries();

            //Loads and displays amount of points the ChildUser has
            LoadPoints();

            //Displays amount of notifications for _session
            LoadAmountOfNotifications();

            //Loads ChoresUI
            ChoresUI();
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Reloades _session and updates childPointsLabel
        /// </summary>
        private void LoadPoints()
        {
            var _sessionList = Model.ChildUser.Load($"c.child_id={_session.ChildID}");
            _session = _sessionList[0];
            childPointsLabel.Text = "Points: " + _session.Points.ToString();
        }

        /// <summary>
        /// Initializes _statusValues and _childrenNames dictionaries
        /// </summary>
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

        #endregion

        #region UpperPanel

        /// <summary>
        /// Logs out.
        /// </summary>
        private void UserButton_Click(object sender, EventArgs e)
        {
            //Clears _session
            _session = default;

            //Proceeds to LoginInterface and closes this form
            var loginInterface = new GeneralInterface.LoginInterface();
            loginInterface.Show();
            this.Close();
        }

        #endregion UpperPanel

        #region NavigationMenu

        /// <summary>
        /// Switches to ChoresUI
        /// </summary>
        private void ChoreNavButton_Click(object sender, EventArgs e)
        {
            ChoresUI();
        }

        /// <summary>
        /// Switches to RewardsUI
        /// </summary>
        private void RewardNavButton_Click(object sender, EventArgs e)
        {
            RewardsUI();
        }

        /// <summary>
        /// Switches to LeaderboardUI
        /// </summary>
        private void LeadboardNavButton_Click(object sender, EventArgs e)
        {
            LeaderboardUI();
        }

        /// <summary>
        /// Switches to NotificationUI
        /// </summary>
        private void NotificationsNavButton_Click(object sender, EventArgs e)
        {
            NotificationUI();
        }

        #endregion NavigationMenu

        #region ChoreUI

        /// <summary>
        /// Loads the ChoresUI and changes title
        /// </summary>
        public void ChoresUI()
        {
            //Displays chorePanel
            this.chorePanel.Visible = true;
            this.chorePanel.BringToFront();

            //Change title
            titleText.Text = "Chores";

            //Loads Chores and displays them in chorePanel
            DisplayChores();
        }

        #region Load Methods

        /// <summary>
        /// Loads all Chores and displays them in chorePanel
        /// </summary
        public void DisplayChores()
        {
            //Reload points
            LoadPoints();

            //Loads all active Concrete and Repeatable Chores assigned to _session
            _activeConcreteChores = Model.Concrete.Load($"(status=1 OR status=2) AND ch.child_id={_session.ChildID} ORDER BY status ASC");
            _activeRepeatableChores = Model.Repeatable.Load($"ch.child_id={_session.ChildID}");

            //Clears chorePanel
            chorePanel.Controls.Clear();

            //Sets starting location for the first Chore. Updated with each display
            int choreLocationY = 0;
            int panelDistance = 5;

            //Display all active Concrete Chores
            foreach (var chore in _activeConcreteChores)
            {
                //Adds a panel with current Chore
                Panel currentPanel = LoadConcreteChore(chore, chorePanel.Width - 20, choreLocationY);
                chorePanel.Controls.Add(currentPanel);

                //Updates location for next Chore
                choreLocationY += currentPanel.Height + panelDistance;
            }

            //Displays all Repeatable Chores
            foreach (var chore in _activeRepeatableChores)
            {
                //Adds a panel with current Chore
                Panel currentPanel = LoadRepeatableChore(chore, chorePanel.Width - 20, choreLocationY);
                chorePanel.Controls.Add(currentPanel);

                //Updates location for next Chore
                choreLocationY += currentPanel.Height + panelDistance;
            }
        }

        /// <summary>
        /// Creates an individual panel for a single Repeatable Chore. 
        /// Points are diminished by 25% for each completion.
        /// Adds buttons for completing it Chore.
        /// Button is disabled if limit is reached. 
        /// </summary>
        private Panel LoadRepeatableChore(Model.Repeatable chore, int width, int yLocation)
        {
            //Calculates diminishing returns on points
            double calcDimishingReturn = chore.Points;
            for (int j = 0; j < chore.Completions; j++)
            {
                calcDimishingReturn *= 0.75;
            }
            int diminishedPoints = (int)calcDimishingReturn;

            //Sets label text
            var chorePoints = "Points: " + diminishedPoints.ToString();
            var choreLimit = "Completion limit: " + chore.Limit.ToString();
            var choreCompletions = "Amount completed today: " + chore.Completions.ToString();

            //Creates the panel
            var individualChorePanel = LoadChore(chore, new Point(1, yLocation), diminishedPoints, choreLimit, choreCompletions);

            //Add complete button
            var repChoreDoneButton = AddRepeatableChoreDoneButton(330, individualChorePanel.Height / 2, chore);

            //If limit is reached disables button
            if (chore.Completions >= chore.Limit)
            {
                var limitReachedLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel("Limit reached", false, new Point(290, individualChorePanel.Height / 2));
                limitReachedLabel.Enabled = false;
                individualChorePanel.Controls.Add(limitReachedLabel);
            }
            else
            {
                individualChorePanel.Controls.Add(repChoreDoneButton);
                individualChorePanel.Controls.Add(TechnicalPlatform.UILibrary.StandardElements.AddLabel("Completed?", false, new Point(305, individualChorePanel.Height / 2 + 20)));
            }

            return individualChorePanel;
        }

        /// <summary>
        /// Creates an individual panel for a single Concrete Chore. 
        /// </summary>
        private Panel LoadConcreteChore(Model.Concrete chore, int width, int yLocation)
        {
            //Sets label texts
            var choreStatus = "Status: " + _statusValues[chore.Status];
            var choreDueDate = "Due date: " + chore.DueDate.ToString(Properties.Settings.Default.ShortDateFormat);

            //Creates the panel
            var individualChorePanel = LoadChore(chore, new Point(1, yLocation), chore.Points, choreStatus, choreDueDate);
            chorePanel.Controls.Add(individualChorePanel);

            //If the Chore is active ads complete button
            if (chore.Status == 1)
            {
                individualChorePanel.Controls.Add(AddConcreteChoreDoneButton(330, individualChorePanel.Height / 2, chore));
                individualChorePanel.Controls.Add(TechnicalPlatform.UILibrary.StandardElements.AddLabel("Completed?", false, new Point(305, individualChorePanel.Height / 2 + 20)));
            }

            return individualChorePanel;
        }

        /// <summary>
        /// Creates a panel for a single Chore
        /// </summary>
        /// <param name="chore">Chore being displayed</param>
        /// <param name="location">Relative location of panel</param>
        /// <param name="points">Points earned by completing the Chore</param>
        /// <param name="label1">Type specific label</param>
        /// <param name="label2">Type specific label</param>
        /// <returns>Panel with Chore info</returns>
        private Panel LoadChore(Model.Chore chore, Point location, int points, string label1, string label2)
        {
            //Sets starting location for labels. Updated with each label displayed
            int yLoc = 5;
            int labelDist = 0;

            //Sets label texts
            var choreName = chore.Name;
            var choreDescription = "Description: " + chore.Description;
            var chorePoints = "Points: " + points.ToString();

            //Creates labels and updates location
            var choreNameLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(choreName, true, new Point(5, yLoc));
            yLoc += choreNameLabel.Height + labelDist;
            var choreDescriptionLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(choreDescription, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + labelDist;
            var chorePointsLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(chorePoints, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + labelDist;
            var choreLimitLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(label1, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + labelDist;
            var choreCompletionsLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(label2, false, new Point(10, yLoc));
            var panelHeight = choreNameLabel.Height + chorePointsLabel.Height + choreDescriptionLabel.Height + choreLimitLabel.Height + choreCompletionsLabel.Height;

            //Creates standard panel from library
            var individualChorePanel = TechnicalPlatform.UILibrary.StandardElements.AddPanel(location, chorePanel.Width - 25, panelHeight);

            //Adds labels to panel
            individualChorePanel.Controls.Add(choreNameLabel);
            individualChorePanel.Controls.Add(chorePointsLabel);
            individualChorePanel.Controls.Add(choreDescriptionLabel);
            individualChorePanel.Controls.Add(choreLimitLabel);
            individualChorePanel.Controls.Add(choreCompletionsLabel);

            return individualChorePanel;
        }

        #endregion

        #region Create Buttons Methods

        /// <summary>
        /// Creates a complete button to a Repeatable Chore
        /// </summary>
        private Button AddRepeatableChoreDoneButton(int locationX, int locationY, Model.Repeatable chore)
        {
            //Creates a standard image button from library
            var reatableChoreDoneButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), chore, global::ChoreApplication.Properties.Resources.thumbs_up);

            //Disables the button if limit is reached
            if (chore.Completions >= chore.Limit)
            {
                reatableChoreDoneButton.Enabled = false;
            }

            //Adds event handler
            reatableChoreDoneButton.Click += new EventHandler(RepeatableChoreDoneButton_Click);
            return reatableChoreDoneButton;
        }

        /// <summary>
        /// Creates a complete button to a Concrete Chore
        /// </summary>
        private Control AddConcreteChoreDoneButton(int locationX, int locationY, Model.Concrete chore)
        {
            //Creates a standard image button from library
            var concreteChoreDoneButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), chore, global::ChoreApplication.Properties.Resources.thumbs_up);

            //Adds event handler
            concreteChoreDoneButton.Click += new EventHandler(ConcreteChoreDoneButton_Click);
            return concreteChoreDoneButton;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Creates a Concrete Chore from the Repeatable Chore in approval pending state
        /// </summary>
        private void RepeatableChoreDoneButton_Click(object sender, EventArgs e)
        {
            //Set currentChore to the Repeatable Chore in clicked button's tag
            Button clickedButton = (Button)sender;
            Model.Repeatable currentChore = (Model.Repeatable)clickedButton.Tag;

            //Calculate diminishing returns
            double calculateDiminishingReturn = currentChore.Points;
            for (int i = 0; i < currentChore.Completions; i++)
            {
                calculateDiminishingReturn *= 0.75;
            }
            int diminishedPoints = (int)calculateDiminishingReturn;

            //Create a Concrete Chore
            Model.Concrete.Insert(currentChore.Name, currentChore.Description, diminishedPoints, currentChore.Assignment, new DateTime(2000, 1, 1, 0, 0, 0), "rep");

            //Increment completions and update
            currentChore.Completions++;
            currentChore.Update();

            //Create a notification to ParentUser
            Model.Notification.Insert(1, $"{_childrenNames[currentChore.Assignment]} completed a chore.", $"{_childrenNames[currentChore.Assignment]} completed the chore {currentChore.Name}.");

            //Reload ChoreUI
            LoadAmountOfNotifications();
            DisplayChores();
        }

        /// <summary>
        /// Completes a Concrete Chore
        /// </summary>
        private void ConcreteChoreDoneButton_Click(object sender, EventArgs e)
        {
            //Set currentChore to the Concrete Chore in clicked button's tag
            Button clickedButton = (Button)sender;
            Model.Concrete currentChore = (Model.Concrete)clickedButton.Tag;

            //Set status to approval pending and update DB
            currentChore.Status = 2;
            currentChore.Update();

            //Create a notification to ParentUser
            Model.Notification.Insert(1, $"{_childrenNames[currentChore.Assignment]} completed a chore.", $"{_childrenNames[currentChore.Assignment]} completed the chore {currentChore.Name}.");

            //Reload ChoreUI
            LoadAmountOfNotifications();
            DisplayChores();
        }

        #endregion

        #endregion ChoreUI

        #region RewardUI

        /// <summary>
        /// Loads the RewardsUI and changes title
        /// </summary>
        private void RewardsUI()
        {
            //Displays rewardPanel
            this.RewardPanel.Visible = true;
            this.RewardPanel.BringToFront();

            //Change title
            titleText.Text = "Rewards";

            //Loads Rewards and displays them in rewardPanel
            DisplayRewards();
        }

        #region Load Methods

        private void DisplayRewards()
        {
            //Reload points
            LoadPoints();

            //Loads all Rewards assigned to _session
            _rewards = Model.Reward.Load("child_id=" + _session.ChildID);

            //Clears RewardPanel
            RewardPanel.Controls.Clear();

            //Sets starting location for the first Chore. Updated with each display
            int yLoc = 0;
            int panelDist = 5;

            //Display all Rewards
            foreach (Model.Reward reward in _rewards)
            {
                //Adds a panel with current Reward
                Panel currentPanel = LoadReward(reward, yLoc);
                RewardPanel.Controls.Add(currentPanel);

                //Update location for next Reward
                yLoc += currentPanel.Height + panelDist;
            }
        }

        /// <summary>
        /// Creates a panel for a single Reward
        /// </summary>
        private Panel LoadReward(Model.Reward reward, int yLocation)
        {
            //Set label texts
            var rewardName = reward.Name;
            var rewardPointsRequired = "Points required: " + reward.PointsRequired.ToString();
            var childPoints = (double)_session.Points;
            var requiredPoints = (double)reward.PointsRequired;

            //Set progress bar value in percentage
            var progressBarValue = (childPoints / requiredPoints) * 100;

            //Create labels from library
            var rewardNameLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(rewardName, true, new Point(5, 5));
            var rewardPointsRequiredLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(rewardPointsRequired, false, new Point(10, rewardNameLabel.Location.Y + 20));

            //Create progressbar
            var rewardProgressBar = new ProgressBar
            {
                Location = new Point(10, rewardPointsRequiredLabel.Location.Y + 20),
                Size = new Size(250, 25),
                Tag = reward,
            };

            //If calculated progress bar value is more than 100 it's set to 100
            if (progressBarValue > 100)
            {
                rewardProgressBar.Value = 100;
            }

            //Otherwise progress bar is set to the value
            else
            {
                rewardProgressBar.Value = (int)progressBarValue;
            }

            //Creates a standard panel from library
            var panelHeight = rewardNameLabel.Height + rewardPointsRequiredLabel.Height + rewardProgressBar.Height;
            var individualRewardPanel = TechnicalPlatform.UILibrary.StandardElements.AddPanel(new Point(1, yLocation), RewardPanel.Width - 25, panelHeight);

            //Adds labels
            individualRewardPanel.Controls.Add(rewardNameLabel);
            individualRewardPanel.Controls.Add(rewardPointsRequiredLabel);
            individualRewardPanel.Controls.Add(rewardProgressBar);

            //If _session has enough points adds a claim button
            if (rewardProgressBar.Value == 100)
            {
                individualRewardPanel.Controls.Add(AddClaimRewardButton(335, individualRewardPanel.Height / 2, reward));
                individualRewardPanel.Controls.Add(TechnicalPlatform.UILibrary.StandardElements.AddLabel("Claim reward", false, new Point(305, individualRewardPanel.Height / 2 + 20)));
            }

            return individualRewardPanel;
        }

        #endregion

        #region Create Button Methods

        /// <summary>
        /// Creates a claim reward button
        /// </summary>
        private Control AddClaimRewardButton(int locationX, int locationY, Model.Reward reward)
        {
            //Creates a standard image button from library
            var claimButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), reward, global::ChoreApplication.Properties.Resources.check);

            //Adds event handler
            claimButton.Click += new EventHandler(ClaimRewardButton_Click);
            return claimButton;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Claims a reward
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClaimRewardButton_Click(object sender, EventArgs e)
        {
            //Sets currentReward to the Reward in clicked button's tag
            Button clickedButton = (Button)sender;
            Model.Reward currentReward = (Model.Reward)clickedButton.Tag;

            //Asks user for confirmation
            var confirmDelete = MessageBox.Show("Are you sure you want to claim this reward?", "Claim Reward", MessageBoxButtons.YesNo);

            if (confirmDelete == DialogResult.Yes)
            {
                //Subtracts points from _session and updates DB
                _session.Points -= currentReward.PointsRequired;
                _session.Update();

                //Deletes Reward from DB
                currentReward.Delete();

                //Reloads RewardUI
                LoadPoints();
                DisplayRewards();

                //Creates notification to ParentUser that Reward has been claimed
                Model.Notification.Insert(1, "Reward has been claimed.", $"The reward {currentReward.Name}: {currentReward.Description} " +
                    $"has been claimed by {_childrenNames[currentReward.ChildID]}");

                //Updates amount of notifications on icon in NavigationPanel
                LoadAmountOfNotifications();
            }
        }

        #endregion

        #endregion RewardUI

        #region LeaderBoardUI

        /// <summary>
        /// Loads the LeaderboardUI and changes title
        /// </summary>
        public void LeaderboardUI()
        {
            //Displays leaderboardPanel
            titleText.Text = "Leaderboard";
            this.leaderboardPanel.Visible = true;
            this.leaderboardPanel.BringToFront();

            //Calculates and displays statistics
            DisplayLeaderboard();
        }

        /// <summary>
        /// Calculates and displays statistics. The 4 statistics that are displayed are:
        /// Total points earned.
        /// Total amount of Chores approved.
        /// Completion rate. (How many approved Chores compared to overdue Chores in percentage)
        /// Longest streak. (How many times in a row Chores have been completed in time without any going overdue)
        /// </summary>
        private void DisplayLeaderboard()
        {
            //Cleares leaderboardPanel
            leaderboardPanel.Controls.Clear();

            //Sets starting location for the first statistic. Updates after a statistic has been displayed
            int panelDistance = 20;
            int leaderboardLocationY = 10;

            //Add Total Points title
            var totalPointsEarnedLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel("Total Points Earned", true, new Point(140, leaderboardLocationY));
            this.leaderboardPanel.Controls.Add(totalPointsEarnedLabel);
            leaderboardLocationY += totalPointsEarnedLabel.Height + panelDistance;

            //Add Total Points panel
            var totalPointsStatisticPanel = Functions.UIFunctions.LoadTotalPoints(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
            this.leaderboardPanel.Controls.Add(totalPointsStatisticPanel);
            leaderboardLocationY += totalPointsStatisticPanel.Height + panelDistance;

            //Add Total Chores Approved title
            var totalChoresApprovedLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel("Total Chores Approved", true, new Point(140, leaderboardLocationY));
            this.leaderboardPanel.Controls.Add(totalChoresApprovedLabel);
            leaderboardLocationY += totalChoresApprovedLabel.Height + panelDistance;

            //Add Total Chores Approved panel
            var totalChoresApprovedStatisticPanel = Functions.UIFunctions.LoadTotalChoresApproved(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
            this.leaderboardPanel.Controls.Add(totalChoresApprovedStatisticPanel);
            leaderboardLocationY += totalChoresApprovedStatisticPanel.Height + panelDistance;

            //Add Completion Rate title
            var completionRateLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel("Completion Rate", true, new Point(140, leaderboardLocationY));
            this.leaderboardPanel.Controls.Add(completionRateLabel);
            leaderboardLocationY += completionRateLabel.Height + panelDistance;

            //Add Completion Rate panel
            var completionRateStatisticPanel = Functions.UIFunctions.LoadCompletionRate(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
            this.leaderboardPanel.Controls.Add(completionRateStatisticPanel);
            leaderboardLocationY += completionRateStatisticPanel.Height + panelDistance;

            //Add Longest streak title
            var longestStreakLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel("Longest Streak", true, new Point(140, leaderboardLocationY));
            this.leaderboardPanel.Controls.Add(longestStreakLabel);
            leaderboardLocationY += longestStreakLabel.Height + panelDistance;

            //Add Longest Streak panel
            var longestStreakStatisticPanel = Functions.UIFunctions.LoadLongestStreak(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
            this.leaderboardPanel.Controls.Add(longestStreakStatisticPanel);
        }

        #endregion LeaderBoardUI

        #region NotificationUI

        /// <summary>
        /// Loads NotificationsUI and changes title.
        /// </summary>
        public void NotificationUI()
        {
            //Displays notificationPanel
            titleText.Text = "Notifications";
            this.notificationPanel.Visible = true;
            this.notificationPanel.BringToFront();

            //Loads each notification in an individual panel
            DisplayNotifications();
        }

        #region Load Methods

        /// <summary>
        /// Load all _session's notification, each in their own panel.
        /// Display the panels in notificationPanel
        /// </summary>
        private void DisplayNotifications()
        {
            //Loads all notifications assigned to _session
            _notifications = Model.Notification.Load("user_id=" + _session.ID);

            //Clears notificationPanel
            notificationPanel.Controls.Clear();

            //Sets start location for first notification. Updates after each display
            int panelDistance = 5;
            int notificationLocationY = 0;

            //Displays each notification in loaded list
            foreach (Model.Notification notification in _notifications)
            {
                //Create a panel with info for the notification
                var individualNotificationPanel = Functions.UIFunctions.LoadNotification(notification, chorePanel.Width - 20, notificationLocationY);

                //Add delete button
                individualNotificationPanel.Controls.Add(AddDeleteNotificationButton(365, individualNotificationPanel.Height / 2, notification));

                //Add notification to notificationPanel and update location
                notificationPanel.Controls.Add(individualNotificationPanel);
                notificationLocationY += individualNotificationPanel.Height + panelDistance;
            }
        }

        #endregion

        #region Create Buttons Methods

        /// <summary>
        /// Creates a button to delete selected notification in DB
        /// </summary>
        private Control AddDeleteNotificationButton(int locationX, int locationY, Model.Notification notification)
        {
            //Create standard button from library
            var deleteNotificationButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), notification, global::ChoreApplication.Properties.Resources.delete);

            //Add event handler
            deleteNotificationButton.Click += new EventHandler(NotificationDeleteButton_Click);
            return deleteNotificationButton;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Deletes selected notification in DB
        /// </summary>
        private void NotificationDeleteButton_Click(object sender, System.EventArgs e)
        {
            //Sets currentNotification to Notification in clicked button's tag
            Button clickedButton = (Button)sender;
            Model.Notification currentNotification = (Model.Notification)clickedButton.Tag;

            //Deletes notification in DB
            currentNotification.Delete();

            //Reloads NotificationUI
            NotificationUI();
        }

        #endregion

        /// <summary>
        /// Displays amount of notifications on icon in NavigationPanel
        /// </summary>
        private void LoadAmountOfNotifications()
        {
            //Loads all notifications assigned to _session
            _notifications = Model.Notification.Load("user_id=" + _session.ID);

            //Clears text in label
            notificationAmount.Text = "";

            //If there are no Notifications displays nothing
            if (_notifications.Count == 0)
            {
                notificationAmount.Visible = false;
            }

            //Displays amount if one or more Notifications
            else
            {
                notificationAmount.Text = _notifications.Count.ToString();
            }
        }

        #endregion NotificationUI
    }
}