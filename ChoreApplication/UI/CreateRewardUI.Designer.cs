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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rewardName = new System.Windows.Forms.Label();
            this.rewardDescription = new System.Windows.Forms.Label();
            this.pointsRequired = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.Assignment = new System.Windows.Forms.ComboBox();
            this.createReward = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 0;
            // 
            // rewardName
            // 
            this.rewardName.AutoSize = true;
            this.rewardName.Location = new System.Drawing.Point(147, 117);
            this.rewardName.Name = "rewardName";
            this.rewardName.Size = new System.Drawing.Size(73, 13);
            this.rewardName.TabIndex = 1;
            this.rewardName.Text = "Reward name";
            // 
            // rewardDescription
            // 
            this.rewardDescription.AutoSize = true;
            this.rewardDescription.Location = new System.Drawing.Point(146, 160);
            this.rewardDescription.Name = "rewardDescription";
            this.rewardDescription.Size = new System.Drawing.Size(60, 13);
            this.rewardDescription.TabIndex = 2;
            this.rewardDescription.Text = "Description";
            // 
            // pointsRequired
            // 
            this.pointsRequired.AutoSize = true;
            this.pointsRequired.Location = new System.Drawing.Point(147, 284);
            this.pointsRequired.Name = "pointsRequired";
            this.pointsRequired.Size = new System.Drawing.Size(77, 13);
            this.pointsRequired.TabIndex = 4;
            this.pointsRequired.Text = "Points required";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(149, 300);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Location = new System.Drawing.Point(147, 328);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(61, 13);
            this.assignmentLabel.TabIndex = 6;
            this.assignmentLabel.Text = "Assignment";
            // 
            // Assignment
            // 
            this.Assignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Assignment.FormattingEnabled = true;
            this.Assignment.Location = new System.Drawing.Point(149, 344);
            this.Assignment.Name = "Assignment";
            this.Assignment.Size = new System.Drawing.Size(121, 21);
            this.Assignment.TabIndex = 7;
            this.Assignment.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // createReward
            // 
            this.createReward.Location = new System.Drawing.Point(136, 409);
            this.createReward.Name = "createReward";
            this.createReward.Size = new System.Drawing.Size(149, 23);
            this.createReward.TabIndex = 8;
            this.createReward.Text = "Create reward";
            this.createReward.UseVisualStyleBackColor = true;
            this.createReward.Click += new System.EventHandler(this.CreateReward_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(149, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(121, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(150, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // CreateRewardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.createReward);
            this.Controls.Add(this.Assignment);
            this.Controls.Add(this.assignmentLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pointsRequired);
            this.Controls.Add(this.rewardDescription);
            this.Controls.Add(this.rewardName);
            this.Controls.Add(this.textBox1);
            this.Name = "CreateRewardUI";
            this.Text = "CreateRewardUI";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label rewardName;
        private System.Windows.Forms.Label rewardDescription;
        private System.Windows.Forms.Label pointsRequired;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.ComboBox Assignment;
        private System.Windows.Forms.Button createReward;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}