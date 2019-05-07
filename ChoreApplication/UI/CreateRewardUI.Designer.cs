﻿namespace ChoreApplication.UI
{
    partial class CreateRewardUI
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
            this.rewardName = new System.Windows.Forms.TextBox();
            this.rewardNameLabel = new System.Windows.Forms.Label();
            this.rewardDescriptionLabel = new System.Windows.Forms.Label();
            this.pointsRequiredLabel = new System.Windows.Forms.Label();
            this.pointsRequired = new System.Windows.Forms.NumericUpDown();
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.assignment = new System.Windows.Forms.ComboBox();
            this.createReward = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pointsRequired)).BeginInit();
            this.SuspendLayout();
            // 
            // rewardName
            // 
            this.rewardName.Location = new System.Drawing.Point(70, 58);
            this.rewardName.Name = "rewardName";
            this.rewardName.Size = new System.Drawing.Size(200, 20);
            this.rewardName.TabIndex = 1;
            // 
            // rewardNameLabel
            // 
            this.rewardNameLabel.AutoSize = true;
            this.rewardNameLabel.Location = new System.Drawing.Point(68, 42);
            this.rewardNameLabel.Name = "rewardNameLabel";
            this.rewardNameLabel.Size = new System.Drawing.Size(73, 13);
            this.rewardNameLabel.TabIndex = 0;
            this.rewardNameLabel.Text = "Reward name";
            // 
            // rewardDescriptionLabel
            // 
            this.rewardDescriptionLabel.AutoSize = true;
            this.rewardDescriptionLabel.Location = new System.Drawing.Point(67, 81);
            this.rewardDescriptionLabel.Name = "rewardDescriptionLabel";
            this.rewardDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.rewardDescriptionLabel.TabIndex = 0;
            this.rewardDescriptionLabel.Text = "Description";
            // 
            // pointsRequiredLabel
            // 
            this.pointsRequiredLabel.AutoSize = true;
            this.pointsRequiredLabel.Location = new System.Drawing.Point(67, 200);
            this.pointsRequiredLabel.Name = "pointsRequiredLabel";
            this.pointsRequiredLabel.Size = new System.Drawing.Size(77, 13);
            this.pointsRequiredLabel.TabIndex = 0;
            this.pointsRequiredLabel.Text = "Points required";
            // 
            // pointsRequired
            // 
            this.pointsRequired.Location = new System.Drawing.Point(69, 216);
            this.pointsRequired.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointsRequired.Name = "pointsRequired";
            this.pointsRequired.Size = new System.Drawing.Size(200, 20);
            this.pointsRequired.TabIndex = 3;
            this.pointsRequired.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Location = new System.Drawing.Point(67, 239);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(61, 13);
            this.assignmentLabel.TabIndex = 0;
            this.assignmentLabel.Text = "Assignment";
            // 
            // assignment
            // 
            this.assignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignment.FormattingEnabled = true;
            this.assignment.Location = new System.Drawing.Point(69, 255);
            this.assignment.Name = "assignment";
            this.assignment.Size = new System.Drawing.Size(200, 21);
            this.assignment.TabIndex = 4;
            // 
            // createReward
            // 
            this.createReward.Location = new System.Drawing.Point(69, 282);
            this.createReward.Name = "createReward";
            this.createReward.Size = new System.Drawing.Size(200, 25);
            this.createReward.TabIndex = 5;
            this.createReward.Text = "Create reward";
            this.createReward.UseVisualStyleBackColor = true;
            this.createReward.Click += new System.EventHandler(this.CreateReward_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(69, 97);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(200, 100);
            this.description.TabIndex = 2;
            this.description.Text = "";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(310, 24);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "Create Reward";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateRewardUI
            // 
            this.AcceptButton = this.createReward;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 321);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.createReward);
            this.Controls.Add(this.assignment);
            this.Controls.Add(this.assignmentLabel);
            this.Controls.Add(this.pointsRequired);
            this.Controls.Add(this.pointsRequiredLabel);
            this.Controls.Add(this.rewardDescriptionLabel);
            this.Controls.Add(this.rewardNameLabel);
            this.Controls.Add(this.rewardName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateRewardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Reward";
            ((System.ComponentModel.ISupportInitialize)(this.pointsRequired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rewardName;
        private System.Windows.Forms.Label rewardNameLabel;
        private System.Windows.Forms.Label rewardDescriptionLabel;
        private System.Windows.Forms.Label pointsRequiredLabel;
        private System.Windows.Forms.NumericUpDown pointsRequired;
        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.ComboBox assignment;
        private System.Windows.Forms.Button createReward;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}