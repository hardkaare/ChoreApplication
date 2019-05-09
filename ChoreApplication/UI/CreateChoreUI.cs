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
            this.DueDate.MinDate = DateTime.Now;
        }

        private void ChoreType_SelectIndexChanged(object sender, EventArgs e)
        {
            switch (ChoreTypes.Text)
            {
                case "Reoccurring":
                    this.Controls.Add(this.Days);
                    Days.Visible = true;
                    label5.Text = "Days";
                    this.Controls.Add(this.DueTime);
                    DueTime.Visible = true;
                    this.Controls.Add(this.label7);
                    label7.Visible = true;
                    DueDate.Visible = false;
                    label6.Location = new System.Drawing.Point(62, 420);
                    Assignment.Location = new System.Drawing.Point(65, 440);
                    CreateChoreButton.Location = new System.Drawing.Point(65, 470);
                    this.Size = new Size(350, 550);
                    CompletionLimit.Visible = false;
                    break;

                case "Concrete":
                    DueDate.Visible = true;
                    label5.Text = "Due date";
                    Days.Visible = false;
                    CompletionLimit.Visible = false;
                    label6.Location = new System.Drawing.Point(62, 291);
                    Assignment.Location = new System.Drawing.Point(65, 310);
                    CreateChoreButton.Location = new System.Drawing.Point(65, 340);
                    this.Size = new Size(350, 420);
                    DueTime.Visible = false;
                    label7.Visible = false;
                    break;

                case "Repeatable":
                    this.Controls.Add(this.CompletionLimit);
                    label5.Text = "Completion limit";
                    DueDate.Visible = false;
                    CompletionLimit.Visible = true;
                    Days.Visible = false;
                    label6.Location = new System.Drawing.Point(62, 291);
                    Assignment.Location = new System.Drawing.Point(65, 310);
                    CreateChoreButton.Location = new System.Drawing.Point(65, 340);
                    this.Size = new Size(350, 420);
                    DueTime.Visible = false;
                    label7.Visible = false;
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
                this.Assignment.Items.Add(childrenarray[i]);
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
                if (children[i].FirstName == Assignment.Text)
                {
                    id = children[i].ChildId;
                }
            }
            if (Regex.IsMatch(ChoreName.Text, @"^[ÆØÅæøåa-zA-Z\s]+$"))
            {
                switch (ChoreTypes.Text)
                {
                    case "Concrete":
                        choreType = "conc";
                        try
                        {
                            Concrete.Insert(ChoreName.Text, ChoreDescription.Text, Convert.ToInt32(ChorePoints.Text), id, Convert.ToDateTime(DueDate.Text), choreType);
                            this.Close();
                            MessageBox.Show("A chore has been created");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Incorrect information entered");
                        }
                        break;

                    case "Repeatable":
                        choreType = "rep";
                        try
                        {
                            Repeatable.Insert(id, ChoreName.Text, ChoreDescription.Text, Convert.ToInt32(ChorePoints.Text), (Int32)CompletionLimit.Value);
                            this.Close();
                            MessageBox.Show("A chore has been created");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Incorrect information entered");
                        }
                        break;

                    case "Reoccurring":
                        choreType = "reoc";
                        try
                        {
                            List<string> DaysChecked = Days.CheckedItems.OfType<string>().ToList<string>();
                            int dayChecked = 0;
                            foreach (var day in DaysChecked)
                            {
                                dayChecked++;
                            }
                            if (dayChecked > 0)
                            {
                                Reocurring.Insert(id, ChoreName.Text, ChoreDescription.Text, Convert.ToInt32(ChorePoints.Text), Convert.ToDateTime(DueTime.Text), DaysChecked);
                                this.Close();
                                MessageBox.Show("A chore has been created");
                            }
                            else
                            {
                                MessageBox.Show("You must check at least one day.");
                            }
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Incorrect information entered");
                        }
                        finally
                        {
                            DatabaseFunctions.DbConn.Close();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Chore name cannot contain numbers.");
            }
        }
    }
}