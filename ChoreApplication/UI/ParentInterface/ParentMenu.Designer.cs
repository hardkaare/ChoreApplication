namespace ChoreApplication.UI
{
    partial class ParentMenu
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
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.notificationAmountLabel = new RoundButton();
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.leaderboardsLabel = new System.Windows.Forms.Label();
            this.rewardsLabel = new System.Windows.Forms.Label();
            this.choresLabel = new System.Windows.Forms.Label();
            this.choreNavigationButton = new System.Windows.Forms.Button();
            this.notificationsNavigationButton = new System.Windows.Forms.Button();
            this.usersNavigationButton = new System.Windows.Forms.Button();
            this.leadboardNavigationButton = new System.Windows.Forms.Button();
            this.rewardNavigationButton = new System.Windows.Forms.Button();
            this.optionButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.userButton = new System.Windows.Forms.Button();
            this.chorePanel = new System.Windows.Forms.Panel();
            this.rewardPanel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.leaderboardPanel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.navigationPanel.SuspendLayout();
            this.upperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigationPanel.Controls.Add(this.notificationAmountLabel);
            this.navigationPanel.Controls.Add(this.notificationsLabel);
            this.navigationPanel.Controls.Add(this.usersLabel);
            this.navigationPanel.Controls.Add(this.leaderboardsLabel);
            this.navigationPanel.Controls.Add(this.rewardsLabel);
            this.navigationPanel.Controls.Add(this.choresLabel);
            this.navigationPanel.Controls.Add(this.choreNavigationButton);
            this.navigationPanel.Controls.Add(this.notificationsNavigationButton);
            this.navigationPanel.Controls.Add(this.usersNavigationButton);
            this.navigationPanel.Controls.Add(this.leadboardNavigationButton);
            this.navigationPanel.Controls.Add(this.rewardNavigationButton);
            this.navigationPanel.Location = new System.Drawing.Point(12, 469);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(420, 79);
            this.navigationPanel.TabIndex = 0;
            // 
            // notificationAmountLabel
            // 
            this.notificationAmountLabel.Enabled = false;
            this.notificationAmountLabel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.notificationAmountLabel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.notificationAmountLabel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.notificationAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationAmountLabel.Location = new System.Drawing.Point(374, 1);
            this.notificationAmountLabel.Name = "notificationAmountLabel";
            this.notificationAmountLabel.Size = new System.Drawing.Size(35, 35);
            this.notificationAmountLabel.TabIndex = 0;
            this.notificationAmountLabel.TabStop = false;
            this.notificationAmountLabel.Text = "999";
            this.notificationAmountLabel.UseVisualStyleBackColor = true;
            // 
            // notificationsLabel
            // 
            this.notificationsLabel.AutoSize = true;
            this.notificationsLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.notificationsLabel.Location = new System.Drawing.Point(334, 55);
            this.notificationsLabel.Name = "notificationsLabel";
            this.notificationsLabel.Size = new System.Drawing.Size(81, 16);
            this.notificationsLabel.TabIndex = 0;
            this.notificationsLabel.Text = "Notifications";
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.usersLabel.Location = new System.Drawing.Point(269, 55);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(44, 16);
            this.usersLabel.TabIndex = 0;
            this.usersLabel.Text = "Users";
            // 
            // leaderboardsLabel
            // 
            this.leaderboardsLabel.AutoSize = true;
            this.leaderboardsLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.leaderboardsLabel.Location = new System.Drawing.Point(161, 55);
            this.leaderboardsLabel.Name = "leaderboardsLabel";
            this.leaderboardsLabel.Size = new System.Drawing.Size(94, 16);
            this.leaderboardsLabel.TabIndex = 0;
            this.leaderboardsLabel.Text = "Leaderboards";
            // 
            // rewardsLabel
            // 
            this.rewardsLabel.AutoSize = true;
            this.rewardsLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.rewardsLabel.Location = new System.Drawing.Point(85, 55);
            this.rewardsLabel.Name = "rewardsLabel";
            this.rewardsLabel.Size = new System.Drawing.Size(62, 16);
            this.rewardsLabel.TabIndex = 0;
            this.rewardsLabel.Text = "Rewards";
            // 
            // choresLabel
            // 
            this.choresLabel.AutoSize = true;
            this.choresLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.choresLabel.Location = new System.Drawing.Point(18, 55);
            this.choresLabel.Name = "choresLabel";
            this.choresLabel.Size = new System.Drawing.Size(51, 16);
            this.choresLabel.TabIndex = 0;
            this.choresLabel.Text = "Chores";
            // 
            // choreNavigationButton
            // 
            this.choreNavigationButton.AccessibleName = "Chores";
            this.choreNavigationButton.BackgroundImage = global::ChoreApplication.Properties.Resources.chores;
            this.choreNavigationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.choreNavigationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choreNavigationButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.choreNavigationButton.FlatAppearance.BorderSize = 0;
            this.choreNavigationButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.choreNavigationButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.choreNavigationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choreNavigationButton.Location = new System.Drawing.Point(6, 13);
            this.choreNavigationButton.Name = "choreNavigationButton";
            this.choreNavigationButton.Size = new System.Drawing.Size(75, 35);
            this.choreNavigationButton.TabIndex = 1;
            this.choreNavigationButton.Tag = "Chores";
            this.choreNavigationButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.choreNavigationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.choreNavigationButton.UseVisualStyleBackColor = true;
            this.choreNavigationButton.Click += new System.EventHandler(this.ChoreNavigationButton_Click);
            // 
            // notificationsNavigationButton
            // 
            this.notificationsNavigationButton.BackgroundImage = global::ChoreApplication.Properties.Resources.notifications;
            this.notificationsNavigationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notificationsNavigationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationsNavigationButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.notificationsNavigationButton.FlatAppearance.BorderSize = 0;
            this.notificationsNavigationButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.notificationsNavigationButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.notificationsNavigationButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.notificationsNavigationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationsNavigationButton.Location = new System.Drawing.Point(337, 13);
            this.notificationsNavigationButton.Name = "notificationsNavigationButton";
            this.notificationsNavigationButton.Size = new System.Drawing.Size(75, 35);
            this.notificationsNavigationButton.TabIndex = 5;
            this.notificationsNavigationButton.Tag = "Notifications";
            this.notificationsNavigationButton.UseVisualStyleBackColor = true;
            this.notificationsNavigationButton.Click += new System.EventHandler(this.NotificationsNavigationButton_Click);
            // 
            // usersNavigationButton
            // 
            this.usersNavigationButton.BackgroundImage = global::ChoreApplication.Properties.Resources.users;
            this.usersNavigationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.usersNavigationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersNavigationButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.usersNavigationButton.FlatAppearance.BorderSize = 0;
            this.usersNavigationButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.usersNavigationButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.usersNavigationButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.usersNavigationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersNavigationButton.Location = new System.Drawing.Point(254, 13);
            this.usersNavigationButton.Name = "usersNavigationButton";
            this.usersNavigationButton.Size = new System.Drawing.Size(75, 35);
            this.usersNavigationButton.TabIndex = 4;
            this.usersNavigationButton.Tag = "Users";
            this.usersNavigationButton.UseVisualStyleBackColor = true;
            this.usersNavigationButton.Click += new System.EventHandler(this.UsersNavigationButton_Click);
            // 
            // leadboardNavigationButton
            // 
            this.leadboardNavigationButton.BackgroundImage = global::ChoreApplication.Properties.Resources.leaderboardPlaceholder;
            this.leadboardNavigationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leadboardNavigationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leadboardNavigationButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.leadboardNavigationButton.FlatAppearance.BorderSize = 0;
            this.leadboardNavigationButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.leadboardNavigationButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.leadboardNavigationButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.leadboardNavigationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leadboardNavigationButton.Location = new System.Drawing.Point(171, 13);
            this.leadboardNavigationButton.Name = "leadboardNavigationButton";
            this.leadboardNavigationButton.Size = new System.Drawing.Size(75, 35);
            this.leadboardNavigationButton.TabIndex = 3;
            this.leadboardNavigationButton.Tag = "Leaderboards";
            this.leadboardNavigationButton.UseVisualStyleBackColor = true;
            this.leadboardNavigationButton.Click += new System.EventHandler(this.LeadboardNavigationButton_Click);
            // 
            // rewardNavigationButton
            // 
            this.rewardNavigationButton.BackgroundImage = global::ChoreApplication.Properties.Resources.reward;
            this.rewardNavigationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rewardNavigationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rewardNavigationButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.rewardNavigationButton.FlatAppearance.BorderSize = 0;
            this.rewardNavigationButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.rewardNavigationButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.rewardNavigationButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.rewardNavigationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rewardNavigationButton.Location = new System.Drawing.Point(79, 13);
            this.rewardNavigationButton.Name = "rewardNavigationButton";
            this.rewardNavigationButton.Size = new System.Drawing.Size(75, 35);
            this.rewardNavigationButton.TabIndex = 2;
            this.rewardNavigationButton.Tag = "Rewards";
            this.rewardNavigationButton.UseVisualStyleBackColor = true;
            this.rewardNavigationButton.Click += new System.EventHandler(this.RewardNavigationButton_Click);
            // 
            // optionButton
            // 
            this.optionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionButton.BackgroundImage = global::ChoreApplication.Properties.Resources.add;
            this.optionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.optionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.optionButton.FlatAppearance.BorderSize = 0;
            this.optionButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.optionButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.optionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionButton.Location = new System.Drawing.Point(390, 3);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(25, 25);
            this.optionButton.TabIndex = 6;
            this.optionButton.UseVisualStyleBackColor = true;
            this.optionButton.Click += new System.EventHandler(this.OptionButton_Click);
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
            this.upperPanel.Controls.Add(this.userButton);
            this.upperPanel.Controls.Add(this.optionButton);
            this.upperPanel.Controls.Add(this.titleText);
            this.upperPanel.Location = new System.Drawing.Point(12, 12);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(420, 33);
            this.upperPanel.TabIndex = 1;
            // 
            // userButton
            // 
            this.userButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userButton.BackgroundImage = global::ChoreApplication.Properties.Resources.user;
            this.userButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.userButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Location = new System.Drawing.Point(3, 3);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(25, 25);
            this.userButton.TabIndex = 7;
            this.toolTip.SetToolTip(this.userButton, "Click here to log out.");
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // chorePanel
            // 
            this.chorePanel.AutoScroll = true;
            this.chorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chorePanel.Location = new System.Drawing.Point(12, 49);
            this.chorePanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.chorePanel.Name = "chorePanel";
            this.chorePanel.Size = new System.Drawing.Size(420, 415);
            this.chorePanel.TabIndex = 6;
            this.chorePanel.Visible = false;
            // 
            // rewardPanel
            // 
            this.rewardPanel.AutoScroll = true;
            this.rewardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rewardPanel.Location = new System.Drawing.Point(12, 49);
            this.rewardPanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.rewardPanel.Name = "rewardPanel";
            this.rewardPanel.Size = new System.Drawing.Size(420, 415);
            this.rewardPanel.TabIndex = 2;
            this.rewardPanel.Visible = false;
            // 
            // userPanel
            // 
            this.userPanel.AutoScroll = true;
            this.userPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanel.Location = new System.Drawing.Point(12, 49);
            this.userPanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(420, 415);
            this.userPanel.TabIndex = 3;
            this.userPanel.Visible = false;
            // 
            // notificationPanel
            // 
            this.notificationPanel.AutoScroll = true;
            this.notificationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationPanel.Location = new System.Drawing.Point(12, 50);
            this.notificationPanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(420, 415);
            this.notificationPanel.TabIndex = 4;
            this.notificationPanel.Visible = false;
            // 
            // leaderboardPanel
            // 
            this.leaderboardPanel.AutoScroll = true;
            this.leaderboardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leaderboardPanel.Location = new System.Drawing.Point(12, 49);
            this.leaderboardPanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.leaderboardPanel.Name = "leaderboardPanel";
            this.leaderboardPanel.Size = new System.Drawing.Size(420, 415);
            this.leaderboardPanel.TabIndex = 5;
            this.leaderboardPanel.Visible = false;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // ParentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(444, 561);
            this.Controls.Add(this.leaderboardPanel);
            this.Controls.Add(this.notificationPanel);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.rewardPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.chorePanel);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParentInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent Interface";
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.upperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button notificationsNavigationButton;
        private System.Windows.Forms.Button usersNavigationButton;
        private System.Windows.Forms.Button leadboardNavigationButton;
        private System.Windows.Forms.Button rewardNavigationButton;
        private System.Windows.Forms.Button choreNavigationButton;
        private System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label leaderboardsLabel;
        private System.Windows.Forms.Label rewardsLabel;
        private System.Windows.Forms.Label choresLabel;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Button optionButton;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Panel chorePanel;
        private System.Windows.Forms.Panel rewardPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel notificationPanel;
        private RoundButton notificationAmountLabel;
        private System.Windows.Forms.Panel leaderboardPanel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}