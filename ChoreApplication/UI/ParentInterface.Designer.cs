﻿namespace ChoreApplication.UI
{
    partial class ParentInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentInterface));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.leaderboardsLabel = new System.Windows.Forms.Label();
            this.rewardsLabel = new System.Windows.Forms.Label();
            this.choresLabel = new System.Windows.Forms.Label();
            this.choreNavButton = new System.Windows.Forms.Button();
            this.notificationsNavButton = new System.Windows.Forms.Button();
            this.usersNavButton = new System.Windows.Forms.Button();
            this.leadboardNavButton = new System.Windows.Forms.Button();
            this.rewardNavButton = new System.Windows.Forms.Button();
            this.OptionButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.UserButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.ChorePanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            this.upperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigationPanel.Controls.Add(this.notificationsLabel);
            this.navigationPanel.Controls.Add(this.usersLabel);
            this.navigationPanel.Controls.Add(this.leaderboardsLabel);
            this.navigationPanel.Controls.Add(this.rewardsLabel);
            this.navigationPanel.Controls.Add(this.choresLabel);
            this.navigationPanel.Controls.Add(this.choreNavButton);
            this.navigationPanel.Controls.Add(this.notificationsNavButton);
            this.navigationPanel.Controls.Add(this.usersNavButton);
            this.navigationPanel.Controls.Add(this.leadboardNavButton);
            this.navigationPanel.Controls.Add(this.rewardNavButton);
            this.navigationPanel.Location = new System.Drawing.Point(12, 469);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(420, 79);
            this.navigationPanel.TabIndex = 0;
            // 
            // notificationsLabel
            // 
            this.notificationsLabel.AutoSize = true;
            this.notificationsLabel.Location = new System.Drawing.Point(342, 51);
            this.notificationsLabel.Name = "notificationsLabel";
            this.notificationsLabel.Size = new System.Drawing.Size(65, 13);
            this.notificationsLabel.TabIndex = 0;
            this.notificationsLabel.Text = "Notifications";
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(275, 51);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(34, 13);
            this.usersLabel.TabIndex = 0;
            this.usersLabel.Text = "Users";
            // 
            // leaderboardsLabel
            // 
            this.leaderboardsLabel.AutoSize = true;
            this.leaderboardsLabel.Location = new System.Drawing.Point(177, 51);
            this.leaderboardsLabel.Name = "leaderboardsLabel";
            this.leaderboardsLabel.Size = new System.Drawing.Size(72, 13);
            this.leaderboardsLabel.TabIndex = 0;
            this.leaderboardsLabel.Text = "Leaderboards";
            // 
            // rewardsLabel
            // 
            this.rewardsLabel.AutoSize = true;
            this.rewardsLabel.Location = new System.Drawing.Point(107, 51);
            this.rewardsLabel.Name = "rewardsLabel";
            this.rewardsLabel.Size = new System.Drawing.Size(49, 13);
            this.rewardsLabel.TabIndex = 0;
            this.rewardsLabel.Text = "Rewards";
            // 
            // choresLabel
            // 
            this.choresLabel.AutoSize = true;
            this.choresLabel.Location = new System.Drawing.Point(30, 51);
            this.choresLabel.Name = "choresLabel";
            this.choresLabel.Size = new System.Drawing.Size(40, 13);
            this.choresLabel.TabIndex = 0;
            this.choresLabel.Text = "Chores";
            // 
            // choreNavButton
            // 
            this.choreNavButton.AccessibleName = "Chores";
            this.choreNavButton.BackgroundImage = global::ChoreApplication.Properties.Resources.chores;
            this.choreNavButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.choreNavButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choreNavButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.choreNavButton.FlatAppearance.BorderSize = 0;
            this.choreNavButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.choreNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.choreNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choreNavButton.Location = new System.Drawing.Point(12, 13);
            this.choreNavButton.Name = "choreNavButton";
            this.choreNavButton.Size = new System.Drawing.Size(75, 35);
            this.choreNavButton.TabIndex = 0;
            this.choreNavButton.Tag = "Chores";
            this.choreNavButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.choreNavButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.choreNavButton.UseVisualStyleBackColor = true;
            this.choreNavButton.Click += new System.EventHandler(this.ChoreNavButton_Click);
            // 
            // notificationsNavButton
            // 
            this.notificationsNavButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notificationsNavButton.BackgroundImage")));
            this.notificationsNavButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notificationsNavButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationsNavButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.notificationsNavButton.FlatAppearance.BorderSize = 0;
            this.notificationsNavButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.notificationsNavButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.notificationsNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.notificationsNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationsNavButton.Location = new System.Drawing.Point(336, 13);
            this.notificationsNavButton.Name = "notificationsNavButton";
            this.notificationsNavButton.Size = new System.Drawing.Size(75, 35);
            this.notificationsNavButton.TabIndex = 0;
            this.notificationsNavButton.Tag = "Notifications";
            this.notificationsNavButton.UseVisualStyleBackColor = true;
            this.notificationsNavButton.Click += new System.EventHandler(this.NotificationsNavButton_Click);
            // 
            // usersNavButton
            // 
            this.usersNavButton.BackgroundImage = global::ChoreApplication.Properties.Resources.users;
            this.usersNavButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.usersNavButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersNavButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.usersNavButton.FlatAppearance.BorderSize = 0;
            this.usersNavButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.usersNavButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.usersNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.usersNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersNavButton.Location = new System.Drawing.Point(255, 13);
            this.usersNavButton.Name = "usersNavButton";
            this.usersNavButton.Size = new System.Drawing.Size(75, 35);
            this.usersNavButton.TabIndex = 0;
            this.usersNavButton.Tag = "Users";
            this.usersNavButton.UseVisualStyleBackColor = true;
            this.usersNavButton.Click += new System.EventHandler(this.UsersNavButton_Click);
            // 
            // leadboardNavButton
            // 
            this.leadboardNavButton.BackgroundImage = global::ChoreApplication.Properties.Resources.leaderboardPlaceholder;
            this.leadboardNavButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leadboardNavButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leadboardNavButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.leadboardNavButton.FlatAppearance.BorderSize = 0;
            this.leadboardNavButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.leadboardNavButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.leadboardNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.leadboardNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leadboardNavButton.Location = new System.Drawing.Point(174, 13);
            this.leadboardNavButton.Name = "leadboardNavButton";
            this.leadboardNavButton.Size = new System.Drawing.Size(75, 35);
            this.leadboardNavButton.TabIndex = 0;
            this.leadboardNavButton.Tag = "Leaderboards";
            this.leadboardNavButton.UseVisualStyleBackColor = true;
            this.leadboardNavButton.Click += new System.EventHandler(this.LeadboardNavButton_Click);
            // 
            // rewardNavButton
            // 
            this.rewardNavButton.BackgroundImage = global::ChoreApplication.Properties.Resources.reward;
            this.rewardNavButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rewardNavButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rewardNavButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.rewardNavButton.FlatAppearance.BorderSize = 0;
            this.rewardNavButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.rewardNavButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.rewardNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.rewardNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rewardNavButton.Location = new System.Drawing.Point(93, 13);
            this.rewardNavButton.Name = "rewardNavButton";
            this.rewardNavButton.Size = new System.Drawing.Size(75, 35);
            this.rewardNavButton.TabIndex = 0;
            this.rewardNavButton.Tag = "Rewards";
            this.rewardNavButton.UseVisualStyleBackColor = true;
            this.rewardNavButton.Click += new System.EventHandler(this.RewardNavButton_Click);
            // 
            // OptionButton
            // 
            this.OptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionButton.BackgroundImage = global::ChoreApplication.Properties.Resources.add;
            this.OptionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OptionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.OptionButton.FlatAppearance.BorderSize = 0;
            this.OptionButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.OptionButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.OptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionButton.Location = new System.Drawing.Point(390, 3);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Size = new System.Drawing.Size(25, 25);
            this.OptionButton.TabIndex = 0;
            this.OptionButton.UseVisualStyleBackColor = true;
            this.OptionButton.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // titleText
            // 
            this.titleText.AutoEllipsis = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(144, 3);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(149, 26);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "CenterText";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upperPanel
            // 
            this.upperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upperPanel.Controls.Add(this.UserButton);
            this.upperPanel.Controls.Add(this.SortButton);
            this.upperPanel.Controls.Add(this.OptionButton);
            this.upperPanel.Controls.Add(this.titleText);
            this.upperPanel.Location = new System.Drawing.Point(12, 12);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(420, 33);
            this.upperPanel.TabIndex = 1;
            // 
            // UserButton
            // 
            this.UserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserButton.BackgroundImage = global::ChoreApplication.Properties.Resources.user;
            this.UserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.UserButton.FlatAppearance.BorderSize = 0;
            this.UserButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.UserButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.UserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButton.Location = new System.Drawing.Point(3, 3);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(25, 25);
            this.UserButton.TabIndex = 0;
            this.UserButton.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            this.SortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortButton.BackgroundImage = global::ChoreApplication.Properties.Resources.menu;
            this.SortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.SortButton.FlatAppearance.BorderSize = 0;
            this.SortButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.SortButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Location = new System.Drawing.Point(336, 3);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(25, 25);
            this.SortButton.TabIndex = 0;
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // ChorePanel
            // 
            this.ChorePanel.AutoScroll = true;
            this.ChorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChorePanel.Location = new System.Drawing.Point(12, 49);
            this.ChorePanel.MaximumSize = new System.Drawing.Size(420, 450);
            this.ChorePanel.Name = "ChorePanel";
            this.ChorePanel.Size = new System.Drawing.Size(420, 415);
            this.ChorePanel.TabIndex = 1;
            this.ChorePanel.Visible = false;
            // 
            // ParentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(444, 561);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.ChorePanel);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ParentInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParentInterface";
            this.Load += new System.EventHandler(this.ParentInterface_Load);
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.upperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button notificationsNavButton;
        private System.Windows.Forms.Button usersNavButton;
        private System.Windows.Forms.Button leadboardNavButton;
        private System.Windows.Forms.Button rewardNavButton;
        private System.Windows.Forms.Button choreNavButton;
        private System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label leaderboardsLabel;
        private System.Windows.Forms.Label rewardsLabel;
        private System.Windows.Forms.Label choresLabel;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Button OptionButton;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Panel ChorePanel;
        private System.Windows.Forms.Button SortButton;
    }
}