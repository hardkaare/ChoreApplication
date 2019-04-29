using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChoreApplication.UI
{
    public partial class CreateChoreUI : Form
    {
        public CreateChoreUI()
        {
            InitializeComponent();
            LoadChildren();
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
                    label6.Location = new System.Drawing.Point(61, 379);
                    Assignment.Location = new System.Drawing.Point(64, 395);
                    CreateChoreButton.Location = new System.Drawing.Point(126, 451);
                    Days.Visible = true;
                    CompletionLimit.Visible = false;
                    this.Days.FormattingEnabled = true;
                    this.Days.Items.AddRange(new object[] {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"});
                    this.Days.Location = new System.Drawing.Point(65, 266);
                    this.Days.Name = "Days";
                    this.Days.Size = new System.Drawing.Size(198, 109);
                    this.Days.TabIndex = 12;
                    this.Controls.Add(this.Days);
                    break;
                case "Concrete":
                    DueDate.Visible = true;
                    label5.Text = "Due date";
                    Days.Visible = false;
                    CompletionLimit.Visible = false;
                    label6.Location = new System.Drawing.Point(61, 291);
                    Assignment.Location = new System.Drawing.Point(64, 307);
                    CreateChoreButton.Location = new System.Drawing.Point(126, 363);
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
                    break;
            }
        }

        private void LoadChildren()
        {
            var children = ChildUser.Load("");
            var childrenarray = new string[children.Count];
            foreach (var name in children)
            {
                var i = 0;
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

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Incorrect information enterd");
                    }
                    break;
                case "Repeatable":
                    choreType = "rep";
                    try
                    {
                        Repeatable.Insert(id, ChoreName.Text, ChoreDescription.Text, Convert.ToInt32(ChorePoints.Text), (Int32)CompletionLimit.Value);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Incorrect information enterd");
                    }
                    break;
                case "Reoccurring":
                    choreType = "reoc";
                    try
                    {
                        //lav en liste med strings med l

                       //Reocurring.Insert(id, ChoreName.Text, ChoreDescription, Convert.ToInt32(ChorePoints.Text), Convert.ToDateTime(DueDate.Text),)

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Incorrect information enterd");
                    }
                    break;
            }
           
        }
    }
}
