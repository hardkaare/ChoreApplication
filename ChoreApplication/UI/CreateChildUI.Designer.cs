namespace ChoreApplication.UI
{
    partial class CreateChildUI
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.childName = new System.Windows.Forms.TextBox();
            this.createChildButton = new System.Windows.Forms.Button();
            this.childNameLabel = new System.Windows.Forms.Label();
            this.pincodeLabel = new System.Windows.Forms.Label();
            this.childPincode = new System.Windows.Forms.TextBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::ChoreApplication.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // childName
            // 
            this.childName.Location = new System.Drawing.Point(70, 183);
            this.childName.MaxLength = 20;
            this.childName.Name = "childName";
            this.childName.Size = new System.Drawing.Size(200, 20);
            this.childName.TabIndex = 1;
            this.childName.Text = "Enter firstname";
            // 
            // createChildButton
            // 
            this.createChildButton.Location = new System.Drawing.Point(70, 248);
            this.createChildButton.Name = "createChildButton";
            this.createChildButton.Size = new System.Drawing.Size(200, 25);
            this.createChildButton.TabIndex = 3;
            this.createChildButton.Text = "Create";
            this.createChildButton.UseVisualStyleBackColor = true;
            this.createChildButton.Click += new System.EventHandler(this.CreateChildButton_Click);
            // 
            // childNameLabel
            // 
            this.childNameLabel.Location = new System.Drawing.Point(70, 167);
            this.childNameLabel.Name = "childNameLabel";
            this.childNameLabel.Size = new System.Drawing.Size(57, 13);
            this.childNameLabel.TabIndex = 3;
            this.childNameLabel.Text = "Firstname";
            // 
            // pincodeLabel
            // 
            this.pincodeLabel.AutoSize = true;
            this.pincodeLabel.Location = new System.Drawing.Point(70, 206);
            this.pincodeLabel.Name = "pincodeLabel";
            this.pincodeLabel.Size = new System.Drawing.Size(73, 13);
            this.pincodeLabel.TabIndex = 5;
            this.pincodeLabel.Text = "Enter pincode";
            // 
            // childPincode
            // 
            this.childPincode.Location = new System.Drawing.Point(70, 222);
            this.childPincode.MaxLength = 4;
            this.childPincode.Name = "childPincode";
            this.childPincode.Size = new System.Drawing.Size(200, 20);
            this.childPincode.TabIndex = 2;
            this.childPincode.Text = "Enter pincode";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(310, 24);
            this.WelcomeLabel.TabIndex = 16;
            this.WelcomeLabel.Text = "Create Child";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateChildUI
            // 
            this.AcceptButton = this.createChildButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 287);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.pincodeLabel);
            this.Controls.Add(this.childPincode);
            this.Controls.Add(this.childNameLabel);
            this.Controls.Add(this.createChildButton);
            this.Controls.Add(this.childName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateChildUI";
            this.Text = "Create Child";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox childName;
        private System.Windows.Forms.Button createChildButton;
        private System.Windows.Forms.Label childNameLabel;
        private System.Windows.Forms.Label pincodeLabel;
        private System.Windows.Forms.TextBox childPincode;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}