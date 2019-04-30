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
            this.rewardName = new System.Windows.Forms.TextBox();
            this.rewardNameLabel = new System.Windows.Forms.Label();
            this.rewardDescriptionLabel = new System.Windows.Forms.Label();
            this.pointsRequiredLabel = new System.Windows.Forms.Label();
            this.pointsRequired = new System.Windows.Forms.NumericUpDown();
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.assignment = new System.Windows.Forms.ComboBox();
            this.createReward = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pointsRequired)).BeginInit();
            this.SuspendLayout();
            // 
            // rewardName
            // 
            this.rewardName.Location = new System.Drawing.Point(146, 62);
            this.rewardName.Name = "rewardName";
            this.rewardName.Size = new System.Drawing.Size(120, 20);
            this.rewardName.TabIndex = 1;
            // 
            // rewardNameLabel
            // 
            this.rewardNameLabel.AutoSize = true;
            this.rewardNameLabel.Location = new System.Drawing.Point(144, 46);
            this.rewardNameLabel.Name = "rewardNameLabel";
            this.rewardNameLabel.Size = new System.Drawing.Size(73, 13);
            this.rewardNameLabel.TabIndex = 0;
            this.rewardNameLabel.Text = "Reward name";
            // 
            // rewardDescriptionLabel
            // 
            this.rewardDescriptionLabel.AutoSize = true;
            this.rewardDescriptionLabel.Location = new System.Drawing.Point(143, 89);
            this.rewardDescriptionLabel.Name = "rewardDescriptionLabel";
            this.rewardDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.rewardDescriptionLabel.TabIndex = 0;
            this.rewardDescriptionLabel.Text = "Description";
            // 
            // pointsRequiredLabel
            // 
            this.pointsRequiredLabel.AutoSize = true;
            this.pointsRequiredLabel.Location = new System.Drawing.Point(144, 213);
            this.pointsRequiredLabel.Name = "pointsRequiredLabel";
            this.pointsRequiredLabel.Size = new System.Drawing.Size(77, 13);
            this.pointsRequiredLabel.TabIndex = 0;
            this.pointsRequiredLabel.Text = "Points required";
            // 
            // pointsRequired
            // 
            this.pointsRequired.Location = new System.Drawing.Point(146, 229);
            this.pointsRequired.Name = "pointsRequired";
            this.pointsRequired.Size = new System.Drawing.Size(120, 20);
            this.pointsRequired.TabIndex = 3;
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Location = new System.Drawing.Point(144, 257);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(61, 13);
            this.assignmentLabel.TabIndex = 0;
            this.assignmentLabel.Text = "Assignment";
            // 
            // assignment
            // 
            this.assignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignment.FormattingEnabled = true;
            this.assignment.Location = new System.Drawing.Point(146, 273);
            this.assignment.Name = "assignment";
            this.assignment.Size = new System.Drawing.Size(121, 21);
            this.assignment.TabIndex = 4;
            this.assignment.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // createReward
            // 
            this.createReward.Location = new System.Drawing.Point(133, 338);
            this.createReward.Name = "createReward";
            this.createReward.Size = new System.Drawing.Size(149, 23);
            this.createReward.TabIndex = 5;
            this.createReward.Text = "Create reward";
            this.createReward.UseVisualStyleBackColor = true;
            this.createReward.Click += new System.EventHandler(this.CreateReward_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(147, 105);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(121, 96);
            this.description.TabIndex = 2;
            this.description.Text = "";
            // 
            // CreateRewardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 417);
            this.Controls.Add(this.description);
            this.Controls.Add(this.createReward);
            this.Controls.Add(this.assignment);
            this.Controls.Add(this.assignmentLabel);
            this.Controls.Add(this.pointsRequired);
            this.Controls.Add(this.pointsRequiredLabel);
            this.Controls.Add(this.rewardDescriptionLabel);
            this.Controls.Add(this.rewardNameLabel);
            this.Controls.Add(this.rewardName);
            this.Name = "CreateRewardUI";
            this.Text = "CreateRewardUI";
            ((System.ComponentModel.ISupportInitialize)(this.pointsRequired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rewardName;
        private System.Windows.Forms.Label rewardNameLabel;
        private System.Windows.Forms.Label rewardDescriptionLabel;
        private System.Windows.Forms.Label pointsRequiredLabel;
        private System.Windows.Forms.NumericUpDown pointsRequired;
        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.ComboBox assignment;
        private System.Windows.Forms.Button createReward;
        private System.Windows.Forms.RichTextBox description;
    }
}