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
            this.ChoreName = new System.Windows.Forms.TextBox();
            this.ChorePoints = new System.Windows.Forms.TextBox();
            this.ChoreDescription = new System.Windows.Forms.RichTextBox();
            this.ChoreTypes = new System.Windows.Forms.ComboBox();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.Assignment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.CheckedListBox();
            this.CompletionLimit = new System.Windows.Forms.NumericUpDown();
            this.DueTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CompletionLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateChoreButton
            // 
            this.CreateChoreButton.Location = new System.Drawing.Point(126, 370);
            this.CreateChoreButton.Name = "CreateChoreButton";
            this.CreateChoreButton.Size = new System.Drawing.Size(75, 23);
            this.CreateChoreButton.TabIndex = 7;
            this.CreateChoreButton.Text = "Create";
            this.CreateChoreButton.UseVisualStyleBackColor = true;
            this.CreateChoreButton.Click += new System.EventHandler(this.CreateChoreButton_Click);
            // 
            // ChoreName
            // 
            this.ChoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChoreName.Location = new System.Drawing.Point(65, 65);
            this.ChoreName.Name = "ChoreName";
            this.ChoreName.Size = new System.Drawing.Size(198, 20);
            this.ChoreName.TabIndex = 1;
            this.ChoreName.Text = "Enter chore name";
            // 
            // ChorePoints
            // 
            this.ChorePoints.Location = new System.Drawing.Point(65, 107);
            this.ChorePoints.Name = "ChorePoints";
            this.ChorePoints.Size = new System.Drawing.Size(198, 20);
            this.ChorePoints.TabIndex = 2;
            this.ChorePoints.Text = "Enter chore points";
            // 
            // ChoreDescription
            // 
            this.ChoreDescription.Location = new System.Drawing.Point(65, 150);
            this.ChoreDescription.Name = "ChoreDescription";
            this.ChoreDescription.Size = new System.Drawing.Size(198, 57);
            this.ChoreDescription.TabIndex = 3;
            this.ChoreDescription.Text = "Enter a description";
            // 
            // ChoreTypes
            // 
            this.ChoreTypes.BackColor = System.Drawing.SystemColors.Window;
            this.ChoreTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoreTypes.FormattingEnabled = true;
            this.ChoreTypes.Items.AddRange(new object[] {
            "Concrete",
            "Repeatable",
            "Reoccurring"});
            this.ChoreTypes.Location = new System.Drawing.Point(65, 225);
            this.ChoreTypes.Name = "ChoreTypes";
            this.ChoreTypes.Size = new System.Drawing.Size(198, 21);
            this.ChoreTypes.TabIndex = 4;
            this.ChoreTypes.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // DueDate
            // 
            this.DueDate.CustomFormat = "dd\'-\'MM\'-\'yyyy HH\':\'mm\':\'ss";
            this.DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DueDate.Location = new System.Drawing.Point(65, 266);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(198, 20);
            this.DueDate.TabIndex = 5;
            this.DueDate.Value = new System.DateTime(2019, 4, 20, 23, 59, 59, 0);
            // 
            // Assignment
            // 
            this.Assignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Assignment.FormattingEnabled = true;
            this.Assignment.Location = new System.Drawing.Point(65, 314);
            this.Assignment.Name = "Assignment";
            this.Assignment.Size = new System.Drawing.Size(199, 21);
            this.Assignment.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chore type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Due date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Assignment";
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(0, 0);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(120, 96);
            this.Days.TabIndex = 0;
            // 
            // CompletionLimit
            // 
            this.CompletionLimit.Location = new System.Drawing.Point(0, 0);
            this.CompletionLimit.Name = "CompletionLimit";
            this.CompletionLimit.Size = new System.Drawing.Size(120, 20);
            this.CompletionLimit.TabIndex = 0;
            // 
            // DueTime
            // 
            this.DueTime.Location = new System.Drawing.Point(0, 0);
            this.DueTime.Name = "DueTime";
            this.DueTime.Size = new System.Drawing.Size(200, 20);
            this.DueTime.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
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
            this.ClientSize = new System.Drawing.Size(337, 557);
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
            this.Text = "CreateChore";
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
    }
}