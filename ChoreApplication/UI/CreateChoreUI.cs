using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



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
       

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChoreTypes.Text)
            {
                case "Reoccurring":
                    // 
                    // Days
                    // 
                    label5.Text = "Days";
                    DueDate.Visible = false;
                    label6.Location = new System.Drawing.Point(61, 420);
                    Assignment.Location = new System.Drawing.Point(64, 435);
                    CreateChoreButton.Location = new System.Drawing.Point(126, 470);
                    Days.Visible = true;
                    CompletionLimit.Visible = false;
                    this.Days.FormattingEnabled = true;
                    this.Days.Items.AddRange(new object[] {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"});
                    this.Days.Location = new System.Drawing.Point(65, 266);
                    this.Days.Name = "Days";
                    this.Days.Size = new System.Drawing.Size(200, 109);
                    this.Days.TabIndex = 12;
                    this.Controls.Add(this.Days);
                    // 
                    // DueTime
                    // 
                    this.DueTime.CustomFormat = "HH:mm";
                    this.DueTime.ShowUpDown = true;
                    this.DueTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                    this.DueTime.Location = new System.Drawing.Point(63, 395);
                    this.DueTime.Name = "DueTime";
                    this.DueTime.Size = new System.Drawing.Size(200, 20);
                    this.DueTime.TabIndex = 12;
                    this.Controls.Add(this.DueTime);
                    DueTime.Visible = true;
                    this.Controls.Add(this.label7);
                    label7.Visible = true;
                    break;
                case "Concrete":
                    DueDate.Visible = true;
                    label5.Text = "Due date";
                    Days.Visible = false;
                    CompletionLimit.Visible = false;
                    label6.Location = new System.Drawing.Point(61, 291);
                    Assignment.Location = new System.Drawing.Point(64, 307);
                    CreateChoreButton.Location = new System.Drawing.Point(126, 363);
                    DueTime.Visible = false;
                    label7.Visible = false;
                    break;
                case "Repeatable":
                    // 
                    // CompletionLimit
                    // 
                    label5.Text = "Completion limit";
                    DueDate.Visible = false;
                    CompletionLimit.Visible = true;
                    Days.Visible = false;
                    label6.Location = new System.Drawing.Point(61, 291);
                    Assignment.Location = new System.Drawing.Point(64, 307);
                    CreateChoreButton.Location = new System.Drawing.Point(126, 363);
                    this.Controls.Add(this.CompletionLimit);
                    this.CompletionLimit.Location = new System.Drawing.Point(64, 266);
                    this.CompletionLimit.Name = "CompletionLimit";
                    this.CompletionLimit.Size = new System.Drawing.Size(198, 20);
                    this.CompletionLimit.TabIndex = 12;
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
                if(children[i].FirstName == Assignment.Text)
                {
                    id = children[i].ChildId;
                }
            }
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
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
                        Reocurring.Insert(id, ChoreName.Text, ChoreDescription.Text, Convert.ToInt32(ChorePoints.Text), Convert.ToDateTime(DueTime.Text), DaysChecked);
                        this.Close();
                        MessageBox.Show("A chore has been created");
                    }
                    catch (SqlException)
                    {                       
                        MessageBox.Show("Incorrect information entered");
                    }
                    finally
                    {
                        DatabaseFunctions.dbConn.Close();
                    }
                    break;
            }
            
        }
    }
}
