namespace ChoreApplication.UI.ParentUI
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
            this.childFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.childNameLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.childPincodeTextBox = new System.Windows.Forms.TextBox();
            this.pincodeLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChildFirstnameInput
            // 
            this.childFirstNameTextbox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.childFirstNameTextbox.Location = new System.Drawing.Point(70, 176);
            this.childFirstNameTextbox.MaxLength = 20;
            this.childFirstNameTextbox.Name = "ChildFirstnameInput";
            this.childFirstNameTextbox.Size = new System.Drawing.Size(200, 22);
            this.childFirstNameTextbox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.saveChangesButton.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.saveChangesButton.Location = new System.Drawing.Point(70, 249);
            this.saveChangesButton.Name = "SaveButton";
            this.saveChangesButton.Size = new System.Drawing.Size(200, 30);
            this.saveChangesButton.TabIndex = 3;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // childNameLabel
            // 
            this.childNameLabel.AutoSize = true;
            this.childNameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.childNameLabel.Location = new System.Drawing.Point(70, 160);
            this.childNameLabel.Name = "childNameLabel";
            this.childNameLabel.Size = new System.Drawing.Size(75, 16);
            this.childNameLabel.TabIndex = 0;
            this.childNameLabel.Text = "Child name";
            // 
            // pictureBox1
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Image = global::ChoreApplication.Properties.Resources.user;
            this.pictureBox.Location = new System.Drawing.Point(12, 59);
            this.pictureBox.Name = "pictureBox1";
            this.pictureBox.Size = new System.Drawing.Size(310, 91);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // ChildPincodeInput
            // 
            this.childPincodeTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.childPincodeTextBox.Location = new System.Drawing.Point(70, 218);
            this.childPincodeTextBox.MaxLength = 4;
            this.childPincodeTextBox.Name = "ChildPincodeInput";
            this.childPincodeTextBox.Size = new System.Drawing.Size(200, 22);
            this.childPincodeTextBox.TabIndex = 2;
            // 
            // pincodeLabel
            // 
            this.pincodeLabel.AutoSize = true;
            this.pincodeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.pincodeLabel.Location = new System.Drawing.Point(70, 202);
            this.pincodeLabel.Name = "pincodeLabel";
            this.pincodeLabel.Size = new System.Drawing.Size(58, 16);
            this.pincodeLabel.TabIndex = 0;
            this.pincodeLabel.Text = "Pincode";
            // 
            // WelcomeLabel
            // 
            this.welcomeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.welcomeLabel.Name = "WelcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(310, 46);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "Edit Firstname";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditChildUI
            // 
            this.AcceptButton = this.saveChangesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 286);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.pincodeLabel);
            this.Controls.Add(this.childPincodeTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.childNameLabel);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.childFirstNameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditChildUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Child";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox childFirstNameTextbox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Label childNameLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox childPincodeTextBox;
        private System.Windows.Forms.Label pincodeLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}