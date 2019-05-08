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
            this.CreateChoreButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Assignment = new System.Windows.Forms.ComboBox();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.ChoreTypes = new System.Windows.Forms.ComboBox();
            this.ChoreDescription = new System.Windows.Forms.RichTextBox();
            this.ChorePoints = new System.Windows.Forms.TextBox();
            this.ChoreName = new System.Windows.Forms.TextBox();
            this.Days = new System.Windows.Forms.CheckedListBox();
            this.CompletionLimit = new System.Windows.Forms.NumericUpDown();
            this.DueTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CompletionLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateChoreButton
            // 
            this.CreateChoreButton.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.CreateChoreButton.Location = new System.Drawing.Point(65, 340);
            this.CreateChoreButton.Name = "CreateChoreButton";
            this.CreateChoreButton.Size = new System.Drawing.Size(200, 25);
            this.CreateChoreButton.TabIndex = 14;
            this.CreateChoreButton.Text = "Create";
            this.CreateChoreButton.UseVisualStyleBackColor = true;
            this.CreateChoreButton.Click += new System.EventHandler(this.CreateChoreButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(313, 24);
            this.WelcomeLabel.TabIndex = 15;
            this.WelcomeLabel.Text = "Create Chore";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label6.Location = new System.Drawing.Point(62, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Assignment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label5.Location = new System.Drawing.Point(62, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Due date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label4.Location = new System.Drawing.Point(62, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chore type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label3.Location = new System.Drawing.Point(62, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label2.Location = new System.Drawing.Point(62, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // Assignment
            // 
            this.Assignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Assignment.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.Assignment.FormattingEnabled = true;
            this.Assignment.Location = new System.Drawing.Point(65, 310);
            this.Assignment.Name = "Assignment";
            this.Assignment.Size = new System.Drawing.Size(200, 24);
            this.Assignment.TabIndex = 13;
            // 
            // DueDate
            // 
            this.DueDate.CustomFormat = global::ChoreApplication.Properties.Settings.Default.LongDateFormat;
            this.DueDate.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DueDate.Location = new System.Drawing.Point(65, 266);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(200, 22);
            this.DueDate.TabIndex = 5;
            this.DueDate.Value = new System.DateTime(2019, 4, 20, 23, 59, 59, 0);
            // 
            // ChoreTypes
            // 
            this.ChoreTypes.BackColor = System.Drawing.SystemColors.Window;
            this.ChoreTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoreTypes.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.ChoreTypes.FormattingEnabled = true;
            this.ChoreTypes.Items.AddRange(new object[] {
            "Concrete",
            "Repeatable",
            "Reoccurring"});
            this.ChoreTypes.Location = new System.Drawing.Point(65, 223);
            this.ChoreTypes.Name = "ChoreTypes";
            this.ChoreTypes.Size = new System.Drawing.Size(200, 24);
            this.ChoreTypes.TabIndex = 4;
            this.ChoreTypes.SelectedIndexChanged += new System.EventHandler(this.ChoreType_SelectIndexChanged);
            // 
            // ChoreDescription
            // 
            this.ChoreDescription.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.ChoreDescription.Location = new System.Drawing.Point(65, 147);
            this.ChoreDescription.MaxLength = 255;
            this.ChoreDescription.Name = "ChoreDescription";
            this.ChoreDescription.Size = new System.Drawing.Size(200, 57);
            this.ChoreDescription.TabIndex = 3;
            this.ChoreDescription.Text = "Enter a description";
            // 
            // ChorePoints
            // 
            this.ChorePoints.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.ChorePoints.Location = new System.Drawing.Point(65, 106);
            this.ChorePoints.Name = "ChorePoints";
            this.ChorePoints.Size = new System.Drawing.Size(200, 22);
            this.ChorePoints.TabIndex = 2;
            this.ChorePoints.Text = "Enter chore points";
            // 
            // ChoreName
            // 
            this.ChoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChoreName.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.ChoreName.Location = new System.Drawing.Point(65, 65);
            this.ChoreName.MaxLength = 50;
            this.ChoreName.Name = "ChoreName";
            this.ChoreName.Size = new System.Drawing.Size(200, 22);
            this.ChoreName.TabIndex = 1;
            this.ChoreName.Text = "Enter chore name";
            // 
            // Days
            // 
            this.Days.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.Days.FormattingEnabled = true;
            this.Days.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.Days.Location = new System.Drawing.Point(65, 266);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(200, 72);
            this.Days.TabIndex = 12;
            // 
            // CompletionLimit
            // 
            this.CompletionLimit.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.CompletionLimit.Location = new System.Drawing.Point(64, 266);
            this.CompletionLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CompletionLimit.Name = "CompletionLimit";
            this.CompletionLimit.Size = new System.Drawing.Size(200, 22);
            this.CompletionLimit.TabIndex = 12;
            this.CompletionLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DueTime
            // 
            this.DueTime.CustomFormat = "HH:mm";
            this.DueTime.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.DueTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DueTime.Location = new System.Drawing.Point(63, 395);
            this.DueTime.Name = "DueTime";
            this.DueTime.ShowUpDown = true;
            this.DueTime.Size = new System.Drawing.Size(200, 22);
            this.DueTime.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label7.Location = new System.Drawing.Point(64, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Due time";
            // 
            // CreateChoreUI
            // 
            this.AcceptButton = this.CreateChoreButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 381);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Assignment);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.ChoreTypes);
            this.Controls.Add(this.ChoreDescription);
            this.Controls.Add(this.ChorePoints);
            this.Controls.Add(this.ChoreName);
            this.Controls.Add(this.CreateChoreButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateChoreUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Chore";
            ((System.ComponentModel.ISupportInitialize)(this.CompletionLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateChoreButton;
        private System.Windows.Forms.TextBox ChoreName;
        private System.Windows.Forms.TextBox ChorePoints;
        private System.Windows.Forms.RichTextBox ChoreDescription;
        private System.Windows.Forms.ComboBox ChoreTypes;
        private System.Windows.Forms.DateTimePicker DueDate;
        private System.Windows.Forms.ComboBox Assignment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox Days;
        private System.Windows.Forms.NumericUpDown CompletionLimit;
        private System.Windows.Forms.DateTimePicker DueTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}