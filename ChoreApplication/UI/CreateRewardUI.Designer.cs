namespace ChoreApplication.UI
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
            this.rewardNameTextBox = new System.Windows.Forms.TextBox();
            this.rewardNameLabel = new System.Windows.Forms.Label();
            this.rewardDescriptionLabel = new System.Windows.Forms.Label();
            this.pointsRequiredLabel = new System.Windows.Forms.Label();
            this.pointsRequiredNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.assignmentComboBox = new System.Windows.Forms.ComboBox();
            this.createRewardButton = new System.Windows.Forms.Button();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pointsRequiredNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // rewardName
            // 
            this.rewardNameTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.rewardNameTextBox.Location = new System.Drawing.Point(70, 77);
            this.rewardNameTextBox.Name = "rewardName";
            this.rewardNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.rewardNameTextBox.TabIndex = 1;
            // 
            // rewardNameLabel
            // 
            this.rewardNameLabel.AutoSize = true;
            this.rewardNameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.rewardNameLabel.Location = new System.Drawing.Point(66, 58);
            this.rewardNameLabel.Name = "rewardNameLabel";
            this.rewardNameLabel.Size = new System.Drawing.Size(92, 16);
            this.rewardNameLabel.TabIndex = 0;
            this.rewardNameLabel.Text = "Reward name";
            // 
            // rewardDescriptionLabel
            // 
            this.rewardDescriptionLabel.AutoSize = true;
            this.rewardDescriptionLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.rewardDescriptionLabel.Location = new System.Drawing.Point(66, 102);
            this.rewardDescriptionLabel.Name = "rewardDescriptionLabel";
            this.rewardDescriptionLabel.Size = new System.Drawing.Size(76, 16);
            this.rewardDescriptionLabel.TabIndex = 0;
            this.rewardDescriptionLabel.Text = "Description";
            // 
            // pointsRequiredLabel
            // 
            this.pointsRequiredLabel.AutoSize = true;
            this.pointsRequiredLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.pointsRequiredLabel.Location = new System.Drawing.Point(68, 224);
            this.pointsRequiredLabel.Name = "pointsRequiredLabel";
            this.pointsRequiredLabel.Size = new System.Drawing.Size(98, 16);
            this.pointsRequiredLabel.TabIndex = 0;
            this.pointsRequiredLabel.Text = "Points required";
            // 
            // pointsRequired
            // 
            this.pointsRequiredNumericUpDown.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.pointsRequiredNumericUpDown.Location = new System.Drawing.Point(70, 243);
            this.pointsRequiredNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.pointsRequiredNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointsRequiredNumericUpDown.Name = "pointsRequired";
            this.pointsRequiredNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.pointsRequiredNumericUpDown.TabIndex = 3;
            this.pointsRequiredNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.assignmentLabel.Location = new System.Drawing.Point(68, 268);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(78, 16);
            this.assignmentLabel.TabIndex = 0;
            this.assignmentLabel.Text = "Assignment";
            // 
            // assignment
            // 
            this.assignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignmentComboBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.assignmentComboBox.FormattingEnabled = true;
            this.assignmentComboBox.Location = new System.Drawing.Point(69, 287);
            this.assignmentComboBox.Name = "assignment";
            this.assignmentComboBox.Size = new System.Drawing.Size(200, 24);
            this.assignmentComboBox.TabIndex = 4;
            // 
            // createReward
            // 
            this.createRewardButton.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.createRewardButton.Location = new System.Drawing.Point(69, 317);
            this.createRewardButton.Name = "createReward";
            this.createRewardButton.Size = new System.Drawing.Size(200, 25);
            this.createRewardButton.TabIndex = 5;
            this.createRewardButton.Text = "Create reward";
            this.createRewardButton.UseVisualStyleBackColor = true;
            this.createRewardButton.Click += new System.EventHandler(this.CreateReward_Click);
            // 
            // description
            // 
            this.descriptionRichTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(69, 121);
            this.descriptionRichTextBox.Name = "description";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(200, 100);
            this.descriptionRichTextBox.TabIndex = 2;
            this.descriptionRichTextBox.Text = "";
            // 
            // WelcomeLabel
            // 
            this.welcomeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.welcomeLabel.Name = "WelcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(310, 24);
            this.welcomeLabel.TabIndex = 6;
            this.welcomeLabel.Text = "Create Reward";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateRewardUI
            // 
            this.AcceptButton = this.createRewardButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 356);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.createRewardButton);
            this.Controls.Add(this.assignmentComboBox);
            this.Controls.Add(this.assignmentLabel);
            this.Controls.Add(this.pointsRequiredNumericUpDown);
            this.Controls.Add(this.pointsRequiredLabel);
            this.Controls.Add(this.rewardDescriptionLabel);
            this.Controls.Add(this.rewardNameLabel);
            this.Controls.Add(this.rewardNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateRewardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Reward";
            ((System.ComponentModel.ISupportInitialize)(this.pointsRequiredNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rewardNameTextBox;
        private System.Windows.Forms.Label rewardNameLabel;
        private System.Windows.Forms.Label rewardDescriptionLabel;
        private System.Windows.Forms.Label pointsRequiredLabel;
        private System.Windows.Forms.NumericUpDown pointsRequiredNumericUpDown;
        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.ComboBox assignmentComboBox;
        private System.Windows.Forms.Button createRewardButton;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label welcomeLabel;
    }
}