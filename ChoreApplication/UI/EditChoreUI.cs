using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ChoreApplication.UI
{
    public partial class EditChoreUI : Form
    {
        private Concrete _concrete;
        private Repeatable _repeatable;
        private Reocurring _reoccurring;
        private int _choreType = 0;
        public EditChoreUI(Concrete chore)
        {
            InitializeComponent();
            LoadChildren();
            _concrete = chore;
            ChoreName.Text = _concrete.Name;
            ChorePoints.Text = _concrete.Points.ToString();
            ChoreDescription.Text = _concrete.Description;
            foreach (var child in ChildUser.Load($"c.child_id = {_concrete.Assignment}"))
            {
                Assignment.Text = child.FirstName;
            }
            this.Controls.Add(this.dtlLabel);
            dtlLabel.Text = "Due date";
            this.Controls.Add(this.DueDate);
            DueDate.Text = _concrete.DueDate.ToString();
            _choreType = 1;
        }
        public EditChoreUI(Repeatable chore)
        {
            InitializeComponent();
            LoadChildren();
            _repeatable = chore;
            ChoreName.Text = _repeatable.Name;
            ChorePoints.Text = _repeatable.Points.ToString();
            ChoreDescription.Text = _repeatable.Description;
            this.Controls.Add(this.Assignment);
            foreach (var child in ChildUser.Load($"c.child_id = {_repeatable.Assignment}"))
            {
                Assignment.Text = child.FirstName;
            }
            this.Controls.Add(this.dtlLabel);
            dtlLabel.Text = "Limit";
            this.Controls.Add(this.CompletionLimit);
            CompletionLimit.Value = _repeatable.Limit;
            _choreType = 2;
        }
        public EditChoreUI(Reocurring chore)
        {
            InitializeComponent();
            LoadChildren();
            _reoccurring = chore;
            ChoreName.Text = _reoccurring.Name;
            ChorePoints.Text = _reoccurring.Points.ToString();
            ChoreDescription.Text = _reoccurring.Description;
            this.Controls.Add(this.Assignment);
            foreach (var child in ChildUser.Load($"c.child_id = {_reoccurring.Assignment}"))
            {   
                    Assignment.Text = child.FirstName;
            }
            this.Controls.Add(this.dtlLabel);
            dtlLabel.Text = "Due time";
            this.Controls.Add(this.DueTime);
            DueTime.Text = _reoccurring.dueTime.ToString();
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.Days);
            for (int i = 0; i < Days.Items.Count; i++)
            {
                for (int j = 0; j < _reoccurring.days.Count; j++)
                {
                    //Reqular expression removing whitespace from string.
                    string formItem = Regex.Replace(Days.Items[i].ToString(), @"\s", "");
                    string choreItem = Regex.Replace(_reoccurring.days[j], @"\s", "");
                    
                    bool equals = String.Equals(formItem, choreItem, StringComparison.OrdinalIgnoreCase);
                    
                    if (equals)
                    {                        
                        Days.SetItemChecked(i, true);
                    }
                }
            }
            CreateChoreButton.Location = new System.Drawing.Point(174, 400);
            _choreType = 3;
        }
        private void LoadChildren()
        {
            var children = ChildUser.Load("");
            var childrenarray = new string[children.Count];
            var i = 0;
            foreach (var name in children)
            {
                childrenarray[i] = name.FirstName;
                this.Assignment.Items.Add(childrenarray[i]);
                i++;
            }
            
        }

        private void CreateChoreButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            foreach (var child in ChildUser.Load($"u.first_name = {Assignment.Text}"))
            {
                id = child.ChildId;
            }
            switch (_choreType)
            {
                case 1:
                    _concrete.Name = ChoreName.Text;
                    _concrete.Points = Convert.ToInt32(ChorePoints.Text);
                    _concrete.Description = ChoreDescription.Text;
                    _concrete.Assignment = id;
                    _concrete.DueDate = Convert.ToDateTime(DueDate.Text);
                    _concrete.Update();
                    this.Close();
                    MessageBox.Show("The concrete chore has been updated.");
                    break;
                case 2:
                    _repeatable.Update();
                    break;
                case 3:
                    _reoccurring.Update();
                    break;
            }
        }
    }
}
