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
            this.completionLimitUpDown = new System.Windows.Forms.NumericUpDown();
            this.daysCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.dueTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.childAssignedComboBox = new System.Windows.Forms.ComboBox();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.choreDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.chorePointsTextBox = new System.Windows.Forms.TextBox();
            this.choreNameTextBox = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.completionLimitUpDown)).BeginInit();
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
            // completionLimitUpDown
            // 
            this.completionLimitUpDown.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.completionLimitUpDown.Location = new System.Drawing.Point(70, 284);
            this.completionLimitUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.completionLimitUpDown.Name = "completionLimitUpDown";
            this.completionLimitUpDown.Size = new System.Drawing.Size(198, 22);
            this.completionLimitUpDown.TabIndex = 13;
            this.completionLimitUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // daysCheckedListBox
            // 
            this.daysCheckedListBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.daysCheckedListBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.daysCheckedListBox.Location = new System.Drawing.Point(69, 326);
            this.daysCheckedListBox.Name = "daysCheckedListBox";
            this.daysCheckedListBox.Size = new System.Drawing.Size(198, 106);
            this.daysCheckedListBox.TabIndex = 10;
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
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.dueDateLabel.Location = new System.Drawing.Point(70, 265);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(63, 16);
            this.dueDateLabel.TabIndex = 27;
            this.dueDateLabel.Text = "Due date";
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
            // dueTimeDateTimePicker
            // 
            this.dueTimeDateTimePicker.CustomFormat = "hh:mm";
            this.dueTimeDateTimePicker.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.dueTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueTimeDateTimePicker.Location = new System.Drawing.Point(70, 284);
            this.dueTimeDateTimePicker.Name = "dueTimeDateTimePicker";
            this.dueTimeDateTimePicker.ShowUpDown = true;
            this.dueTimeDateTimePicker.Size = new System.Drawing.Size(198, 22);
            this.dueTimeDateTimePicker.TabIndex = 9;
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
            // childAssignedComboBox
            // 
            this.childAssignedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.childAssignedComboBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.childAssignedComboBox.FormattingEnabled = true;
            this.childAssignedComboBox.Location = new System.Drawing.Point(70, 238);
            this.childAssignedComboBox.Name = "childAssignedComboBox";
            this.childAssignedComboBox.Size = new System.Drawing.Size(198, 24);
            this.childAssignedComboBox.TabIndex = 4;
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.CustomFormat = "dd\'-\'MM\'-\'yyyy HH\':\'mm\':\'ss";
            this.dueDateDateTimePicker.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.dueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(70, 284);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(198, 22);
            this.dueDateDateTimePicker.TabIndex = 13;
            this.dueDateDateTimePicker.Value = new System.DateTime(2019, 4, 20, 23, 59, 59, 0);
            // 
            // choreDescriptionRichTextBox
            // 
            this.choreDescriptionRichTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.choreDescriptionRichTextBox.Location = new System.Drawing.Point(70, 159);
            this.choreDescriptionRichTextBox.MaxLength = 255;
            this.choreDescriptionRichTextBox.Name = "choreDescriptionRichTextBox";
            this.choreDescriptionRichTextBox.Size = new System.Drawing.Size(198, 57);
            this.choreDescriptionRichTextBox.TabIndex = 3;
            this.choreDescriptionRichTextBox.Text = "Enter a description";
            // 
            // chorePointsTextBox
            // 
            this.chorePointsTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.chorePointsTextBox.Location = new System.Drawing.Point(70, 115);
            this.chorePointsTextBox.MaxLength = 50;
            this.chorePointsTextBox.Name = "chorePointsTextBox";
            this.chorePointsTextBox.Size = new System.Drawing.Size(198, 22);
            this.chorePointsTextBox.TabIndex = 2;
            this.chorePointsTextBox.Text = "Enter chore points";
            // 
            // choreNameTextBox
            // 
            this.choreNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choreNameTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.choreNameTextBox.Location = new System.Drawing.Point(70, 71);
            this.choreNameTextBox.MaxLength = 50;
            this.choreNameTextBox.Name = "choreNameTextBox";
            this.choreNameTextBox.Size = new System.Drawing.Size(198, 22);
            this.choreNameTextBox.TabIndex = 1;
            this.choreNameTextBox.Text = "Enter chore name";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.saveChangesButton.Location = new System.Drawing.Point(69, 310);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(199, 30);
            this.saveChangesButton.TabIndex = 15;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.CreateChoreButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(310, 24);
            this.welcomeLabel.TabIndex = 30;
            this.welcomeLabel.Text = "Edit Chore";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditChoreUI
            // 
            this.AcceptButton = this.saveChangesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 346);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.assignmentLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.choreDescriptionRichTextBox);
            this.Controls.Add(this.chorePointsTextBox);
            this.Controls.Add(this.choreNameTextBox);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.childAssignedComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditChoreUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Chore";
            ((System.ComponentModel.ISupportInitialize)(this.completionLimitUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.NumericUpDown completionLimitUpDown;
        private System.Windows.Forms.CheckedListBox daysCheckedListBox;
        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.DateTimePicker dueTimeDateTimePicker;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox childAssignedComboBox;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private System.Windows.Forms.RichTextBox choreDescriptionRichTextBox;
        private System.Windows.Forms.TextBox chorePointsTextBox;
        private System.Windows.Forms.TextBox choreNameTextBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Label welcomeLabel;
    }
}