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
            this.upperPanel = new System.Windows.Forms.Panel();
            this.ChildPointsLabel = new System.Windows.Forms.Label();
            this.UserButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.ChorePanel = new System.Windows.Forms.Panel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.NotificationAmount = new RoundButton();
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.leaderboardsLabel = new System.Windows.Forms.Label();
            this.rewardsLabel = new System.Windows.Forms.Label();
            this.choresLabel = new System.Windows.Forms.Label();
            this.choreNavButton = new System.Windows.Forms.Button();
            this.notificationsNavButton = new System.Windows.Forms.Button();
            this.leadboardNavButton = new System.Windows.Forms.Button();
            this.rewardNavButton = new System.Windows.Forms.Button();
            this.RewardPanel = new System.Windows.Forms.Panel();
            this.LeaderboardPanel = new System.Windows.Forms.Panel();
            this.NotificationPanel = new System.Windows.Forms.Panel();
            this.upperPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upperPanel.Controls.Add(this.ChildPointsLabel);
            this.upperPanel.Controls.Add(this.UserButton);
            this.upperPanel.Controls.Add(this.titleText);
            this.upperPanel.Location = new System.Drawing.Point(12, 12);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(420, 33);
            this.upperPanel.TabIndex = 4;
            // 
            // ChildPointsLabel
            // 
            this.ChildPointsLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.ChildPointsLabel.Location = new System.Drawing.Point(29, 0);
            this.ChildPointsLabel.Name = "ChildPointsLabel";
            this.ChildPointsLabel.Size = new System.Drawing.Size(104, 31);
            this.ChildPointsLabel.TabIndex = 1;
            this.ChildPointsLabel.Text = "Points:";
            this.ChildPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // titleText
            // 
            this.titleText.AutoEllipsis = true;
            this.titleText.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::ChoreApplication.Properties.Settings.Default, "StandardFontTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.titleText.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.titleText.Location = new System.Drawing.Point(-1, -1);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(420, 30);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "CenterText";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChorePanel
            // 
            this.ChorePanel.AutoScroll = true;
            this.ChorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChorePanel.Location = new System.Drawing.Point(12, 49);
            this.ChorePanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.ChorePanel.Name = "ChorePanel";
            this.ChorePanel.Size = new System.Drawing.Size(420, 415);
            this.ChorePanel.TabIndex = 5;
            this.ChorePanel.Visible = false;
            // 
            // navigationPanel
            // 
            this.navigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigationPanel.Controls.Add(this.NotificationAmount);
            this.navigationPanel.Controls.Add(this.notificationsLabel);
            this.navigationPanel.Controls.Add(this.leaderboardsLabel);
            this.navigationPanel.Controls.Add(this.rewardsLabel);
            this.navigationPanel.Controls.Add(this.choresLabel);
            this.navigationPanel.Controls.Add(this.choreNavButton);
            this.navigationPanel.Controls.Add(this.notificationsNavButton);
            this.navigationPanel.Controls.Add(this.leadboardNavButton);
            this.navigationPanel.Controls.Add(this.rewardNavButton);
            this.navigationPanel.Location = new System.Drawing.Point(12, 469);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(420, 79);
            this.navigationPanel.TabIndex = 6;
            // 
            // NotificationAmount
            // 
            this.NotificationAmount.Enabled = false;
            this.NotificationAmount.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.NotificationAmount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.NotificationAmount.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.NotificationAmount.Location = new System.Drawing.Point(364, -1);
            this.NotificationAmount.Name = "NotificationAmount";
            this.NotificationAmount.Size = new System.Drawing.Size(35, 35);
            this.NotificationAmount.TabIndex = 0;
            this.NotificationAmount.TabStop = false;
            this.NotificationAmount.Text = "999";
            this.NotificationAmount.UseVisualStyleBackColor = true;
            // 
            // notificationsLabel
            // 
            this.notificationsLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.notificationsLabel.Location = new System.Drawing.Point(322, 55);
            this.notificationsLabel.Name = "notificationsLabel";
            this.notificationsLabel.Size = new System.Drawing.Size(84, 18);
            this.notificationsLabel.TabIndex = 0;
            this.notificationsLabel.Text = "Notifications";
            this.notificationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leaderboardsLabel
            // 
            this.leaderboardsLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.leaderboardsLabel.Location = new System.Drawing.Point(209, 55);
            this.leaderboardsLabel.Name = "leaderboardsLabel";
            this.leaderboardsLabel.Size = new System.Drawing.Size(97, 18);
            this.leaderboardsLabel.TabIndex = 0;
            this.leaderboardsLabel.Text = "Leaderboards";
            this.leaderboardsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rewardsLabel
            // 
            this.rewardsLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.rewardsLabel.Location = new System.Drawing.Point(109, 55);
            this.rewardsLabel.Name = "rewardsLabel";
            this.rewardsLabel.Size = new System.Drawing.Size(75, 18);
            this.rewardsLabel.TabIndex = 0;
            this.rewardsLabel.Text = "Rewards";
            this.rewardsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choresLabel
            // 
            this.choresLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.choresLabel.Location = new System.Drawing.Point(16, 55);
            this.choresLabel.Name = "choresLabel";
            this.choresLabel.Size = new System.Drawing.Size(73, 18);
            this.choresLabel.TabIndex = 0;
            this.choresLabel.Text = "Chores";
            this.choresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.choreNavButton.Location = new System.Drawing.Point(14, 9);
            this.choreNavButton.Name = "choreNavButton";
            this.choreNavButton.Size = new System.Drawing.Size(75, 40);
            this.choreNavButton.TabIndex = 0;
            this.choreNavButton.Tag = "Chores";
            this.choreNavButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.choreNavButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.choreNavButton.UseVisualStyleBackColor = true;
            this.choreNavButton.Click += new System.EventHandler(this.ChoreNavButton_Click);
            // 
            // notificationsNavButton
            // 
            this.notificationsNavButton.BackgroundImage = global::ChoreApplication.Properties.Resources.notifications;
            this.notificationsNavButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notificationsNavButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationsNavButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.notificationsNavButton.FlatAppearance.BorderSize = 0;
            this.notificationsNavButton.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.notificationsNavButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.notificationsNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.notificationsNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationsNavButton.Location = new System.Drawing.Point(325, 9);
            this.notificationsNavButton.Name = "notificationsNavButton";
            this.notificationsNavButton.Size = new System.Drawing.Size(75, 40);
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
            this.leadboardNavButton.Location = new System.Drawing.Point(212, 9);
            this.leadboardNavButton.Name = "leadboardNavButton";
            this.leadboardNavButton.Size = new System.Drawing.Size(86, 40);
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
            this.rewardNavButton.Location = new System.Drawing.Point(109, 9);
            this.rewardNavButton.Name = "rewardNavButton";
            this.rewardNavButton.Size = new System.Drawing.Size(75, 40);
            this.rewardNavButton.TabIndex = 0;
            this.rewardNavButton.Tag = "Rewards";
            this.rewardNavButton.UseVisualStyleBackColor = true;
            this.rewardNavButton.Click += new System.EventHandler(this.RewardNavButton_Click);
            // 
            // RewardPanel
            // 
            this.RewardPanel.AutoScroll = true;
            this.RewardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RewardPanel.Location = new System.Drawing.Point(12, 49);
            this.RewardPanel.Margin = new System.Windows.Forms.Padding(2);
            this.RewardPanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.RewardPanel.Name = "RewardPanel";
            this.RewardPanel.Size = new System.Drawing.Size(420, 415);
            this.RewardPanel.TabIndex = 2;
            this.RewardPanel.Visible = false;
            // 
            // LeaderboardPanel
            // 
            this.LeaderboardPanel.AutoScroll = true;
            this.LeaderboardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeaderboardPanel.Location = new System.Drawing.Point(12, 49);
            this.LeaderboardPanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.LeaderboardPanel.Name = "LeaderboardPanel";
            this.LeaderboardPanel.Size = new System.Drawing.Size(420, 415);
            this.LeaderboardPanel.TabIndex = 3;
            this.LeaderboardPanel.Visible = false;
            // 
            // NotificationPanel
            // 
            this.NotificationPanel.AutoScroll = true;
            this.NotificationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotificationPanel.Location = new System.Drawing.Point(12, 49);
            this.NotificationPanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.NotificationPanel.Name = "NotificationPanel";
            this.NotificationPanel.Size = new System.Drawing.Size(420, 415);
            this.NotificationPanel.TabIndex = 3;
            this.NotificationPanel.Visible = false;
            // 
            // ChildInterface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(444, 561);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.NotificationPanel);
            this.Controls.Add(this.LeaderboardPanel);
            this.Controls.Add(this.ChorePanel);
            this.Controls.Add(this.RewardPanel);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChildInterface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Child Interface";
            this.upperPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel RewardPanel;
        private System.Windows.Forms.Label choresLabel;
        private System.Windows.Forms.Button choreNavButton;
        private System.Windows.Forms.Button notificationsNavButton;
        private System.Windows.Forms.Button leadboardNavButton;
        private System.Windows.Forms.Button rewardNavButton;
        private System.Windows.Forms.Label ChildPointsLabel;
        private System.Windows.Forms.Panel LeaderboardPanel;
        private System.Windows.Forms.Panel NotificationPanel;
        private RoundButton NotificationAmount;
    }
}