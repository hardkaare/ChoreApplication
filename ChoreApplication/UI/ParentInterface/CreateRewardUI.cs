using System;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    /// <summary>
    /// Displays the CreateRewardUI that creates a ParentUser in the DB. 
    /// Designer adds textboxes for all userinput.
    /// Designer adds a button for Create reward.
    /// This class contains event handler for Create reward button.
    /// This class contains a private method for adding ChildUsers to combobox.
    /// </summary>
    public partial class CreateRewardUI : Form
    {
        #region Constructor

        /// <summary>
        /// Creates and displays elements in the designer. Adds ChildUsers to assignment combobox.
        /// </summary>
        public CreateRewardUI()
        {
            InitializeComponent();
            LoadChildren();
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

            //Adds each ChildUser to combobox
            foreach (var name in children)
            {
                this.assignmentComboBox.Items.Add(name.FirstName);
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Validates user input and inserts a reward in DB
        /// </summary>
        private void CreateReward_Click(object sender, EventArgs e)
        {
            //Loads all ChildUsers
            var children = Model.ChildUser.Load("");
            int id = 0;

            //Searches for ChildID in children based on selected name
            for (int i = 0; i < children.Count; i++)
            {
                if (children[i].FirstName == assignmentComboBox.Text)
                {
                    id = children[i].ChildID;
                }
            }

            //Inserts reward if assignment is not empty
            if (!string.IsNullOrEmpty(assignmentComboBox.Text))
            {
                Model.Reward.Insert(id, rewardNameTextBox.Text, descriptionRichTextBox.Text, Convert.ToInt32(pointsRequiredNumericUpDown.Text));
                this.Close();
                MessageBox.Show("A reward has been created", "Reward Created");
            }

            //Displays error message if no ChildUser has been selected
            else
            {
                MessageBox.Show("You must assign the reward to a child.", "Error");
            }
        }

        #endregion
    }
}