﻿namespace ChoreApplication
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            this.resetDatabaseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dummyDataButton = new System.Windows.Forms.Button();
            this.applicationOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.openApplicationButton = new System.Windows.Forms.Button();
            this.checkTimeButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.applicationOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetDatabaseButton
            // 
            this.resetDatabaseButton.Location = new System.Drawing.Point(6, 19);
            this.resetDatabaseButton.Name = "resetDatabaseButton";
            this.resetDatabaseButton.Size = new System.Drawing.Size(109, 41);
            this.resetDatabaseButton.TabIndex = 0;
            this.resetDatabaseButton.Text = "Clear Database";
            this.toolTip.SetToolTip(this.resetDatabaseButton, "Clears the database, allowing you to register a completely new user if needed.");
            this.resetDatabaseButton.UseVisualStyleBackColor = true;
            this.resetDatabaseButton.Click += new System.EventHandler(this.ResetDatabaseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dummyDataButton);
            this.groupBox1.Controls.Add(this.resetDatabaseButton);
            this.groupBox1.Location = new System.Drawing.Point(18, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Options";
            // 
            // dummyDataButton
            // 
            this.dummyDataButton.Location = new System.Drawing.Point(121, 20);
            this.dummyDataButton.Name = "dummyDataButton";
            this.dummyDataButton.Size = new System.Drawing.Size(109, 41);
            this.dummyDataButton.TabIndex = 0;
            this.dummyDataButton.Text = "Insert Dummy Data";
            this.toolTip.SetToolTip(this.dummyDataButton, "Inserts dummy data into the database.\r\n\r\nEmail: test@test.dk\r\nPassword: 123456\r\nA" +
        "ll pincodes: 1234");
            this.dummyDataButton.UseVisualStyleBackColor = true;
            this.dummyDataButton.Click += new System.EventHandler(this.DummyDataButton_Click);
            // 
            // applicationOptionsGroupBox
            // 
            this.applicationOptionsGroupBox.Controls.Add(this.openApplicationButton);
            this.applicationOptionsGroupBox.Controls.Add(this.checkTimeButton);
            this.applicationOptionsGroupBox.Location = new System.Drawing.Point(18, 12);
            this.applicationOptionsGroupBox.Name = "applicationOptionsGroupBox";
            this.applicationOptionsGroupBox.Size = new System.Drawing.Size(248, 71);
            this.applicationOptionsGroupBox.TabIndex = 2;
            this.applicationOptionsGroupBox.TabStop = false;
            this.applicationOptionsGroupBox.Text = "Application Options";
            // 
            // openApplicationButton
            // 
            this.openApplicationButton.Location = new System.Drawing.Point(6, 19);
            this.openApplicationButton.Name = "openApplicationButton";
            this.openApplicationButton.Size = new System.Drawing.Size(109, 41);
            this.openApplicationButton.TabIndex = 0;
            this.openApplicationButton.Text = "Open ChoreApplication";
            this.toolTip.SetToolTip(this.openApplicationButton, "Opens the Chore Application.");
            this.openApplicationButton.UseVisualStyleBackColor = true;
            this.openApplicationButton.Click += new System.EventHandler(this.OpenApplicationButton_Click);
            // 
            // checkTimeButton
            // 
            this.checkTimeButton.Location = new System.Drawing.Point(121, 19);
            this.checkTimeButton.Name = "checkTimeButton";
            this.checkTimeButton.Size = new System.Drawing.Size(109, 41);
            this.checkTimeButton.TabIndex = 0;
            this.checkTimeButton.Text = "Test CheckTime";
            this.toolTip.SetToolTip(this.checkTimeButton, "Executes the CheckTime function.");
            this.checkTimeButton.UseVisualStyleBackColor = true;
            this.checkTimeButton.Click += new System.EventHandler(this.CheckTimeButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 166);
            this.Controls.Add(this.applicationOptionsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testing Form";
            this.groupBox1.ResumeLayout(false);
            this.applicationOptionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetDatabaseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dummyDataButton;
        private System.Windows.Forms.GroupBox applicationOptionsGroupBox;
        private System.Windows.Forms.Button openApplicationButton;
        private System.Windows.Forms.Button checkTimeButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}