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
            this.InterfaceTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ParentChorePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NavChoresButton = new System.Windows.Forms.Button();
            this.NavRewardButton = new System.Windows.Forms.Button();
            this.NavLeaderboardButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.NavUsersButton = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ParentChorePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InterfaceTitle
            // 
            this.InterfaceTitle.AutoSize = true;
            this.InterfaceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterfaceTitle.Location = new System.Drawing.Point(221, 20);
            this.InterfaceTitle.Name = "InterfaceTitle";
            this.InterfaceTitle.Size = new System.Drawing.Size(102, 31);
            this.InterfaceTitle.TabIndex = 0;
            this.InterfaceTitle.Text = "Chores";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 30);
            this.panel1.TabIndex = 1;
            // 
            // ParentChorePanel
            // 
            this.ParentChorePanel.Controls.Add(this.InterfaceTitle);
            this.ParentChorePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ParentChorePanel.Location = new System.Drawing.Point(0, 30);
            this.ParentChorePanel.Name = "ParentChorePanel";
            this.ParentChorePanel.Size = new System.Drawing.Size(532, 367);
            this.ParentChorePanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.NavUsersButton);
            this.panel2.Controls.Add(this.NavChoresButton);
            this.panel2.Controls.Add(this.NavRewardButton);
            this.panel2.Controls.Add(this.NavLeaderboardButton);
            this.panel2.Location = new System.Drawing.Point(0, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 100);
            this.panel2.TabIndex = 1;
            // 
            // NavChoresButton
            // 
            this.NavChoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavChoresButton.Location = new System.Drawing.Point(65, 39);
            this.NavChoresButton.Name = "NavChoresButton";
            this.NavChoresButton.Size = new System.Drawing.Size(75, 23);
            this.NavChoresButton.TabIndex = 1;
            this.NavChoresButton.Text = "Chores";
            this.NavChoresButton.UseVisualStyleBackColor = true;
            // 
            // NavRewardButton
            // 
            this.NavRewardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavRewardButton.Location = new System.Drawing.Point(146, 39);
            this.NavRewardButton.Name = "NavRewardButton";
            this.NavRewardButton.Size = new System.Drawing.Size(75, 23);
            this.NavRewardButton.TabIndex = 2;
            this.NavRewardButton.Text = "Rewards";
            this.NavRewardButton.UseVisualStyleBackColor = true;
            this.NavRewardButton.Click += new System.EventHandler(this.NavRewardButton_Click);
            // 
            // NavLeaderboardButton
            // 
            this.NavLeaderboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavLeaderboardButton.Location = new System.Drawing.Point(227, 39);
            this.NavLeaderboardButton.Name = "NavLeaderboardButton";
            this.NavLeaderboardButton.Size = new System.Drawing.Size(75, 23);
            this.NavLeaderboardButton.TabIndex = 3;
            this.NavLeaderboardButton.Text = "Leaderboard";
            this.NavLeaderboardButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(408, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Notifications";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // NavUsersButton
            // 
            this.NavUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavUsersButton.Location = new System.Drawing.Point(318, 39);
            this.NavUsersButton.Name = "NavUsersButton";
            this.NavUsersButton.Size = new System.Drawing.Size(75, 23);
            this.NavUsersButton.TabIndex = 5;
            this.NavUsersButton.Text = "Users";
            this.NavUsersButton.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit_button.BackgroundImage = global::ChoreApplication.Properties.Resources.clor;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(502, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(29, 30);
            this.exit_button.TabIndex = 0;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // ParentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(532, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ParentChorePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParentInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParentInterface";
            this.panel1.ResumeLayout(false);
            this.ParentChorePanel.ResumeLayout(false);
            this.ParentChorePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InterfaceTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ParentChorePanel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button NavUsersButton;
        private System.Windows.Forms.Button NavChoresButton;
        private System.Windows.Forms.Button NavRewardButton;
        private System.Windows.Forms.Button NavLeaderboardButton;
    }
}