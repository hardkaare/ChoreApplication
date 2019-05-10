using System.Globalization;
namespace ChoreApplication.UI

{
    partial class CreateChoreUI
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
            this.createChoreButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.choreTypeLabel = new System.Windows.Forms.Label();
            this.choreDescriptionLabel = new System.Windows.Forms.Label();
            this.chorePointsLabel = new System.Windows.Forms.Label();
            this.choreNameLabel = new System.Windows.Forms.Label();
            this.childAssignedCombobox = new System.Windows.Forms.ComboBox();
            this.dueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.choreTypesComboBox = new System.Windows.Forms.ComboBox();
            this.choreDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.chorePointsTextBox = new System.Windows.Forms.TextBox();
            this.choreNameTextBox = new System.Windows.Forms.TextBox();
            this.daysCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.completionsLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dueTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dueTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.completionsLimitNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // createChoreButton
            // 
            this.createChoreButton.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.createChoreButton.Location = new System.Drawing.Point(65, 340);
            this.createChoreButton.Name = "createChoreButton";
            this.createChoreButton.Size = new System.Drawing.Size(200, 25);
            this.createChoreButton.TabIndex = 14;
            this.createChoreButton.Text = "Create";
            this.createChoreButton.UseVisualStyleBackColor = true;
            this.createChoreButton.Click += new System.EventHandler(this.CreateChoreButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(313, 24);
            this.welcomeLabel.TabIndex = 15;
            this.welcomeLabel.Text = "Create Chore";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.assignmentLabel.Location = new System.Drawing.Point(62, 291);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(78, 16);
            this.assignmentLabel.TabIndex = 11;
            this.assignmentLabel.Text = "Assignment";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.dueDateLabel.Location = new System.Drawing.Point(62, 250);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(63, 16);
            this.dueDateLabel.TabIndex = 10;
            this.dueDateLabel.Text = "Due date";
            // 
            // choreTypeLabel
            // 
            this.choreTypeLabel.AutoSize = true;
            this.choreTypeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.choreTypeLabel.Location = new System.Drawing.Point(62, 207);
            this.choreTypeLabel.Name = "choreTypeLabel";
            this.choreTypeLabel.Size = new System.Drawing.Size(73, 16);
            this.choreTypeLabel.TabIndex = 9;
            this.choreTypeLabel.Text = "Chore type";
            // 
            // choreDescriptionLabel
            // 
            this.choreDescriptionLabel.AutoSize = true;
            this.choreDescriptionLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.choreDescriptionLabel.Location = new System.Drawing.Point(62, 131);
            this.choreDescriptionLabel.Name = "choreDescriptionLabel";
            this.choreDescriptionLabel.Size = new System.Drawing.Size(76, 16);
            this.choreDescriptionLabel.TabIndex = 8;
            this.choreDescriptionLabel.Text = "Description";
            // 
            // chorePointsLabel
            // 
            this.chorePointsLabel.AutoSize = true;
            this.chorePointsLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.chorePointsLabel.Location = new System.Drawing.Point(62, 90);
            this.chorePointsLabel.Name = "chorePointsLabel";
            this.chorePointsLabel.Size = new System.Drawing.Size(45, 16);
            this.chorePointsLabel.TabIndex = 7;
            this.chorePointsLabel.Text = "Points";
            // 
            // choreNameLabel
            // 
            this.choreNameLabel.AutoSize = true;
            this.choreNameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.choreNameLabel.Location = new System.Drawing.Point(62, 49);
            this.choreNameLabel.Name = "choreNameLabel";
            this.choreNameLabel.Size = new System.Drawing.Size(45, 16);
            this.choreNameLabel.TabIndex = 6;
            this.choreNameLabel.Text = "Name";
            // 
            // childAssignedCombobox
            // 
            this.childAssignedCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.childAssignedCombobox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.childAssignedCombobox.FormattingEnabled = true;
            this.childAssignedCombobox.Location = new System.Drawing.Point(65, 310);
            this.childAssignedCombobox.Name = "childAssignedCombobox";
            this.childAssignedCombobox.Size = new System.Drawing.Size(200, 24);
            this.childAssignedCombobox.TabIndex = 13;
            // 
            // dueDateTimePicker
            // 
            this.dueDateTimePicker.CustomFormat = global::ChoreApplication.Properties.Settings.Default.LongDateFormat;
            this.dueDateTimePicker.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.dueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueDateTimePicker.Location = new System.Drawing.Point(65, 266);
            this.dueDateTimePicker.Name = "dueDateTimePicker";
            this.dueDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dueDateTimePicker.TabIndex = 5;
            this.dueDateTimePicker.Value = new System.DateTime(2019, 4, 20, 23, 59, 59, 0);
            // 
            // choreTypesComboBox
            // 
            this.choreTypesComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.choreTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choreTypesComboBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.choreTypesComboBox.FormattingEnabled = true;
            this.choreTypesComboBox.Items.AddRange(new object[] {
            "Concrete",
            "Repeatable",
            "Reoccurring"});
            this.choreTypesComboBox.Location = new System.Drawing.Point(65, 223);
            this.choreTypesComboBox.Name = "choreTypesComboBox";
            this.choreTypesComboBox.Size = new System.Drawing.Size(200, 24);
            this.choreTypesComboBox.TabIndex = 4;
            this.choreTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.ChoreType_SelectIndexChanged);
            // 
            // choreDescriptionRichTextBox
            // 
            this.choreDescriptionRichTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.choreDescriptionRichTextBox.Location = new System.Drawing.Point(65, 147);
            this.choreDescriptionRichTextBox.MaxLength = 255;
            this.choreDescriptionRichTextBox.Name = "choreDescriptionRichTextBox";
            this.choreDescriptionRichTextBox.Size = new System.Drawing.Size(200, 57);
            this.choreDescriptionRichTextBox.TabIndex = 3;
            this.choreDescriptionRichTextBox.Text = "Enter a description";
            // 
            // chorePointsTextBox
            // 
            this.chorePointsTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.chorePointsTextBox.Location = new System.Drawing.Point(65, 106);
            this.chorePointsTextBox.Name = "chorePointsTextBox";
            this.chorePointsTextBox.Size = new System.Drawing.Size(200, 22);
            this.chorePointsTextBox.TabIndex = 2;
            this.chorePointsTextBox.Text = "Enter chore points";
            // 
            // choreNameTextBox
            // 
            this.choreNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choreNameTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.choreNameTextBox.Location = new System.Drawing.Point(65, 65);
            this.choreNameTextBox.MaxLength = 50;
            this.choreNameTextBox.Name = "choreNameTextBox";
            this.choreNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.choreNameTextBox.TabIndex = 1;
            this.choreNameTextBox.Text = "Enter chore name";
            // 
            // daysCheckedListBox
            // 
            this.daysCheckedListBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.daysCheckedListBox.FormattingEnabled = true;
            this.daysCheckedListBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.daysCheckedListBox.Location = new System.Drawing.Point(65, 266);
            this.daysCheckedListBox.Name = "daysCheckedListBox";
            this.daysCheckedListBox.Size = new System.Drawing.Size(200, 72);
            this.daysCheckedListBox.TabIndex = 12;
            // 
            // completionsLimitNumericUpDown
            // 
            this.completionsLimitNumericUpDown.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.completionsLimitNumericUpDown.Location = new System.Drawing.Point(64, 266);
            this.completionsLimitNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.completionsLimitNumericUpDown.Name = "completionsLimitNumericUpDown";
            this.completionsLimitNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.completionsLimitNumericUpDown.TabIndex = 12;
            this.completionsLimitNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dueTimeDateTimePicker
            // 
            this.dueTimeDateTimePicker.CustomFormat = "HH:mm";
            this.dueTimeDateTimePicker.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.dueTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueTimeDateTimePicker.Location = new System.Drawing.Point(63, 395);
            this.dueTimeDateTimePicker.Name = "dueTimeDateTimePicker";
            this.dueTimeDateTimePicker.ShowUpDown = true;
            this.dueTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dueTimeDateTimePicker.TabIndex = 12;
            // 
            // dueTimeLabel
            // 
            this.dueTimeLabel.AutoSize = true;
            this.dueTimeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.dueTimeLabel.Location = new System.Drawing.Point(64, 380);
            this.dueTimeLabel.Name = "dueTimeLabel";
            this.dueTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.dueTimeLabel.TabIndex = 12;
            this.dueTimeLabel.Text = "Due time";
            // 
            // CreateChoreUI
            // 
            this.AcceptButton = this.createChoreButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 381);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.assignmentLabel);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.choreTypeLabel);
            this.Controls.Add(this.choreDescriptionLabel);
            this.Controls.Add(this.chorePointsLabel);
            this.Controls.Add(this.choreNameLabel);
            this.Controls.Add(this.childAssignedCombobox);
            this.Controls.Add(this.dueDateTimePicker);
            this.Controls.Add(this.choreTypesComboBox);
            this.Controls.Add(this.choreDescriptionRichTextBox);
            this.Controls.Add(this.chorePointsTextBox);
            this.Controls.Add(this.choreNameTextBox);
            this.Controls.Add(this.createChoreButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateChoreUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Chore";
            ((System.ComponentModel.ISupportInitialize)(this.completionsLimitNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createChoreButton;
        private System.Windows.Forms.TextBox choreNameTextBox;
        private System.Windows.Forms.TextBox chorePointsTextBox;
        private System.Windows.Forms.RichTextBox choreDescriptionRichTextBox;
        private System.Windows.Forms.ComboBox choreTypesComboBox;
        private System.Windows.Forms.DateTimePicker dueDateTimePicker;
        private System.Windows.Forms.ComboBox childAssignedCombobox;
        private System.Windows.Forms.Label choreNameLabel;
        private System.Windows.Forms.Label chorePointsLabel;
        private System.Windows.Forms.Label choreDescriptionLabel;
        private System.Windows.Forms.Label choreTypeLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.CheckedListBox daysCheckedListBox;
        private System.Windows.Forms.NumericUpDown completionsLimitNumericUpDown;
        private System.Windows.Forms.DateTimePicker dueTimeDateTimePicker;
        private System.Windows.Forms.Label dueTimeLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}