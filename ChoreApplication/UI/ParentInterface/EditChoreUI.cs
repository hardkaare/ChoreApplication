using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChoreApplication.UI.ParentUI
{
    public partial class EditChoreUI : Form
    {
        private Model.Concrete _concrete;
        private Model.Repeatable _repeatable;
        private Model.Reocurring _reoccurring;
        private int _choreType = 0;

        public EditChoreUI(Model.Concrete chore)
        {
            InitializeComponent();
            LoadChildren();
            _concrete = chore;
            choreNameTextBox.Text = _concrete.Name;
            chorePointsTextBox.Text = _concrete.Points.ToString();
            choreDescriptionRichTextBox.Text = _concrete.Description;
            foreach (var child in Model.ChildUser.Load($"c.child_id = {_concrete.Assignment}"))
            {
                childAssignedComboBox.Text = child.FirstName;
            }
            this.Controls.Add(this.dueDateLabel);
            this.Size = new Size(350, 385);
            dueDateLabel.Text = "Due date";
            this.Controls.Add(this.dueDateDateTimePicker);
            dueDateDateTimePicker.Text = _concrete.DueDate.ToString();
            _choreType = 1;
        }

        public EditChoreUI(Model.Repeatable chore)
        {
            InitializeComponent();
            LoadChildren();
            _repeatable = chore;
            choreNameTextBox.Text = _repeatable.Name;
            chorePointsTextBox.Text = _repeatable.Points.ToString();
            choreDescriptionRichTextBox.Text = _repeatable.Description;
            this.Controls.Add(this.childAssignedComboBox);
            foreach (var child in Model.ChildUser.Load($"c.child_id = {_repeatable.Assignment}"))
            {
                childAssignedComboBox.Text = child.FirstName;
            }
            this.Size = new Size(350, 385);
            this.Controls.Add(this.dueDateLabel);
            dueDateLabel.Text = "Limit";
            this.Controls.Add(this.completionLimitUpDown);
            completionLimitUpDown.Value = _repeatable.Limit;
            _choreType = 2;
        }

        public EditChoreUI(Model.Reocurring chore)
        {
            InitializeComponent();
            LoadChildren();
            _reoccurring = chore;
            choreNameTextBox.Text = _reoccurring.Name;
            chorePointsTextBox.Text = _reoccurring.Points.ToString();
            choreDescriptionRichTextBox.Text = _reoccurring.Description;
            this.Controls.Add(this.childAssignedComboBox);
            foreach (var child in Model.ChildUser.Load($"c.child_id = {_reoccurring.Assignment}"))
            {
                childAssignedComboBox.Text = child.FirstName;
            }
            this.Controls.Add(this.dueDateLabel);
            dueDateLabel.Text = "Due time";
            this.Controls.Add(this.dueTimeDateTimePicker);
            dueTimeDateTimePicker.Text = _reoccurring.DueTime.ToString();
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.daysCheckedListBox);
            this.Size = new Size(350, 525);
            for (int i = 0; i < daysCheckedListBox.Items.Count; i++)
            {
                for (int j = 0; j < _reoccurring.Days.Count; j++)
                {
                    //Reqular expression removing whitespace from string.
                    string formItem = Regex.Replace(daysCheckedListBox.Items[i].ToString(), @"\s", "");
                    string choreItem = Regex.Replace(_reoccurring.Days[j], @"\s", "");

                    bool equals = String.Equals(formItem, choreItem, StringComparison.OrdinalIgnoreCase);

                    if (equals)
                    {
                        daysCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            saveChangesButton.Location = new System.Drawing.Point(69, 440);
            _choreType = 3;
        }

        private void LoadChildren()
        {
            var children = Model.ChildUser.Load("");
            var childrenArray = new string[children.Count];
            var i = 0;
            foreach (var name in children)
            {
                childrenArray[i] = name.FirstName;
                this.childAssignedComboBox.Items.Add(childrenArray[i]);
                i++;
            }
        }

        private void CreateChoreButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            foreach (var child in Model.ChildUser.Load($"u.first_name = '{childAssignedComboBox.Text}'"))
            {
                id = child.ChildID;
            }
            if (Regex.IsMatch(choreNameTextBox.Text, @"^[ÆØÅæøåa-zA-Z\s]+$"))
            {
                try
                {
                    switch (_choreType)
                    {
                        case 1:
                            _concrete.Name = choreNameTextBox.Text;
                            _concrete.Points = Convert.ToInt32(chorePointsTextBox.Text);
                            _concrete.Description = choreDescriptionRichTextBox.Text;
                            _concrete.Assignment = id;
                            _concrete.DueDate = Convert.ToDateTime(dueDateDateTimePicker.Text);
                            _concrete.Update();
                            this.Close();
                            MessageBox.Show("The concrete chore has been updated.");
                            break;

                        case 2:
                            _repeatable.Name = choreNameTextBox.Text;
                            _repeatable.Points = Convert.ToInt32(chorePointsTextBox.Text);
                            _repeatable.Description = choreDescriptionRichTextBox.Text;
                            _repeatable.Assignment = id;
                            _repeatable.Limit = (int)completionLimitUpDown.Value;
                            _repeatable.Update();
                            this.Close();
                            MessageBox.Show("The repeatable chore has been updated.");
                            break;

                        case 3:
                            _reoccurring.Name = choreNameTextBox.Text;
                            _reoccurring.Points = Convert.ToInt32(chorePointsTextBox.Text);
                            _reoccurring.Description = choreDescriptionRichTextBox.Text;
                            _reoccurring.Assignment = id;
                            _reoccurring.DueTime = Convert.ToDateTime(dueTimeDateTimePicker.Text);
                            _reoccurring.Days = daysCheckedListBox.CheckedItems.OfType<string>().ToList<string>();
                            _reoccurring.Update();
                            this.Close();
                            MessageBox.Show("The reoccurring chore has been updated.");
                            break;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid information entered.");
                }
            }
        }
    }
}