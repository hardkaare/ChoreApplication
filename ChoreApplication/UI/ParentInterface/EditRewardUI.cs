using System;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    /// <summary>
    /// Displays the EditRewardUI that edits a Reward in the DB. 
    /// Designer adds textboxes/navigationupdown for user input and combobox for assignment.
    /// Designer adds a button for Save changes.
    /// This class contains an event handler for Save changes button.
    /// This class contains a private method to load ChildUsers to assignment combobox.
    /// </summary>
    public partial class EditRewardUI : Form
    {
        #region Properties

        //Reward being editted
        private Model.Reward _reward { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Creates and displays general chore elements in the designer.
        /// Fills in existing data from DB
        /// </summary>
        public EditRewardUI(Model.Reward reward)
        {
            InitializeComponent();
            LoadChildren();
            _reward = reward;
            rewardNameTextBox.Text = _reward.Name;
            descriptionRichTextBox.Text = _reward.Description;
            pointsRequiredNumericUpDown.Value = _reward.RequiredPoints;
            foreach (var child in Model.ChildUser.Load($"c.child_id = {_reward.Assignment}"))
            {
                childAssignedComboBox.Text = child.FirstName;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Loads ChildUsers from DB and displays them in assignment combobox.
        /// </summary>
        private void LoadChildren()
        {
            //Loads all ChildUsers
            var children = Model.ChildUser.Load("");

            //Creates array for ChildUsers. Used for validation later
            var childrenarray = new string[children.Count];
            var i = 0;

            //Adds ChildUsers name to childrenarray and assignment combobox
            foreach (var name in children)
            {
                childrenarray[i] = name.FirstName;
                this.childAssignedComboBox.Items.Add(childrenarray[i]);
                i++;
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Validates inputs and updates Reward
        /// </summary>
        private void SaveReward_Click(object sender, EventArgs e)
        {
            //Searches DB for ChildID from selected name in assignment combobox
            int id = 0;
            foreach (var child in Model.ChildUser.Load($"u.first_name = '{childAssignedComboBox.Text}'"))
            {
                id = child.ChildID;
            }

            //Sets properties for the Reward
            _reward.Assignment = id;
            _reward.Name = rewardNameTextBox.Text;
            _reward.Description = descriptionRichTextBox.Text;
            _reward.RequiredPoints = (int)pointsRequiredNumericUpDown.Value;

            //Updates, closes form and displays confirmation message
            _reward.Update();
            this.Close();
            MessageBox.Show("The reward has been updated.");
        }

        #endregion
    }
}