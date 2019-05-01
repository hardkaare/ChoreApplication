namespace ChoreApplication.UI
{
    partial class EditChildUI
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
            this.childName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.childNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pincode = new System.Windows.Forms.TextBox();
            this.pincodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // childName
            // 
            this.childName.Location = new System.Drawing.Point(108, 248);
            this.childName.Name = "childName";
            this.childName.Size = new System.Drawing.Size(157, 20);
            this.childName.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(149, 316);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 24);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // childNameLabel
            // 
            this.childNameLabel.AutoSize = true;
            this.childNameLabel.Location = new System.Drawing.Point(105, 232);
            this.childNameLabel.Name = "childNameLabel";
            this.childNameLabel.Size = new System.Drawing.Size(59, 13);
            this.childNameLabel.TabIndex = 2;
            this.childNameLabel.Text = "Child name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::ChoreApplication.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(127, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pincode
            // 
            this.pincode.Location = new System.Drawing.Point(108, 290);
            this.pincode.Name = "pincode";
            this.pincode.Size = new System.Drawing.Size(157, 20);
            this.pincode.TabIndex = 4;
            // 
            // pincodeLabel
            // 
            this.pincodeLabel.AutoSize = true;
            this.pincodeLabel.Location = new System.Drawing.Point(105, 274);
            this.pincodeLabel.Name = "pincodeLabel";
            this.pincodeLabel.Size = new System.Drawing.Size(46, 13);
            this.pincodeLabel.TabIndex = 5;
            this.pincodeLabel.Text = "Pincode";
            // 
            // EditChildUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.pincodeLabel);
            this.Controls.Add(this.pincode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.childNameLabel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.childName);
            this.Name = "EditChildUI";
            this.Text = "EditChildUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox childName;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label childNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pincode;
        private System.Windows.Forms.Label pincodeLabel;
    }
}