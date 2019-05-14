namespace ChoreApplication.UI.ChildUI
{
    partial class ChildMenu
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
            this.upperPanel = new System.Windows.Forms.Panel();
            this.childPointsLabel = new System.Windows.Forms.Label();
            this.userButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.chorePanel = new System.Windows.Forms.Panel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.notificationAmount = new global::ChoreApplication.UI.UILibrary.RoundButton();
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.leaderboardsLabel = new System.Windows.Forms.Label();
            this.rewardsLabel = new System.Windows.Forms.Label();
            this.choresLabel = new System.Windows.Forms.Label();
            this.choreNavButton = new System.Windows.Forms.Button();
            this.notificationsNavButton = new System.Windows.Forms.Button();
            this.leadboardNavButton = new System.Windows.Forms.Button();
            this.rewardNavButton = new System.Windows.Forms.Button();
            this.RewardPanel = new System.Windows.Forms.Panel();
            this.leaderboardPanel = new System.Windows.Forms.Panel();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.upperPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upperPanel.Controls.Add(this.childPointsLabel);
            this.upperPanel.Controls.Add(this.userButton);
            this.upperPanel.Controls.Add(this.titleText);
            this.upperPanel.Location = new System.Drawing.Point(12, 12);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(420, 33);
            this.upperPanel.TabIndex = 4;
            // 
            // childPointsLabel
            // 
            this.childPointsLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.childPointsLabel.Location = new System.Drawing.Point(29, 0);
            this.childPointsLabel.Name = "childPointsLabel";
            this.childPointsLabel.Size = new System.Drawing.Size(104, 31);
            this.childPointsLabel.TabIndex = 1;
            this.childPointsLabel.Text = "Points:";
            this.childPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.userButton.TabIndex = 5;
            this.toolTip.SetToolTip(this.userButton, "Click here to log out.");
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.UserButton_Click);
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
            // chorePanel
            // 
            this.chorePanel.AutoScroll = true;
            this.chorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chorePanel.Location = new System.Drawing.Point(12, 49);
            this.chorePanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.chorePanel.Name = "chorePanel";
            this.chorePanel.Size = new System.Drawing.Size(420, 415);
            this.chorePanel.TabIndex = 5;
            this.chorePanel.Visible = false;
            // 
            // navigationPanel
            // 
            this.navigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigationPanel.Controls.Add(this.notificationAmount);
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
            // notificationAmount
            // 
            this.notificationAmount.Enabled = false;
            this.notificationAmount.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.notificationAmount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.notificationAmount.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.notificationAmount.Location = new System.Drawing.Point(364, -1);
            this.notificationAmount.Name = "notificationAmount";
            this.notificationAmount.Size = new System.Drawing.Size(35, 35);
            this.notificationAmount.TabIndex = 0;
            this.notificationAmount.TabStop = false;
            this.notificationAmount.Text = "999";
            this.notificationAmount.UseVisualStyleBackColor = true;
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
            this.choreNavButton.TabIndex = 1;
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
            this.notificationsNavButton.TabIndex = 4;
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
            this.leadboardNavButton.TabIndex = 3;
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
            this.rewardNavButton.TabIndex = 2;
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
            // leaderboardPanel
            // 
            this.leaderboardPanel.AutoScroll = true;
            this.leaderboardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leaderboardPanel.Location = new System.Drawing.Point(12, 49);
            this.leaderboardPanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.leaderboardPanel.Name = "leaderboardPanel";
            this.leaderboardPanel.Size = new System.Drawing.Size(420, 415);
            this.leaderboardPanel.TabIndex = 3;
            this.leaderboardPanel.Visible = false;
            // 
            // notificationPanel
            // 
            this.notificationPanel.AutoScroll = true;
            this.notificationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationPanel.Location = new System.Drawing.Point(12, 49);
            this.notificationPanel.MaximumSize = new System.Drawing.Size(420, 415);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(420, 415);
            this.notificationPanel.TabIndex = 3;
            this.notificationPanel.Visible = false;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // ChildInterface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(444, 561);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.notificationPanel);
            this.Controls.Add(this.leaderboardPanel);
            this.Controls.Add(this.chorePanel);
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
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Panel chorePanel;
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
        private System.Windows.Forms.Label childPointsLabel;
        private System.Windows.Forms.Panel leaderboardPanel;
        private System.Windows.Forms.Panel notificationPanel;
        private global::ChoreApplication.UI.UILibrary.RoundButton notificationAmount;
        private System.Windows.Forms.ToolTip toolTip;
    }
}