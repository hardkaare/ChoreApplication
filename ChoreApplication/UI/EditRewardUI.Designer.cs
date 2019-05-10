namespace ChoreApplication.UI
{
    partial class EditRewardUI
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
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.childAssignedComboBox = new System.Windows.Forms.ComboBox();
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.pointsRequiredNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pointsRequiredLabel = new System.Windows.Forms.Label();
            this.rewardDescriptionLabel = new System.Windows.Forms.Label();
            this.rewardNameLabel = new System.Windows.Forms.Label();
            this.rewardNameTextBox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pointsRequiredNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // description
            // 
            this.descriptionRichTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(70, 119);
            this.descriptionRichTextBox.MaxLength = 255;
            this.descriptionRichTextBox.Name = "description";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(200, 100);
            this.descriptionRichTextBox.TabIndex = 2;
            this.descriptionRichTextBox.Text = "";
            // 
            // saveReward
            // 
            this.saveChangesButton.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.saveChangesButton.Location = new System.Drawing.Point(70, 317);
            this.saveChangesButton.Name = "saveReward";
            this.saveChangesButton.Size = new System.Drawing.Size(200, 25);
            this.saveChangesButton.TabIndex = 5;
            this.saveChangesButton.Text = "Save";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.SaveReward_Click);
            // 
            // assignment
            // 
            this.childAssignedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.childAssignedComboBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.childAssignedComboBox.FormattingEnabled = true;
            this.childAssignedComboBox.Location = new System.Drawing.Point(70, 287);
            this.childAssignedComboBox.Name = "assignment";
            this.childAssignedComboBox.Size = new System.Drawing.Size(200, 24);
            this.childAssignedComboBox.TabIndex = 4;
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.assignmentLabel.Location = new System.Drawing.Point(70, 271);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(78, 16);
            this.assignmentLabel.TabIndex = 0;
            this.assignmentLabel.Text = "Assignment";
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
            // pointsRequiredLabel
            // 
            this.pointsRequiredLabel.AutoSize = true;
            this.pointsRequiredLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.pointsRequiredLabel.Location = new System.Drawing.Point(70, 227);
            this.pointsRequiredLabel.Name = "pointsRequiredLabel";
            this.pointsRequiredLabel.Size = new System.Drawing.Size(98, 16);
            this.pointsRequiredLabel.TabIndex = 0;
            this.pointsRequiredLabel.Text = "Points required";
            // 
            // rewardDescriptionLabel
            // 
            this.rewardDescriptionLabel.AutoSize = true;
            this.rewardDescriptionLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.rewardDescriptionLabel.Location = new System.Drawing.Point(70, 103);
            this.rewardDescriptionLabel.Name = "rewardDescriptionLabel";
            this.rewardDescriptionLabel.Size = new System.Drawing.Size(76, 16);
            this.rewardDescriptionLabel.TabIndex = 0;
            this.rewardDescriptionLabel.Text = "Description";
            // 
            // rewardNameLabel
            // 
            this.rewardNameLabel.AutoSize = true;
            this.rewardNameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.rewardNameLabel.Location = new System.Drawing.Point(70, 60);
            this.rewardNameLabel.Name = "rewardNameLabel";
            this.rewardNameLabel.Size = new System.Drawing.Size(92, 16);
            this.rewardNameLabel.TabIndex = 0;
            this.rewardNameLabel.Text = "Reward name";
            // 
            // rewardName
            // 
            this.rewardNameTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.rewardNameTextBox.Location = new System.Drawing.Point(70, 76);
            this.rewardNameTextBox.MaxLength = 50;
            this.rewardNameTextBox.Name = "rewardName";
            this.rewardNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.rewardNameTextBox.TabIndex = 1;
            // 
            // WelcomeLabel
            // 
            this.welcomeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.welcomeLabel.Name = "WelcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(310, 24);
            this.welcomeLabel.TabIndex = 8;
            this.welcomeLabel.Text = "Edit Reward";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditRewardUI
            // 
            this.AcceptButton = this.saveChangesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 352);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.childAssignedComboBox);
            this.Controls.Add(this.assignmentLabel);
            this.Controls.Add(this.pointsRequiredNumericUpDown);
            this.Controls.Add(this.pointsRequiredLabel);
            this.Controls.Add(this.rewardDescriptionLabel);
            this.Controls.Add(this.rewardNameLabel);
            this.Controls.Add(this.rewardNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRewardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Reward";
            ((System.ComponentModel.ISupportInitialize)(this.pointsRequiredNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.ComboBox childAssignedComboBox;
        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.NumericUpDown pointsRequiredNumericUpDown;
        private System.Windows.Forms.Label pointsRequiredLabel;
        private System.Windows.Forms.Label rewardDescriptionLabel;
        private System.Windows.Forms.Label rewardNameLabel;
        private System.Windows.Forms.TextBox rewardNameTextBox;
        private System.Windows.Forms.Label welcomeLabel;
    }
}