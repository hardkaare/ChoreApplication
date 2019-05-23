using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    /// <summary>
    /// Displays the ParentMenu. 
    /// Designer adds upper panel with a log out button and option button (used for creating new Chores, ChildUsers or Rewards depending on selected UI).
    /// Designer adds the navigation panel which is a menu bar.
    /// Designer adds one panel for each button in the menu. All are hidden except the panel corresponding to the last menu option clicked.
    /// The region for private helpers contains a method for initializing dictionaries and status values.
    /// The region for general controls contains the even handling of the option button.
    /// Forthermore the class contains a region handling the upper panel, the navigation panel and each of the 5 menu options.
    /// </summary>
    public partial class ParentMenu : Form
    {
        #region Properties

        /// <summary>
        /// Which UI is currently selected: 
        /// 1 = ChoreUI, 
        /// 2 = RewardUI, 
        /// 3 = LeaderboardUI, 
        /// 4 = UsersUI, 
        /// 5 = NotificationUI
        /// </summary>
        public int UI { get; set; }

        //The logged in User
        private Model.ParentUser _session { get; set; }

        //Dictionary for int status value and string status name
        private Dictionary<int, string> _statusValues { get; set; }

        //Dictionary for child ID's and names
        private Dictionary<int, string> _childrenNames { get; set; }

        //List of Reoccurring Chores. Used for displaying Chores
        private List<Model.Reoccurring> _reoccurringChores { get; set; }

        //List of Repeatable Chores. Used for displaying Chores
        private List<Model.Repeatable> _repeatableChores { get; set; }

        //List of Concrete Chores. Used for displaying Chores
        private List<Model.Concrete> _concreteChoresApprovalPending { get; set; }

        //List of Concrete Reward. Used for displaying Rewards
        private List<Model.Reward> _rewards { get; set; }

        //List of Concrete ParentUser. Used for displaying Users
        private List<Model.ParentUser> _parentUsers { get; set; }

        //List of Concrete ChildUser. Used for displaying Users
        private List<Model.ChildUser> _childUsers { get; set; }

        //List of Concrete Notification. Used for displaying Notifications
        private List<Model.Notification> _notifications { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Creates and displays elements in the designer.
        /// Initializes helpers and sets UI to ChoresUI by default.
        /// </summary>
        public ParentMenu(Model.ParentUser currentUser)
        {
            //Creates session
            _session = currentUser;

            //Creates and displays elements in designer
            InitializeComponent();

            //Initializes _statusValues dictionary
            InitializeStatusValues();

            //Initializes _childrenNames dictionary
            LoadChildrenNames();

            //Displays amount of notifications for _session
            LoadAmountOfNotifications();

            //Loads ChoresUI
            ChoresUI();
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Initializes _statusValues dictionary. Sets value in DB and readable name to display for Users
        /// </summary>
        private void InitializeStatusValues()
        {
            _statusValues = new Dictionary<int, string>
            {
                { 1, "Active" },
                { 2, "Approval pending" },
            };
        }

        /// <summary>
        /// Initializes _childrenNames dictionary. Sets ChildID and corresponding FirstName.
        /// </summary>
        private void LoadChildrenNames()
        {
            _childUsers = Model.ChildUser.Load("");
            _childrenNames = new Dictionary<int, string>();
            foreach (var child in _childUsers)
            {
                _childrenNames.Add(child.ChildID, child.FirstName);
            }
        }

        #endregion

        #region General Controls

        /// <summary>
        /// Opens new Create form based on selected UI.
        /// </summary>
        private void OptionButton_Click(object sender, EventArgs e)
        {
            switch (UI)
            {
                case 1:
                    //Disable this form
                    this.Enabled = false;

                    //Open CreateChoreUI
                    var createChore = new CreateChoreUI();
                    createChore.Show();

                    //Enable this form when createChore is closed
                    createChore.FormClosing += ChoreNavigationButton_Click;
                    break;

                case 2:
                    //Disable this form
                    this.Enabled = false;

                    //Open CreateRewardUI
                    var createReward = new CreateRewardUI();
                    createReward.Show();

                    //Enable this form when createReward is closed
                    createReward.FormClosing += RewardNavigationButton_Click;
                    break;

                case 4:
                    //Disable this form
                    this.Enabled = false;

                    //Open CreateChildUI
                    var createChild = new CreateChildUI();
                    createChild.Show();

                    //Enable this form when createChild is closed
                    createChild.FormClosing += UsersNavigationButton_Click;
                    break;
            }
        }

        #endregion General Controls

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

        #region NavigationPanel

        /// <summary>
        /// Enables ParentMenu and switches to ChoresUI
        /// </summary>
        private void ChoreNavigationButton_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            ChoresUI();
        }

        /// <summary>
        /// Enables ParentMenu and switches to RewardUI
        /// </summary>
        private void RewardNavigationButton_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            RewardsUI();
        }

        /// <summary>
        /// Enables ParentMenu and switches to LeaderboardUI
        /// </summary>
        private void LeadboardNavigationButton_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            LeaderboardsUI();
        }

        /// <summary>
        /// Enables ParentMenu and switches to UsersUI
        /// </summary>
        private void UsersNavigationButton_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            UsersUI();
        }

        /// <summary>
        /// Enables ParentMenu and switches to NotificationsUI
        /// </summary>
        private void NotificationsNavigationButton_Click(object sender, EventArgs e)
        {
            this.Enabled = true;
            NotificationsUI();
        }

        #endregion NavigationPanel

        #region ChoreUI

        /// <summary>
        /// Loads the ChoresUI and changes title
        /// </summary>
        public void ChoresUI()
        {
            //Updates amount of notifications on notification icon
            LoadAmountOfNotifications();

            //Displays chorePanel
            UI = 1;
            this.chorePanel.Visible = true;
            this.chorePanel.BringToFront();

            //Displays optionButton
            this.optionButton.Visible = true;
            titleText.Text = "Chores";

            //Loads Chores and displays them in chorePanel
            DisplayChores();
        }

        #region Load Methods

        /// <summary>
        /// Loads all Chores and displays them in chorePanel
        /// </summary>
        public void DisplayChores()
        {
            //Refresh childrenNames
            LoadChildrenNames();

            //Clears chorePanel
            chorePanel.Controls.Clear();

            //Loads all Reoccurring Chores, Repeatable and Concrete Chores that are either in approval pending or created by the ParentUser directly
            _concreteChoresApprovalPending = Model.Concrete.Load("status=2 OR (type='conc' AND status=1) ORDER BY status DESC");
            _reoccurringChores = Model.Reoccurring.Load("");
            _repeatableChores = Model.Repeatable.Load("");

            //Sets starting location for Chores. Updated when each Chore is displayed
            int panelDistance = 5;
            int choreLocationY = 0;

            //Displays Concrete Chores
            foreach (var chore in _concreteChoresApprovalPending)
            {
                //Adds a panel with current Chore
                Panel currentPanel = LoadConcreteChore(chore, chorePanel.Width - 20, choreLocationY);
                chorePanel.Controls.Add(currentPanel);

                //Updates location for next Chore
                choreLocationY += currentPanel.Height + panelDistance;
            }

            //Displays Reoccurring Chores
            foreach (var chore in _reoccurringChores)
            {
                //Adds a panel with current Chore
                Panel currentPanel = LoadReocurringChore(chore, chorePanel.Width - 20, choreLocationY);
                chorePanel.Controls.Add(currentPanel);

                //Updates location for next Chore
                choreLocationY += currentPanel.Height + panelDistance;
            }

            //Displays repeatable Chores
            foreach (var chore in _repeatableChores)
            {
                //Adds a panel with current Chore
                Panel currentPanel = LoadRepeatableChore(chore, chorePanel.Width - 20, choreLocationY);
                chorePanel.Controls.Add(currentPanel);

                //Updates location for next Chore
                choreLocationY += currentPanel.Height + panelDistance;
            }
        }

        /// <summary>
        /// Creates an individual panel for a single Repeatable Chore. Adds buttons for editting and deleting the Chore.
        /// </summary>
        /// <param name="chore">Chore to display</param>
        /// <param name="width">Width of the panel</param>
        /// <param name="yLocation">Location in chorePanel</param>
        /// <returns>Panel with Chore info, edit button and delete button</returns>
        public Panel LoadRepeatableChore(Model.Repeatable chore, int width, int yLocation)
        {
            //Sets type specific info
            string status = "Active";
            string type = "Repeatable";

            //Creates the panel
            Panel currentPanel = LoadChore(chore, width, yLocation, status, type);

            //Adds status specific buttons
            currentPanel.Controls.Add(AddEditChoreButton(330, currentPanel.Height / 2, chore));
            currentPanel.Controls.Add(AddDeleteChoreButton(365, currentPanel.Height / 2, chore));

            return currentPanel;
        }

        /// <summary>
        /// Creates an individual panel for a single Repeatable Chore. Adds buttons for editting and deleting the Chore.
        /// </summary>
        /// <param name="chore">Chore to display</param>
        /// <param name="width">Width of the panel</param>
        /// <param name="yLocation">Location in chorePanel</param>
        /// <returns>Panel with Chore info and buttons</returns>
        public Panel LoadReocurringChore(Model.Reoccurring chore, int width, int yLocation)
        {
            //Sets type specific info
            string status = "Active";
            string type = "Reocurring";

            //Creates the panel
            Panel currentPanel = LoadChore(chore, width, yLocation, status, type);

            //Adds status specific buttons
            currentPanel.Controls.Add(AddEditChoreButton(330, currentPanel.Height / 2, chore));
            currentPanel.Controls.Add(AddDeleteChoreButton(365, currentPanel.Height / 2, chore));

            return currentPanel;
        }

        /// <summary>
        /// Creates an individual panel for a single Concrete Chore. Adds buttons for approving, denying, 
        /// editting or deleting the Chore depending on status.
        /// </summary>
        /// <param name="chore">Chore to display</param>
        /// <param name="width">Width of the panel</param>
        /// <param name="yLocation">Location in chorePanel</param>
        /// <returns>Panel with Chore info and buttons</returns>
        public Panel LoadConcreteChore(Model.Concrete chore, int width, int yLocation)
        {
            //Sets type specific info
            string status = _statusValues[chore.Status];
            string type = "Concrete";

            //Creates the panel
            Panel currentPanel = LoadChore(chore, width, yLocation, status, type);

            //Adds status specific buttons.
            //If the Chore is active add edit and delete buttons
            if (chore.Status == 1)
            {
                currentPanel.Controls.Add(AddEditChoreButton(330, currentPanel.Height / 2, chore));
                currentPanel.Controls.Add(AddDeleteChoreButton(365, currentPanel.Height / 2, chore));
            }

            //If the Chore is approval pending add approve and deny buttons
            else if (chore.Status == 2)
            {
                currentPanel.Controls.Add(AddApproveChoreButton(330, currentPanel.Height / 2, chore));
                currentPanel.Controls.Add(AddDenyChoreButton(365, currentPanel.Height / 2, chore));
            }
            return currentPanel;
        }

        /// <summary>
        /// Creates the panel with the Chore. Name, assignment, status and type are displayed for all chores.
        /// </summary>
        /// <param name="chore">Chore to be displayed</param>
        /// <param name="width">Width of the panel</param>
        /// <param name="yLocation">Location in chorePanel</param>
        /// <param name="status">Status of the chore</param>
        /// <param name="type">Chore type</param>
        /// <returns>Panel with labes for each info</returns>
        private Panel LoadChore(Model.Chore chore, int width, int yLocation, string status, string type)
        {
            //Sets stating location for labels and distance between
            int yLoc = 5;
            int LabelDistance = 0;

            //Sets the 4 info texts
            string choreName = chore.Name;
            string choreAssignment = "Assigned to: " + _childrenNames[chore.Assignment];
            string choreStatus = "Status: " + status;
            string choreType = "Type: " + type;

            //Creates the labels and updates yLoc for each
            var choreNameLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(choreName, true, new Point(5, yLoc));
            yLoc += choreNameLabel.Height + LabelDistance;
            var choreAssignmentLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(choreAssignment, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + LabelDistance;
            var choreStatusLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(choreStatus, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + LabelDistance;
            var choreTypeLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(choreType, false, new Point(10, yLoc));
            yLoc += choreNameLabel.Height + LabelDistance;
            var panelHeight = choreNameLabel.Height + choreAssignmentLabel.Height + choreStatusLabel.Height + choreTypeLabel.Height;

            //Creates panel to return
            var currentPanel = TechnicalPlatform.UILibrary.StandardElements.AddPanel(new Point(1, yLocation), width, panelHeight);

            //Adds labels to panel
            currentPanel.Controls.Add(choreNameLabel);
            currentPanel.Controls.Add(choreAssignmentLabel);
            currentPanel.Controls.Add(choreStatusLabel);
            currentPanel.Controls.Add(choreTypeLabel);

            return currentPanel;
        }

        #endregion

        #region Create Button Methods

        /// <summary>
        /// Creates an approve button
        /// </summary>
        private Control AddApproveChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            //Creates a standard button from library
            var approveButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), chore, global::ChoreApplication.Properties.Resources.thumbs_up);

            //Adds event handler
            approveButton.Click += new EventHandler(ApproveChoreButton_Click);

            return approveButton;
        }

        /// <summary>
        /// Creates a deny button
        /// </summary>
        private Control AddDenyChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            //Creates a standard button from library
            var denyButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), chore, global::ChoreApplication.Properties.Resources.thumb_down);
            
            //Adds event handler
            denyButton.Click += new EventHandler(DenyChoreButton_Click);
            return denyButton;
        }

        /// <summary>
        /// Creates a edit button
        /// </summary>
        private Control AddEditChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            //Creates a standard button from library
            var editChoreButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), chore, global::ChoreApplication.Properties.Resources.pencil);
            
            //Adds event handler
            editChoreButton.Click += new EventHandler(EditChoreButton_Click);
            return editChoreButton;
        }

        /// <summary>
        /// Creates a edit button
        /// </summary>
        private Control AddDeleteChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            //Creates a standard button from library
            var deleteChoreButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), chore, global::ChoreApplication.Properties.Resources.delete);

            //Adds event handler
            deleteChoreButton.Click += new EventHandler(DeleteChoreButton_Click);
            return deleteChoreButton;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Approves a Chore and reloads ChoreUI
        /// </summary>
        private void ApproveChoreButton_Click(object sender, System.EventArgs e)
        {
            //Sets currentChore to the clicked button's tag
            Button clickedButton = (Button)sender;
            Model.Concrete currentChore = (Model.Concrete)clickedButton.Tag;

            //Update the Chore's properties and update DB
            currentChore.Status = 3;
            currentChore.ApprovalDate = DateTime.Now;
            currentChore.Update();

            //Load the ChildUser the Chore is assigned to
            var currentChild = Model.ChildUser.Load("child_id=" + currentChore.Assignment);

            //Update the ChildUser's points and update DB
            currentChild[0].Points += currentChore.Points;
            currentChild[0].Update();

            //Create a notification to the ChildUser
            Model.Notification.Insert(currentChild[0].ID, "Chore Approved", $"The chore {currentChore.Name} has been approved." +
                $"\n{currentChore.Points.ToString()} points has been added to your account");

            //Reload ChoresUI
            LoadAmountOfNotifications();
            DisplayChores();
        }

        /// <summary>
        /// Rejects a completed Chore. If the Chore was generated by a Repeatable Chore it is deleted.
        /// If the Chore is Concrete or generated by a Reoccurring Chore it is set to status active and postponed.
        /// </summary>
        private void DenyChoreButton_Click(object sender, System.EventArgs e)
        {
            //Sets currentChore to the clicked button's tag
            Button clickedButton = (Button)sender;
            Model.Concrete currentChore = (Model.Concrete)clickedButton.Tag;

            //Loads the Child the Chore is assigned to
            var currentChild = Model.ChildUser.Load("child_id=" + currentChore.Assignment);

            //If generated by a Repeatable Chore it's deleted
            if (currentChore.Type == "rep")
            {
                currentChore.Delete();
            }

            //Otherwise it's postponed by 1 day and set to active
            else
            {
                currentChore.DueDate = DateTime.Now.AddDays(1);
                currentChore.Status = 1;
                currentChore.Reminder = 0;
                currentChore.Update();
            }

            //Creates a notification to the assigned ChildUser
            Model.Notification.Insert(currentChild[0].ID, "Chore Denied", $"The chore {currentChore.Name} has been denied.");

            //Reload ChoreUI
            LoadAmountOfNotifications();
            DisplayChores();
        }

        /// <summary>
        /// Sends the user to the EditChoreUI to edit the chosen Chore
        /// </summary>
        private void EditChoreButton_Click(object sender, System.EventArgs e)
        {
            //Disables ParentMenu
            this.Enabled = false;

            //Casts clicked button to a Button
            Button clickedButton = (Button)sender;

            //Tries to cast Chore from tag to Concrete. Opens EditChoreUI if succesful
            try
            {
                Model.Concrete selectedChore = (Model.Concrete)clickedButton.Tag;
                var editSelectedChoreUI = new UI.ParentUI.EditChoreUI(selectedChore);
                editSelectedChoreUI.Show();
                editSelectedChoreUI.FormClosing += ChoreNavigationButton_Click;
            }

            //If the Chore isn't a Concrete proceeds to next type
            catch
            {
                //Tries to cast Chore from tag to Reoccurring. Opens EditChoreUI if succesful
                try
                {
                    Model.Reoccurring selectedChore = (Model.Reoccurring)clickedButton.Tag;
                    var editSelectedChoreUI = new UI.ParentUI.EditChoreUI(selectedChore);
                    editSelectedChoreUI.Show();
                    editSelectedChoreUI.FormClosing += ChoreNavigationButton_Click;
                }

                //If the Chore isn't a Concrete proceeds to next type
                catch
                {
                    //Tries to cast Chore from tag to Reoccurring. Opens EditChoreUI if succesful
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

        /// <summary>
        /// Deletes a Chore from DB
        /// </summary>
        private void DeleteChoreButton_Click(object sender, System.EventArgs e)
        {
            //Casts clicked button to a Button
            Button clickedButton = (Button)sender;

            //Displays messagebox for user to confirm delete
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this chore?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    //Casts button's tag to a Chore and deletes it
                    Model.Chore selectedChore = (Model.Chore)clickedButton.Tag;
                    selectedChore.Delete();

                    //Reloads ChoreUI
                    DisplayChores();
                }
                
                catch
                {
                    MessageBox.Show("Could not delete selected chore: Conversion failed", "Error");
                }
                    
                
            }
        }

        #endregion

        #endregion ChoreUI

        #region RewardUI

        /// <summary>
        /// Loads the RewardUI and changes title
        /// </summary>
        private void RewardsUI()
        {
            //Updates amount of notifications on notification icon
            LoadAmountOfNotifications();

            //Displays rewardPanel
            UI = 2;
            this.rewardPanel.Visible = true;
            this.rewardPanel.BringToFront();

            //Displays optionButton
            this.optionButton.Visible = true;
            titleText.Text = "Rewards";

            //Loads Rewards and displays them in chorePanel
            DisplayRewards();
        }

        #region Load Methods

        /// <summary>
        /// Loads Chores and displays them in chorePanel
        /// </summary>
        private void DisplayRewards()
        {
            //Loads all Rewards to list
            _rewards = Model.Reward.Load("");

            //Clears rewardPanel
            rewardPanel.Controls.Clear();

            //Sets starting location for Chores. Updated when each Reward is displayed
            int panelDistance = 5;
            int rewardLocationY = 0;

            //Displays each Reward
            foreach (Model.Reward reward in _rewards)
            {
                //Creates a panel with Reward info and adds to rewardPanel
                Panel currentReward = LoadReward(reward, rewardLocationY);
                rewardPanel.Controls.Add(currentReward);

                //Updates location for next Reward
                rewardLocationY += currentReward.Height + panelDistance;
            }
        }

        /// <summary>
        /// Creates an individual panel for a single Reward. Adds buttons for editting and deleting the Reward.
        /// </summary>
        /// <param name="reward">Reward to display</param>
        /// <param name="yLocation">Location in rewardPanel</param>
        /// <returns>Panel with Reward info, edit button and delete button</returns>
        private Panel LoadReward(Model.Reward reward, int yLocation)
        {
            //Sets starting location for labels. Updated when each label is displayed
            int yLoc = 5;
            int labelDist = 0;

            //Sets label text from Reward roperties
            var rewardName = reward.Name;
            var rewardAssignment = "Assigned to: " + _childrenNames[reward.ChildID];
            var rewardStatus = "Status: Active";

            //Creates a label with the label text. Updates y location for next label each time
            var rewardNameLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(rewardName, true, new Point(5, yLoc));
            yLoc += rewardNameLabel.Height + labelDist;
            var rewardAssignmentLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(rewardAssignment, false, new Point(10, yLoc));
            yLoc += rewardNameLabel.Height + labelDist;
            var rewardStatusLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(rewardStatus, false, new Point(10, yLoc));
            yLoc += rewardNameLabel.Height + labelDist;

            var panelHeight = rewardNameLabel.Height + rewardAssignmentLabel.Height + rewardStatusLabel.Height;

            //Creates panel from library
            var individualRewardPanel = TechnicalPlatform.UILibrary.StandardElements.AddPanel(new Point(1, yLocation), chorePanel.Width - 20, panelHeight);

            //Adds labels and returns panel
            individualRewardPanel.Controls.Add(rewardNameLabel);
            individualRewardPanel.Controls.Add(rewardAssignmentLabel);
            individualRewardPanel.Controls.Add(rewardStatusLabel);
            individualRewardPanel.Controls.Add(AddEditRewardButton(330, individualRewardPanel.Height / 2, reward));
            individualRewardPanel.Controls.Add(AddDeleteRewardButton(365, individualRewardPanel.Height / 2, reward));

            return individualRewardPanel;
        }

        #endregion

        #region Create Button Methods

        /// <summary>
        /// Creates an edit button
        /// </summary>
        private Control AddEditRewardButton(int locationX, int locationY, Model.Reward reward)
        {
            //Creates a standard button from library
            var editRewardButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), reward, global::ChoreApplication.Properties.Resources.pencil);

            //Adds event handler
            editRewardButton.Click += new EventHandler(EditRewardButton_Click);
            return editRewardButton;
        }

        /// <summary>
        /// Creates an delete button
        /// </summary>
        private Control AddDeleteRewardButton(int locationX, int locationY, Model.Reward reward)
        {
            //Creates a standard button from library
            var deleteRewardButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), reward, global::ChoreApplication.Properties.Resources.delete);

            //Adds event handler
            deleteRewardButton.Click += new EventHandler(DeleteRewardButton_Click);
            return deleteRewardButton;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Sends the user to the EditRewardUI to edit the chosen Chore
        /// </summary>
        private void EditRewardButton_Click(object sender, System.EventArgs e)
        {
            //Disables ParentMenu
            this.Enabled = false;

            Button clickedButton = (Button)sender;

            try
            {
                //Casts tag from clicked button as Reward
                Model.Reward selectedReward = (Model.Reward)clickedButton.Tag;

                //Creates a EditRewardUI with the Reward
                var editSelectedRewardUI = new EditRewardUI(selectedReward);
                editSelectedRewardUI.Show();

                //Enables ParentMenu on close
                editSelectedRewardUI.FormClosing += RewardNavigationButton_Click;
            }
            catch
            {
                MessageBox.Show("Could not edit reward: Reward not found", "Error");
            }
        }

        /// <summary>
        /// Deletes a Reward in DB
        /// </summary>
        private void DeleteRewardButton_Click(object sender, System.EventArgs e)
        {
            //Casts clicked button's tag to Reward
            Button clickedButton = (Button)sender;
            Model.Reward selectedReward = (Model.Reward)clickedButton.Tag;

            //Displays messagebox for user to confirm delete
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this reward?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                //Deletes the Reward and reloads RewarUI
                selectedReward.Delete();
                DisplayRewards();
            }
        }

        #endregion

        #endregion RewardUI

        #region LeaderboardUI

        /// <summary>
        /// Loads the LeaderboardUI and changes title
        /// </summary>
        private void LeaderboardsUI()
        {
            //Updates amount of notifications on notification icon
            LoadAmountOfNotifications();

            //Displays leaderboardPanel
            UI = 3;
            titleText.Text = "Leaderboard";
            this.leaderboardPanel.Visible = true;
            this.leaderboardPanel.BringToFront();

            //Displays optionButton
            this.optionButton.Visible = false;

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

            //Only loads leaderboard if there are ChildUsers in DB
            if (_childUsers.Count != 0)
            {
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

                //Add Longest Strea panel
                var longestStreakStatisticPanel = Functions.UIFunctions.LoadLongestStreak(new Point(0, leaderboardLocationY),
                leaderboardPanel.Width, _childrenNames, _childUsers);
                this.leaderboardPanel.Controls.Add(longestStreakStatisticPanel);
            }
        }

        #endregion LeaderboardUI

        #region UsersUI

        /// <summary>
        /// Loads UsersUI and changes title.
        /// </summary>
        private void UsersUI()
        {
            //Updates amount of notifications on notification icon
            LoadAmountOfNotifications();

            //Displays userPanel
            UI = 4;
            titleText.Text = "Users";
            this.userPanel.Visible = true;
            this.userPanel.BringToFront();

            //Displays optionButton
            this.optionButton.Visible = true;

            //Loads and displays all users in their own panel
            DisplayUsers();
        }

        #region Load Methods

        /// <summary>
        /// Displays all Users in an individual panel with their info from DB.
        /// ParentUser has an edit button.
        /// ChildUsers have an edit button and a delete button.
        /// </summary>
        public void DisplayUsers()
        {
            //Loads all Users
            _childUsers = Model.ChildUser.Load("");
            _parentUsers = Model.ParentUser.Load("");

            //Clears userPanel
            userPanel.Controls.Clear();

            //Sets starting location for the first individual panel. Updated after each panel has been displayed
            int panelDistance = 5;
            int userLocationY = 0;

            //Displays ParentUser
            foreach (Model.ParentUser parent in _parentUsers)
            {
                Panel currentPanel = LoadParent(parent, userLocationY);
                userPanel.Controls.Add(currentPanel);
                userLocationY += currentPanel.Height + panelDistance;
            }

            //Displays all ChildUsers
            foreach (Model.ChildUser child in _childUsers)
            {
                Panel currentPanel = LoadChild(child, userLocationY);
                userPanel.Controls.Add(currentPanel);
                userLocationY += currentPanel.Height + panelDistance;
            }
        }

        /// <summary>
        /// Displays a ParentUser in a panel.
        /// </summary>
        private Panel LoadParent(Model.ParentUser parent, int yLocation)
        {
            //Creates a panel with User info
            var individualUserPanel = LoadUser(parent, yLocation);

            //Adds edit button
            individualUserPanel.Controls.Add(AddEditParentButton(365, individualUserPanel.Height / 2, parent));
            return individualUserPanel;
        }

        /// <summary>
        /// Displays a ChildUser in a panel
        /// </summary>
        private Panel LoadChild(Model.ChildUser child, int yLocation)
        {
            //Creates a panel with User info
            var individualUserPanel = LoadUser(child, yLocation);

            //Adds edit and delete button
            individualUserPanel.Controls.Add(AddEditChildButton(330, individualUserPanel.Height / 2, child));
            individualUserPanel.Controls.Add(AddDeleteChildButton(365, individualUserPanel.Height / 2, child));
            return individualUserPanel;
        }

        /// <summary>
        /// Displays universal User info in a panel.
        /// </summary>
        private Panel LoadUser(Model.User user, int yLocation)
        {
            //Creates label text
            var userFirstName = user.FirstName.ToString();

            //Creates label and panel from library
            var userFirstNameLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(userFirstName, true, new Point(5, 5));
            var panelHeight = userFirstNameLabel.Height + 40;
            var individualUserPanel = TechnicalPlatform.UILibrary.StandardElements.AddPanel(new Point(1, yLocation), chorePanel.Width - 20, panelHeight);

            //Adds label to panel and returns
            individualUserPanel.Controls.Add(userFirstNameLabel);
            return individualUserPanel;
        }

        #endregion

        #region Create Button Methods

        /// <summary>
        /// Creates a button to edit ChildUsers.
        /// </summary>
        private Control AddEditChildButton(int locationX, int locationY, Model.ChildUser childUser)
        {
            //Creates a standard button from library
            var editChildButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), childUser, global::ChoreApplication.Properties.Resources.pencil);

            //Adds event handler
            editChildButton.Click += new EventHandler(EditChildButton_Click);
            return editChildButton;
        }

        /// <summary>
        /// Creates a button to edit ParentUser
        /// </summary>
        private Control AddEditParentButton(int locationX, int locationY, Model.ParentUser parentUser)
        {
            //Creates a standard button from library
            var editParentButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), parentUser, global::ChoreApplication.Properties.Resources.pencil);

            //Adds event handler
            editParentButton.Click += new EventHandler(EditParentButton_Click);
            return editParentButton;
        }

        /// <summary>
        /// Creates a button to delete a ChildUser
        /// </summary>
        private Control AddDeleteChildButton(int locationX, int locationY, Model.ChildUser childUser)
        {
            //Creates a standard button from library
            var deleteChildButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationX, locationY - 15), childUser, global::ChoreApplication.Properties.Resources.delete);

            //Adds event handler
            deleteChildButton.Click += new EventHandler(DeleteChildButton_Click);
            return deleteChildButton;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Deletes ChildUser from button tag in DB.
        /// </summary>
        private void DeleteChildButton_Click(object sender, System.EventArgs e)
        {
            //Sets selectedUser to the ChildUser in button tag
            Button clickedButton = (Button)sender;
            Model.ChildUser selectedUser = (Model.ChildUser)clickedButton.Tag;

            //Displays message box for user to confirm deleting
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo);

            //Deletes ChildUser and reloads UI if yes
            if (confirmDelete == DialogResult.Yes)
            {
                selectedUser.Delete();
                UsersUI();
            }
        }

        /// <summary>
        /// Sends user to EditParentUI to edit chosen User
        /// </summary>
        private void EditParentButton_Click(object sender, System.EventArgs e)
        {
            //Disable ParentMenu
            this.Enabled = false; 

            Button clickedButton = (Button)sender;
            try
            {
                //Sets selectedParent to ParentUser from clicked button's tag
                Model.ParentUser selectedParent = (Model.ParentUser)clickedButton.Tag;

                //Opens EditParentUI
                var editSelectedParentUI = new EditParentUI(selectedParent);
                editSelectedParentUI.Show();

                //Enables ParentMenu on close
                editSelectedParentUI.FormClosing += UsersNavigationButton_Click;
            }
            catch
            {
                MessageBox.Show("Could not edit Parent: Parent not found", "Error");
            }
        }

        /// <summary>
        /// Sends user to EditChildUI to edit chosen User
        /// </summary>
        private void EditChildButton_Click(object sender, System.EventArgs e)
        {
            //Disable ParentMenu
            this.Enabled = false;

            Button clickedButton = (Button)sender;
            try
            {
                //Sets selectedChild to ChildUser from clicked button's tag
                Model.ChildUser selectedChild = (Model.ChildUser)clickedButton.Tag;

                //Opens EditChildUI
                var editSelectedChildUI = new EditChildUI(selectedChild);
                editSelectedChildUI.Show();

                //Enables ParentMenu on close
                editSelectedChildUI.FormClosing += UsersNavigationButton_Click;
            }
            catch
            {
                MessageBox.Show("Could not edit child: Child not found", "Error");
            }
        }

        #endregion

        #endregion UsersUI

        #region NotificationsUI

        /// <summary>
        /// Loads NotificationsUI and changes title.
        /// </summary>
        private void NotificationsUI()
        {
            //Displays notificationPanel
            UI = 5;
            titleText.Text = "Notifications";
            this.notificationPanel.Visible = true;
            this.notificationPanel.BringToFront();

            //Hides optionButton
            this.optionButton.Visible = false;

            //Loads each notification in an individual panel
            DisplayNotifications();

            //Updates amount of notifications on notification icon
            LoadAmountOfNotifications();
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

        #region Create Button Methods

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
            NotificationsUI();
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
            notificationAmountLabel.Text = "";

            //If there are no Notifications displays nothing
            if (_notifications.Count == 0)
            {
                notificationAmountLabel.Visible = false;
            }

            //Displays amount if one or more Notifications
            else
            {
                notificationAmountLabel.Text = _notifications.Count.ToString();
            }
        }

        #endregion NotificationsUI
    }
}