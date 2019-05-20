using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    /// <summary>
    /// Displays the CreateChoreUI that creates a Chore in the DB. 
    /// Designer adds textboxes for title, description and points.
    /// Designer adds combobox for choretype and assignment.
    /// Designer adds a button for create chore.
    /// Designer adds UI elements for type specific inputs which are added and shown based on choretype.
    /// This class contains event handlers for combobox changed and create button.
    /// This class contains private method for adding children to assignment combobox
    /// </summary>
    public partial class CreateChoreUI : Form
    {
        #region Constructor

        /// <summary>
        /// Creates and displays elements in the designer.
        /// Loads children to assignment combobox, and sets minimum date for duedate timepicker.
        /// </summary>
        public CreateChoreUI()
        {
            InitializeComponent();
            LoadChildren();
            this.dueDateTimePicker.MinDate = DateTime.Now;
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
                this.childAssignedCombobox.Items.Add(childrenarray[i]);
                i++;
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Event handler for when choretype is changed. Adds UI elements based on choretype.
        /// </summary>
        private void ChoreType_SelectIndexChanged(object sender, EventArgs e)
        {
            switch (choreTypesComboBox.Text)
            {
                /// <summary>
                /// If reoccurring is selected, these elements are are added and shown:
                /// Checkboxes for days.
                /// Timepicker for duetime.
                /// Other typespecific elements are hidden.
                /// </summary>
                case "Reoccurring":
                    this.Controls.Add(daysCheckedListBox);
                    daysCheckedListBox.Visible = true;
                    dueDateLabel.Text = "Days";
                    this.Controls.Add(dueTimeDateTimePicker);
                    dueTimeDateTimePicker.Visible = true;
                    this.Controls.Add(dueTimeLabel);
                    dueTimeLabel.Visible = true;
                    dueDateTimePicker.Visible = false;
                    assignmentLabel.Location = new System.Drawing.Point(62, 420);
                    childAssignedCombobox.Location = new System.Drawing.Point(65, 440);
                    createChoreButton.Location = new System.Drawing.Point(65, 470);
                    this.Size = new Size(350, 550);
                    completionsLimitNumericUpDown.Visible = false;
                    break;

                /// <summary>
                /// If concrete is selected, these elements are are added and shown:
                /// Timepicker for due date.
                /// Other typespecific elements are hidden.
                /// </summary>
                case "Concrete":
                    dueDateTimePicker.Visible = true;
                    dueDateLabel.Text = "Due date";
                    daysCheckedListBox.Visible = false;
                    completionsLimitNumericUpDown.Visible = false;
                    assignmentLabel.Location = new System.Drawing.Point(62, 291);
                    childAssignedCombobox.Location = new System.Drawing.Point(65, 310);
                    createChoreButton.Location = new System.Drawing.Point(65, 340);
                    this.Size = new Size(350, 420);
                    dueTimeDateTimePicker.Visible = false;
                    dueTimeLabel.Visible = false;
                    break;

                /// <summary>
                /// If repeatable is selected, these elements are are added and shown:
                /// NumericUpDown for limit
                /// Other typespecific elements are hidden.
                /// </summary>
                case "Repeatable":
                    this.Controls.Add(completionsLimitNumericUpDown);
                    dueDateLabel.Text = "Completion limit";
                    dueDateTimePicker.Visible = false;
                    completionsLimitNumericUpDown.Visible = true;
                    daysCheckedListBox.Visible = false;
                    assignmentLabel.Location = new System.Drawing.Point(62, 291);
                    childAssignedCombobox.Location = new System.Drawing.Point(65, 310);
                    createChoreButton.Location = new System.Drawing.Point(65, 340);
                    this.Size = new Size(350, 420);
                    dueTimeDateTimePicker.Visible = false;
                    dueTimeLabel.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Event handler for CreateChoreButton. Validates input and inserts the chore in DB
        /// </summary>
        private void CreateChoreButton_Click(object sender, EventArgs e)
        {
            //Loads ChildUsers
            var children = Model.ChildUser.Load("");
            int id = 0;
            var choreType = "";

            //Searches for ChildID in children based on selected name
            for (int i = 0; i < children.Count; i++)
            {
                if (children[i].FirstName == childAssignedCombobox.Text)
                {
                    id = children[i].ChildID;
                }
            }

            //Validates chore name
            if (Regex.IsMatch(choreNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z\s]+$"))
            {
                //Inserts chore based on choretype combobox
                switch (choreTypesComboBox.Text)
                {
                    //Inserts a concrete chore and displays error or confirmation message
                    case "Concrete":
                        choreType = "conc";
                        try
                        {
                            Model.Concrete.Insert(choreNameTextBox.Text, choreDescriptionRichTextBox.Text, Convert.ToInt32(chorePointsTextBox.Text), id, Convert.ToDateTime(dueDateTimePicker.Text), choreType);
                            this.Close();
                            MessageBox.Show("A chore has been created", "Chore Created");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Incorrect information entered", "Error");
                        }
                        break;

                    //Inserts a repeatable chore and displays error or confirmation message
                    case "Repeatable":
                        choreType = "rep";
                        try
                        {
                            Model.Repeatable.Insert(id, choreNameTextBox.Text, choreDescriptionRichTextBox.Text, Convert.ToInt32(chorePointsTextBox.Text), (Int32)completionsLimitNumericUpDown.Value);
                            this.Close();
                            MessageBox.Show("A chore has been created", "Chore Created");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Incorrect information entered", "Error");
                        }
                        break;

                    //Inserts a reoccurring chore and displays error or confirmation message
                    case "Reoccurring":
                        choreType = "reoc";
                        try
                        {
                            //Creates a list of checked days
                            List<string> DaysChecked = daysCheckedListBox.CheckedItems.OfType<string>().ToList<string>();
                            int dayChecked = 0;
                            foreach (var day in DaysChecked)
                            {
                                dayChecked++;
                            }

                            //If user has checked one or more days inserts the chore
                            if (dayChecked > 0)
                            {
                                Model.Reoccurring.Insert(id, choreNameTextBox.Text, choreDescriptionRichTextBox.Text, Convert.ToInt32(chorePointsTextBox.Text), Convert.ToDateTime(dueTimeDateTimePicker.Text), DaysChecked);
                                this.Close();
                                MessageBox.Show("A chore has been created", "Chore Created");
                            }
                            else
                            {
                                MessageBox.Show("You must select at least one day.", "Error");
                            }
                        }

                        //Error message if DB exception
                        catch (SqlException)
                        {
                            MessageBox.Show("Incorrect information entered", "Error");
                        }

                        //Clean up
                        finally
                        {
                            Functions.DatabaseFunctions.DatabaseConnection.Close();
                        }
                        break;
                }
            }

            //Error message if chore name contains numbers
            else
            {
                MessageBox.Show("Chore name cannot contain numbers.", "Error");
            }
        }

        #endregion
    }
}