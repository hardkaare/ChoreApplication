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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::ChoreApplication.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(133, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // childName
            // 
            this.childName.Location = new System.Drawing.Point(104, 228);
            this.childName.MaxLength = 255;
            this.childName.Name = "childName";
            this.childName.Size = new System.Drawing.Size(173, 20);
            this.childName.TabIndex = 1;
            // 
            // createChildButton
            // 
            this.createChildButton.Location = new System.Drawing.Point(140, 266);
            this.createChildButton.Name = "createChildButton";
            this.createChildButton.Size = new System.Drawing.Size(100, 33);
            this.createChildButton.TabIndex = 2;
            this.createChildButton.Text = "Create child";
            this.createChildButton.UseVisualStyleBackColor = true;
            this.createChildButton.Click += new System.EventHandler(this.CreateChildButton_Click);
            // 
            // childNameLabel
            // 
            this.childNameLabel.AutoSize = true;
            this.childNameLabel.Location = new System.Drawing.Point(101, 212);
            this.childNameLabel.Name = "childNameLabel";
            this.childNameLabel.Size = new System.Drawing.Size(35, 13);
            this.childNameLabel.TabIndex = 3;
            this.childNameLabel.Text = "Name";
            // 
            // CreateChildUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 383);
            this.Controls.Add(this.childNameLabel);
            this.Controls.Add(this.createChildButton);
            this.Controls.Add(this.childName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateChildUI";
            this.Text = "CreateChildUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox childName;
        private System.Windows.Forms.Button createChildButton;
        private System.Windows.Forms.Label childNameLabel;
    }
}