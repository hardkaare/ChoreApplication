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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CompletionLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.daysLabel.Location = new System.Drawing.Point(69, 310);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(40, 16);
            this.daysLabel.TabIndex = 29;
            this.daysLabel.Text = "Days";
            // 
            // CompletionLimit
            // 
            this.CompletionLimit.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.CompletionLimit.Location = new System.Drawing.Point(70, 284);
            this.CompletionLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CompletionLimit.Name = "CompletionLimit";
            this.CompletionLimit.Size = new System.Drawing.Size(198, 22);
            this.CompletionLimit.TabIndex = 13;
            this.CompletionLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Days
            // 
            this.Days.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.Days.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.Days.Location = new System.Drawing.Point(69, 326);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(198, 106);
            this.Days.TabIndex = 10;
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.assignmentLabel.Location = new System.Drawing.Point(70, 219);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(110, 16);
            this.assignmentLabel.TabIndex = 0;
            this.assignmentLabel.Text = "Assignment";
            // 
            // dtlLabel
            // 
            this.dtlLabel.AutoSize = true;
            this.dtlLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.dtlLabel.Location = new System.Drawing.Point(70, 265);
            this.dtlLabel.Name = "dtlLabel";
            this.dtlLabel.Size = new System.Drawing.Size(63, 16);
            this.dtlLabel.TabIndex = 27;
            this.dtlLabel.Text = "Due date";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.descriptionLabel.Location = new System.Drawing.Point(70, 140);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(76, 16);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // DueTime
            // 
            this.DueTime.CustomFormat = "hh:mm";
            this.DueTime.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.DueTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DueTime.Location = new System.Drawing.Point(70, 284);
            this.DueTime.Name = "DueTime";
            this.DueTime.ShowUpDown = true;
            this.DueTime.Size = new System.Drawing.Size(198, 22);
            this.DueTime.TabIndex = 9;
            // 
            // pointsLabel
            // 
            this.pointsLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.pointsLabel.Location = new System.Drawing.Point(70, 96);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(45, 16);
            this.pointsLabel.TabIndex = 0;
            this.pointsLabel.Text = "Points";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.nameLabel.Location = new System.Drawing.Point(70, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // Assignment
            // 
            this.Assignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Assignment.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.Assignment.FormattingEnabled = true;
            this.Assignment.Location = new System.Drawing.Point(70, 238);
            this.Assignment.Name = "Assignment";
            this.Assignment.Size = new System.Drawing.Size(198, 24);
            this.Assignment.TabIndex = 4;
            // 
            // DueDate
            // 
            this.DueDate.CustomFormat = "dd\'-\'MM\'-\'yyyy HH\':\'mm\':\'ss";
            this.DueDate.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DueDate.Location = new System.Drawing.Point(70, 284);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(198, 22);
            this.DueDate.TabIndex = 13;
            this.DueDate.Value = new System.DateTime(2019, 4, 20, 23, 59, 59, 0);
            // 
            // ChoreDescription
            // 
            this.ChoreDescription.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.ChoreDescription.Location = new System.Drawing.Point(70, 159);
            this.ChoreDescription.MaxLength = 255;
            this.ChoreDescription.Name = "ChoreDescription";
            this.ChoreDescription.Size = new System.Drawing.Size(198, 57);
            this.ChoreDescription.TabIndex = 3;
            this.ChoreDescription.Text = "Enter a description";
            // 
            // ChorePoints
            // 
            this.ChorePoints.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.ChorePoints.Location = new System.Drawing.Point(70, 115);
            this.ChorePoints.Name = "ChorePoints";
            this.ChorePoints.Size = new System.Drawing.Size(198, 22);
            this.ChorePoints.TabIndex = 2;
            this.ChorePoints.Text = "Enter chore points";
            // 
            // ChoreName
            // 
            this.ChoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChoreName.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.ChoreName.Location = new System.Drawing.Point(70, 71);
            this.ChoreName.MaxLength = 50;
            this.ChoreName.Name = "ChoreName";
            this.ChoreName.Size = new System.Drawing.Size(198, 22);
            this.ChoreName.TabIndex = 1;
            this.ChoreName.Text = "Enter chore name";
            // 
            // CreateChoreButton
            // 
            this.CreateChoreButton.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.CreateChoreButton.Location = new System.Drawing.Point(69, 310);
            this.CreateChoreButton.Name = "CreateChoreButton";
            this.CreateChoreButton.Size = new System.Drawing.Size(199, 30);
            this.CreateChoreButton.TabIndex = 15;
            this.CreateChoreButton.Text = "Save Changes";
            this.CreateChoreButton.UseVisualStyleBackColor = true;
            this.CreateChoreButton.Click += new System.EventHandler(this.CreateChoreButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(310, 24);
            this.WelcomeLabel.TabIndex = 30;
            this.WelcomeLabel.Text = "Edit Chore";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditChoreUI
            // 
            this.AcceptButton = this.CreateChoreButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 346);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.assignmentLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.ChoreDescription);
            this.Controls.Add(this.ChorePoints);
            this.Controls.Add(this.ChoreName);
            this.Controls.Add(this.CreateChoreButton);
            this.Controls.Add(this.Assignment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditChoreUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Chore";
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
        private System.Windows.Forms.Label WelcomeLabel;
    }
}