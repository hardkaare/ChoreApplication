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
            this.description = new System.Windows.Forms.RichTextBox();
            this.saveReward = new System.Windows.Forms.Button();
            this.assignment = new System.Windows.Forms.ComboBox();
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.pointsRequired = new System.Windows.Forms.NumericUpDown();
            this.pointsRequiredLabel = new System.Windows.Forms.Label();
            this.rewardDescriptionLabel = new System.Windows.Forms.Label();
            this.rewardNameLabel = new System.Windows.Forms.Label();
            this.rewardName = new System.Windows.Forms.TextBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pointsRequired)).BeginInit();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(70, 119);
            this.description.MaxLength = 255;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(200, 100);
            this.description.TabIndex = 2;
            this.description.Text = "";
            // 
            // saveReward
            // 
            this.saveReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveReward.Location = new System.Drawing.Point(70, 317);
            this.saveReward.Name = "saveReward";
            this.saveReward.Size = new System.Drawing.Size(200, 25);
            this.saveReward.TabIndex = 5;
            this.saveReward.Text = "Save";
            this.saveReward.UseVisualStyleBackColor = true;
            this.saveReward.Click += new System.EventHandler(this.SaveReward_Click);
            // 
            // assignment
            // 
            this.assignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignment.FormattingEnabled = true;
            this.assignment.Location = new System.Drawing.Point(70, 287);
            this.assignment.Name = "assignment";
            this.assignment.Size = new System.Drawing.Size(200, 24);
            this.assignment.TabIndex = 4;
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentLabel.Location = new System.Drawing.Point(70, 271);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(78, 16);
            this.assignmentLabel.TabIndex = 0;
            this.assignmentLabel.Text = "Assignment";
            // 
            // pointsRequired
            // 
            this.pointsRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsRequired.Location = new System.Drawing.Point(70, 243);
            this.pointsRequired.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointsRequired.Name = "pointsRequired";
            this.pointsRequired.Size = new System.Drawing.Size(200, 22);
            this.pointsRequired.TabIndex = 3;
            this.pointsRequired.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pointsRequiredLabel
            // 
            this.pointsRequiredLabel.AutoSize = true;
            this.pointsRequiredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsRequiredLabel.Location = new System.Drawing.Point(70, 227);
            this.pointsRequiredLabel.Name = "pointsRequiredLabel";
            this.pointsRequiredLabel.Size = new System.Drawing.Size(98, 16);
            this.pointsRequiredLabel.TabIndex = 0;
            this.pointsRequiredLabel.Text = "Points required";
            // 
            // rewardDescriptionLabel
            // 
            this.rewardDescriptionLabel.AutoSize = true;
            this.rewardDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewardDescriptionLabel.Location = new System.Drawing.Point(70, 103);
            this.rewardDescriptionLabel.Name = "rewardDescriptionLabel";
            this.rewardDescriptionLabel.Size = new System.Drawing.Size(76, 16);
            this.rewardDescriptionLabel.TabIndex = 0;
            this.rewardDescriptionLabel.Text = "Description";
            // 
            // rewardNameLabel
            // 
            this.rewardNameLabel.AutoSize = true;
            this.rewardNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewardNameLabel.Location = new System.Drawing.Point(70, 60);
            this.rewardNameLabel.Name = "rewardNameLabel";
            this.rewardNameLabel.Size = new System.Drawing.Size(92, 16);
            this.rewardNameLabel.TabIndex = 0;
            this.rewardNameLabel.Text = "Reward name";
            // 
            // rewardName
            // 
            this.rewardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewardName.Location = new System.Drawing.Point(70, 76);
            this.rewardName.MaxLength = 50;
            this.rewardName.Name = "rewardName";
            this.rewardName.Size = new System.Drawing.Size(200, 22);
            this.rewardName.TabIndex = 1;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(310, 24);
            this.WelcomeLabel.TabIndex = 8;
            this.WelcomeLabel.Text = "Edit Reward";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditRewardUI
            // 
            this.AcceptButton = this.saveReward;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 352);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.saveReward);
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
            this.Name = "EditRewardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Reward";
            ((System.ComponentModel.ISupportInitialize)(this.pointsRequired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button saveReward;
        private System.Windows.Forms.ComboBox assignment;
        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.NumericUpDown pointsRequired;
        private System.Windows.Forms.Label pointsRequiredLabel;
        private System.Windows.Forms.Label rewardDescriptionLabel;
        private System.Windows.Forms.Label rewardNameLabel;
        private System.Windows.Forms.TextBox rewardName;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}