using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    /// <summary>
    /// Displays the EditChoreUI that edits a ChildUser in the DB. 
    /// Designer adds textboxes for user input and combobox for assignment.
    /// Designer adds a button for Save changes.
    /// This class contains 3 constructors - one for each coretype.
    /// This class contains an event handler for Save changes button.
    /// This class contains a private method to load ChildUsers to assignment combobox.
    /// </summary>
    public partial class EditChoreUI : Form
    {
        #region Properties

        //Concrete Chore being editted
        private Model.Concrete _concrete { get; set; }

        //Repeatable Chore being editted
        private Model.Repeatable _repeatable { get; set; }

        //Reoccurring Chore being editted
        private Model.Reoccurring _reoccurring { get; set; }

        //Used to Insert correctly. 1 = Concrete, 2 = Repeatable, 3 = Reoccurring
        private int _choreType = 0;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates and displays general chore elements in the designer.
        /// Adds DateTimePicker for due date.
        /// </summary>
        public EditChoreUI(Model.Concrete chore)
        {
            //Display general UI elements
            InitializeComponent();

            //Adds ChildUsers to combobox
            LoadChildren();
            foreach (var child in Model.ChildUser.Load($"c.child_id = {_concrete.Assignment}"))
            {
                childAssignedComboBox.Text = child.FirstName;
            }

            //Sets the chore being editted and fills in existing chore info from DB
            _concrete = chore;
            choreNameTextBox.Text = _concrete.Name;
            chorePointsTextBox.Text = _concrete.Points.ToString();
            choreDescriptionRichTextBox.Text = _concrete.Description;

            //Adds type specific UI elements
            this.Controls.Add(dueDateLabel);
            this.Size = new Size(350, 385);
            dueDateLabel.Text = "Due date";
            this.Controls.Add(dueDateDateTimePicker);
            dueDateDateTimePicker.Text = _concrete.DueDate.ToString();

            _choreType = 1;
        }

        /// <summary>
        /// Creates and displays general chore elements in the designer.
        /// Adds NavigationUpDown for limit.
        /// </summary>
        public EditChoreUI(Model.Repeatable chore)
        {
            //Display general UI elements
            InitializeComponent();

            //Adds ChildUsers to combobox
            LoadChildren();
            foreach (var child in Model.ChildUser.Load($"c.child_id = {_repeatable.Assignment}"))
            {
                childAssignedComboBox.Text = child.FirstName;
            }
            this.Controls.Add(childAssignedComboBox);

            //Sets the chore being editted and fills in existing chore info from DB
            _repeatable = chore;
            choreNameTextBox.Text = _repeatable.Name;
            chorePointsTextBox.Text = _repeatable.Points.ToString();
            choreDescriptionRichTextBox.Text = _repeatable.Description;

            //Adds type specific UI elements
            this.Size = new Size(350, 385);
            this.Controls.Add(dueDateLabel);
            dueDateLabel.Text = "Limit";
            this.Controls.Add(completionLimitUpDown);
            completionLimitUpDown.Value = _repeatable.Limit;

            _choreType = 2;
        }

        /// <summary>
        /// Creates and displays general chore elements in the designer.
        /// Adds TimePicker for due time.
        /// Adds CheckedListBox for days.
        /// </summary>
        public EditChoreUI(Model.Reoccurring chore)
        {
            //Display general UI elements
            InitializeComponent();

            //Adds ChildUsers to combobox
            LoadChildren();
            foreach (var child in Model.ChildUser.Load($"c.child_id = {_reoccurring.Assignment}"))
            {
                childAssignedComboBox.Text = child.FirstName;
            }
            this.Controls.Add(this.childAssignedComboBox);

            //Sets the chore being editted and fills in existing chore info from DB
            _reoccurring = chore;
            choreNameTextBox.Text = _reoccurring.Name;
            chorePointsTextBox.Text = _reoccurring.Points.ToString();
            choreDescriptionRichTextBox.Text = _reoccurring.Description;

            //Adds type specific UI elements
            this.Controls.Add(dueDateLabel);
            dueDateLabel.Text = "Due time";
            this.Controls.Add(dueTimeDateTimePicker);
            dueTimeDateTimePicker.Text = _reoccurring.DueTime.ToString();
            this.Controls.Add(daysLabel);
            this.Controls.Add(daysCheckedListBox);
            this.Size = new Size(350, 525);

            //Fills in days in days from DB. Checks each day in CheckedListBox with each day in the Chore
            for (int i = 0; i < daysCheckedListBox.Items.Count; i++)
            {
                for (int j = 0; j < _reoccurring.Days.Count; j++)
                {
                    //Reqular expression removing whitespace from string.
                    string formItem = Regex.Replace(daysCheckedListBox.Items[i].ToString(), @"\s", "");
                    string choreItem = Regex.Replace(_reoccurring.Days[j], @"\s", "");

                    //Is true if day is found
                    bool equals = String.Equals(formItem, choreItem, StringComparison.OrdinalIgnoreCase);

                    //Checks checkbox if day is found in list
                    if (equals)
                    {
                        daysCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            saveChangesButton.Location = new System.Drawing.Point(69, 440);
            _choreType = 3;
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
            var childrenArray = new string[children.Count];
            var i = 0;

            //Adds ChildUsers name to childrenarray and assignment combobox
            foreach (var name in children)
            {
                childrenArray[i] = name.FirstName;
                childAssignedComboBox.Items.Add(childrenArray[i]);
                i++;
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Validates inputs and updates Chore
        /// </summary>
        private void CreateChoreButton_Click(object sender, EventArgs e)
        {
            //Searches DB for ChildID from selected name in assignment combobox
            int id = 0;
            foreach (var child in Model.ChildUser.Load($"u.first_name = '{childAssignedComboBox.Text}'"))
            {
                id = child.ChildID;
            }

            //Validates that chore name only contains letters
            if (Regex.IsMatch(choreNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z\s]+$"))
            {
                try
                {
                    //Updates the chore based on chore type
                    switch (_choreType)
                    {
                        //Updates via Concrete Chore
                        case 1:
                            
                            //Sets properties for the Chore
                            _concrete.Name = choreNameTextBox.Text;
                            _concrete.Points = Convert.ToInt32(chorePointsTextBox.Text);
                            _concrete.Description = choreDescriptionRichTextBox.Text;
                            _concrete.Assignment = id;
                            _concrete.DueDate = Convert.ToDateTime(dueDateDateTimePicker.Text);

                            //Updates, closes form and displays confirmation message
                            _concrete.Update();
                            this.Close();
                            MessageBox.Show("The concrete chore has been updated.");
                            break;

                        //Updates via Repeatable Chore
                        case 2:

                            //Sets properties for the Chore
                            _repeatable.Name = choreNameTextBox.Text;
                            _repeatable.Points = Convert.ToInt32(chorePointsTextBox.Text);
                            _repeatable.Description = choreDescriptionRichTextBox.Text;
                            _repeatable.Assignment = id;
                            _repeatable.Limit = (int)completionLimitUpDown.Value;

                            //Updates, closes form and displays confirmation message
                            _repeatable.Update();
                            this.Close();
                            MessageBox.Show("The repeatable chore has been updated.");
                            break;

                        //Updates via Repeatable Chore
                        case 3:

                            //Sets properties for the Chore
                            _reoccurring.Name = choreNameTextBox.Text;
                            _reoccurring.Points = Convert.ToInt32(chorePointsTextBox.Text);
                            _reoccurring.Description = choreDescriptionRichTextBox.Text;
                            _reoccurring.Assignment = id;
                            _reoccurring.DueTime = Convert.ToDateTime(dueTimeDateTimePicker.Text);
                            _reoccurring.Days = daysCheckedListBox.CheckedItems.OfType<string>().ToList<string>();

                            //Updates, closes form and displays confirmation message
                            _reoccurring.Update();
                            this.Close();
                            MessageBox.Show("The reoccurring chore has been updated.");
                            break;
                    }
                }

                //Displays error message if incorrect information was entered
                catch (Exception)
                {
                    MessageBox.Show("Invalid information entered.");
                }
            }
        }

        #endregion
    }
}