using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI
{
    public partial class CreateChoreUI : Form
    {
        public CreateChoreUI()
        {
            InitializeComponent();
            LoadChildren();
            this.dueDateTimePicker.MinDate = DateTime.Now;
        }

        private void ChoreType_SelectIndexChanged(object sender, EventArgs e)
        {
            switch (choreTypesComboBox.Text)
            {
                case "Reoccurring":
                    this.Controls.Add(this.daysCheckedListBox);
                    daysCheckedListBox.Visible = true;
                    dueDateLabel.Text = "Days";
                    this.Controls.Add(this.dueTimeDateTimePicker);
                    dueTimeDateTimePicker.Visible = true;
                    this.Controls.Add(this.dueTimeLabel);
                    dueTimeLabel.Visible = true;
                    dueDateTimePicker.Visible = false;
                    assignmentLabel.Location = new System.Drawing.Point(62, 420);
                    childAssignedCombobox.Location = new System.Drawing.Point(65, 440);
                    createChoreButton.Location = new System.Drawing.Point(65, 470);
                    this.Size = new Size(350, 550);
                    completionsLimitNumericUpDown.Visible = false;
                    break;

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

                case "Repeatable":
                    this.Controls.Add(this.completionsLimitNumericUpDown);
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

        private void LoadChildren()
        {
            var children = ChildUser.Load("");
            var childrenarray = new string[children.Count];
            var i = 0;
            foreach (var name in children)
            {
                childrenarray[i] = name.FirstName;
                this.childAssignedCombobox.Items.Add(childrenarray[i]);
                i++;
            }
        }

        private void CreateChoreButton_Click(object sender, EventArgs e)
        {
            var children = ChildUser.Load("");
            int id = 0;
            var choreType = "";

            for (int i = 0; i < children.Count; i++)
            {
                if (children[i].FirstName == childAssignedCombobox.Text)
                {
                    id = children[i].ChildId;
                }
            }
            if (Regex.IsMatch(choreNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z\s]+$"))
            {
                switch (choreTypesComboBox.Text)
                {
                    case "Concrete":
                        choreType = "conc";
                        try
                        {
                            Concrete.Insert(choreNameTextBox.Text, choreDescriptionRichTextBox.Text, Convert.ToInt32(chorePointsTextBox.Text), id, Convert.ToDateTime(dueDateTimePicker.Text), choreType);
                            this.Close();
                            MessageBox.Show("A chore has been created", "Chore Created");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Incorrect information entered", "Error");
                        }
                        break;

                    case "Repeatable":
                        choreType = "rep";
                        try
                        {
                            Repeatable.Insert(id, choreNameTextBox.Text, choreDescriptionRichTextBox.Text, Convert.ToInt32(chorePointsTextBox.Text), (Int32)completionsLimitNumericUpDown.Value);
                            this.Close();
                            MessageBox.Show("A chore has been created", "Chore Created");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Incorrect information entered", "Error");
                        }
                        break;

                    case "Reoccurring":
                        choreType = "reoc";
                        try
                        {
                            List<string> DaysChecked = daysCheckedListBox.CheckedItems.OfType<string>().ToList<string>();
                            int dayChecked = 0;
                            foreach (var day in DaysChecked)
                            {
                                dayChecked++;
                            }
                            if (dayChecked > 0)
                            {
                                Reocurring.Insert(id, choreNameTextBox.Text, choreDescriptionRichTextBox.Text, Convert.ToInt32(chorePointsTextBox.Text), Convert.ToDateTime(dueTimeDateTimePicker.Text), DaysChecked);
                                this.Close();
                                MessageBox.Show("A chore has been created", "Chore Created");
                            }
                            else
                            {
                                MessageBox.Show("You must select at least one day.", "Error");
                            }
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Incorrect information entered", "Error");
                        }
                        finally
                        {
                            DatabaseFunctions.DatabaseConnection.Close();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Chore name cannot contain numbers.", "Error");
            }
        }
    }
}