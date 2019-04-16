namespace ChoreApplication
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
            this.chorePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.rewardPanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
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
            this.navigationPanel.Location = new System.Drawing.Point(12, 455);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(423, 79);
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
            this.rewardNavButton.UseVisualStyleBackColor = true;
            this.rewardNavButton.Click += new System.EventHandler(this.RewardNavButton_Click);
            // 
            // chorePanel
            // 
            this.chorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chorePanel.Location = new System.Drawing.Point(12, 38);
            this.chorePanel.Name = "chorePanel";
            this.chorePanel.Size = new System.Drawing.Size(423, 411);
            this.chorePanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.titleLabel.Location = new System.Drawing.Point(180, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(82, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Chores";
            // 
            // rewardPanel
            // 
            this.rewardPanel.Location = new System.Drawing.Point(443, 38);
            this.rewardPanel.Name = "rewardPanel";
            this.rewardPanel.Size = new System.Drawing.Size(423, 411);
            this.rewardPanel.TabIndex = 1;
            // 
            // ParentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(878, 537);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.rewardPanel);
            this.Controls.Add(this.chorePanel);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ParentInterface";
            this.Text = "ParentInterface";
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button notificationsNavButton;
        private System.Windows.Forms.Button usersNavButton;
        private System.Windows.Forms.Button leadboardNavButton;
        private System.Windows.Forms.Button rewardNavButton;
        private System.Windows.Forms.Button choreNavButton;
        private System.Windows.Forms.Panel chorePanel;
        private System.Windows.Forms.Panel rewardPanel;
        private System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label leaderboardsLabel;
        private System.Windows.Forms.Label rewardsLabel;
        private System.Windows.Forms.Label choresLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}