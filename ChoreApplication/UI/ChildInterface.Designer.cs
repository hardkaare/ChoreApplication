namespace ChoreApplication.UI
{
    partial class ChildInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildInterface));
            this.upperPanel = new System.Windows.Forms.Panel();
            this.UserButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.ChorePanel = new System.Windows.Forms.Panel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.leaderboardsLabel = new System.Windows.Forms.Label();
            this.rewardsLabel = new System.Windows.Forms.Label();
            this.choresLabel = new System.Windows.Forms.Label();
            this.choreNavButton = new System.Windows.Forms.Button();
            this.notificationsNavButton = new System.Windows.Forms.Button();
            this.leadboardNavButton = new System.Windows.Forms.Button();
            this.rewardNavButton = new System.Windows.Forms.Button();
            this.upperPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upperPanel.Controls.Add(this.UserButton);
            this.upperPanel.Controls.Add(this.titleText);
            this.upperPanel.Location = new System.Drawing.Point(30, 16);
            this.upperPanel.Margin = new System.Windows.Forms.Padding(4);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(466, 37);
            this.upperPanel.TabIndex = 4;
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
            this.UserButton.Location = new System.Drawing.Point(4, 2);
            this.UserButton.Margin = new System.Windows.Forms.Padding(4);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(33, 31);
            this.UserButton.TabIndex = 0;
            this.UserButton.UseVisualStyleBackColor = true;
            // 
            // titleText
            // 
            this.titleText.AutoEllipsis = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.titleText.Location = new System.Drawing.Point(118, 2);
            this.titleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(199, 32);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "CenterText";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChorePanel
            // 
            this.ChorePanel.AutoScroll = true;
            this.ChorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChorePanel.Location = new System.Drawing.Point(30, 61);
            this.ChorePanel.Margin = new System.Windows.Forms.Padding(4);
            this.ChorePanel.MaximumSize = new System.Drawing.Size(559, 553);
            this.ChorePanel.Name = "ChorePanel";
            this.ChorePanel.Size = new System.Drawing.Size(466, 509);
            this.ChorePanel.TabIndex = 3;
            this.ChorePanel.Visible = false;
            // 
            // navigationPanel
            // 
            this.navigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigationPanel.Controls.Add(this.notificationsLabel);
            this.navigationPanel.Controls.Add(this.leaderboardsLabel);
            this.navigationPanel.Controls.Add(this.rewardsLabel);
            this.navigationPanel.Controls.Add(this.choresLabel);
            this.navigationPanel.Controls.Add(this.choreNavButton);
            this.navigationPanel.Controls.Add(this.notificationsNavButton);
            this.navigationPanel.Controls.Add(this.leadboardNavButton);
            this.navigationPanel.Controls.Add(this.rewardNavButton);
            this.navigationPanel.Location = new System.Drawing.Point(30, 578);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(4);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(466, 98);
            this.navigationPanel.TabIndex = 2;
            // 
            // notificationsLabel
            // 
            this.notificationsLabel.AutoSize = true;
            this.notificationsLabel.Location = new System.Drawing.Point(341, 63);
            this.notificationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notificationsLabel.Name = "notificationsLabel";
            this.notificationsLabel.Size = new System.Drawing.Size(85, 17);
            this.notificationsLabel.TabIndex = 0;
            this.notificationsLabel.Text = "Notifications";
            // 
            // leaderboardsLabel
            // 
            this.leaderboardsLabel.AutoSize = true;
            this.leaderboardsLabel.Location = new System.Drawing.Point(236, 63);
            this.leaderboardsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leaderboardsLabel.Name = "leaderboardsLabel";
            this.leaderboardsLabel.Size = new System.Drawing.Size(97, 17);
            this.leaderboardsLabel.TabIndex = 0;
            this.leaderboardsLabel.Text = "Leaderboards";
            // 
            // rewardsLabel
            // 
            this.rewardsLabel.AutoSize = true;
            this.rewardsLabel.Location = new System.Drawing.Point(143, 63);
            this.rewardsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rewardsLabel.Name = "rewardsLabel";
            this.rewardsLabel.Size = new System.Drawing.Size(63, 17);
            this.rewardsLabel.TabIndex = 0;
            this.rewardsLabel.Text = "Rewards";
            // 
            // choresLabel
            // 
            this.choresLabel.AutoSize = true;
            this.choresLabel.Location = new System.Drawing.Point(40, 63);
            this.choresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.choresLabel.Name = "choresLabel";
            this.choresLabel.Size = new System.Drawing.Size(53, 17);
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
            this.choreNavButton.Location = new System.Drawing.Point(16, 16);
            this.choreNavButton.Margin = new System.Windows.Forms.Padding(4);
            this.choreNavButton.Name = "choreNavButton";
            this.choreNavButton.Size = new System.Drawing.Size(100, 43);
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
            this.notificationsNavButton.Location = new System.Drawing.Point(340, 16);
            this.notificationsNavButton.Margin = new System.Windows.Forms.Padding(4);
            this.notificationsNavButton.Name = "notificationsNavButton";
            this.notificationsNavButton.Size = new System.Drawing.Size(100, 43);
            this.notificationsNavButton.TabIndex = 0;
            this.notificationsNavButton.Tag = "Notifications";
            this.notificationsNavButton.UseVisualStyleBackColor = true;
            this.notificationsNavButton.Click += new System.EventHandler(this.NotificationsNavButton_Click);
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
            this.leadboardNavButton.Location = new System.Drawing.Point(232, 16);
            this.leadboardNavButton.Margin = new System.Windows.Forms.Padding(4);
            this.leadboardNavButton.Name = "leadboardNavButton";
            this.leadboardNavButton.Size = new System.Drawing.Size(100, 43);
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
            this.rewardNavButton.Location = new System.Drawing.Point(124, 16);
            this.rewardNavButton.Margin = new System.Windows.Forms.Padding(4);
            this.rewardNavButton.Name = "rewardNavButton";
            this.rewardNavButton.Size = new System.Drawing.Size(100, 43);
            this.rewardNavButton.TabIndex = 0;
            this.rewardNavButton.Tag = "Rewards";
            this.rewardNavButton.UseVisualStyleBackColor = true;
            this.rewardNavButton.Click += new System.EventHandler(this.RewardNavButton_Click);
            // 
            // ChildInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(524, 689);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.ChorePanel);
            this.Controls.Add(this.navigationPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChildInterface";
            this.Text = "ChildInterface";
            this.upperPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Panel ChorePanel;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.Label leaderboardsLabel;
        private System.Windows.Forms.Label rewardsLabel;
        private System.Windows.Forms.Label choresLabel;
        private System.Windows.Forms.Button choreNavButton;
        private System.Windows.Forms.Button notificationsNavButton;
        private System.Windows.Forms.Button leadboardNavButton;
        private System.Windows.Forms.Button rewardNavButton;
    }
}