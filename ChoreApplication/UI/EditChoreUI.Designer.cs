namespace ChoreApplication.UI
{
    partial class EditChoreUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.daysLabel = new System.Windows.Forms.Label();
            this.CompletionLimit = new System.Windows.Forms.NumericUpDown();
            this.Days = new System.Windows.Forms.CheckedListBox();
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.dtlLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.DueTime = new System.Windows.Forms.DateTimePicker();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Assignment = new System.Windows.Forms.ComboBox();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.ChoreDescription = new System.Windows.Forms.RichTextBox();
            this.ChorePoints = new System.Windows.Forms.TextBox();
            this.ChoreName = new System.Windows.Forms.TextBox();
            this.CreateChoreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CompletionLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(109, 266);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(31, 13);
            this.daysLabel.TabIndex = 29;
            this.daysLabel.Text = "Days";
            // 
            // CompletionLimit
            // 
            this.CompletionLimit.Location = new System.Drawing.Point(112, 243);
            this.CompletionLimit.Name = "CompletionLimit";
            this.CompletionLimit.Size = new System.Drawing.Size(198, 20);
            this.CompletionLimit.TabIndex = 13;
            // 
            // Days
            // 
            this.Days.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.Days.Location = new System.Drawing.Point(112, 282);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(198, 109);
            this.Days.TabIndex = 14;
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Location = new System.Drawing.Point(109, 187);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(61, 13);
            this.assignmentLabel.TabIndex = 28;
            this.assignmentLabel.Text = "Assignment";
            // 
            // dtlLabel
            // 
            this.dtlLabel.AutoSize = true;
            this.dtlLabel.Location = new System.Drawing.Point(109, 227);
            this.dtlLabel.Name = "dtlLabel";
            this.dtlLabel.Size = new System.Drawing.Size(51, 13);
            this.dtlLabel.TabIndex = 27;
            this.dtlLabel.Text = "Due date";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(109, 111);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 25;
            this.descriptionLabel.Text = "Description";
            // 
            // DueTime
            // 
            this.DueTime.CustomFormat = "hh:mm";
            this.DueTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DueTime.Location = new System.Drawing.Point(112, 243);
            this.DueTime.Name = "DueTime";
            this.DueTime.ShowUpDown = true;
            this.DueTime.Size = new System.Drawing.Size(198, 20);
            this.DueTime.TabIndex = 15;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(109, 73);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(36, 13);
            this.pointsLabel.TabIndex = 23;
            this.pointsLabel.Text = "Points";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(109, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name";
            // 
            // Assignment
            // 
            this.Assignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Assignment.FormattingEnabled = true;
            this.Assignment.Location = new System.Drawing.Point(112, 203);
            this.Assignment.Name = "Assignment";
            this.Assignment.Size = new System.Drawing.Size(198, 21);
            this.Assignment.TabIndex = 22;
            // 
            // DueDate
            // 
            this.DueDate.CustomFormat = "dd\'-\'MM\'-\'yyyy HH\':\'mm\':\'ss";
            this.DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DueDate.Location = new System.Drawing.Point(112, 243);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(198, 20);
            this.DueDate.TabIndex = 20;
            this.DueDate.Value = new System.DateTime(2019, 4, 20, 23, 59, 59, 0);
            // 
            // ChoreDescription
            // 
            this.ChoreDescription.Location = new System.Drawing.Point(112, 127);
            this.ChoreDescription.MaxLength = 255;
            this.ChoreDescription.Name = "ChoreDescription";
            this.ChoreDescription.Size = new System.Drawing.Size(198, 57);
            this.ChoreDescription.TabIndex = 18;
            this.ChoreDescription.Text = "Enter a description";
            // 
            // ChorePoints
            // 
            this.ChorePoints.Location = new System.Drawing.Point(112, 88);
            this.ChorePoints.Name = "ChorePoints";
            this.ChorePoints.Size = new System.Drawing.Size(198, 20);
            this.ChorePoints.TabIndex = 17;
            this.ChorePoints.Text = "Enter chore points";
            // 
            // ChoreName
            // 
            this.ChoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChoreName.Location = new System.Drawing.Point(112, 49);
            this.ChoreName.MaxLength = 50;
            this.ChoreName.Name = "ChoreName";
            this.ChoreName.Size = new System.Drawing.Size(198, 20);
            this.ChoreName.TabIndex = 16;
            this.ChoreName.Text = "Enter chore name";
            // 
            // CreateChoreButton
            // 
            this.CreateChoreButton.Location = new System.Drawing.Point(174, 280);
            this.CreateChoreButton.Name = "CreateChoreButton";
            this.CreateChoreButton.Size = new System.Drawing.Size(75, 23);
            this.CreateChoreButton.TabIndex = 24;
            this.CreateChoreButton.Text = "Save";
            this.CreateChoreButton.UseVisualStyleBackColor = true;
            this.CreateChoreButton.Click += new System.EventHandler(this.CreateChoreButton_Click);
            // 
            // EditChoreUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 513);
            this.Controls.Add(this.assignmentLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Assignment);
            this.Controls.Add(this.ChoreDescription);
            this.Controls.Add(this.ChorePoints);
            this.Controls.Add(this.ChoreName);
            this.Controls.Add(this.CreateChoreButton);
            this.Name = "EditChoreUI";
            this.Text = "EditChoreUI";
            ((System.ComponentModel.ISupportInitialize)(this.CompletionLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.NumericUpDown CompletionLimit;
        private System.Windows.Forms.CheckedListBox Days;
        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.Label dtlLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.DateTimePicker DueTime;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox Assignment;
        private System.Windows.Forms.DateTimePicker DueDate;
        private System.Windows.Forms.RichTextBox ChoreDescription;
        private System.Windows.Forms.TextBox ChorePoints;
        private System.Windows.Forms.TextBox ChoreName;
        private System.Windows.Forms.Button CreateChoreButton;
    }
}