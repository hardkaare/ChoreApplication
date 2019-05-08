namespace ChoreApplication.UI
{
    partial class EditParentUI
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
            this.parentLastName = new System.Windows.Forms.TextBox();
            this.EditPasswordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.EditEmailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.LastNameEditLabel = new System.Windows.Forms.Label();
            this.EditPincodeLabel = new System.Windows.Forms.Label();
            this.pincode = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.EditNameLabel = new System.Windows.Forms.Label();
            this.parentName = new System.Windows.Forms.TextBox();
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // parentLastName
            // 
            this.parentLastName.Location = new System.Drawing.Point(104, 266);
            this.parentLastName.MaxLength = 50;
            this.parentLastName.Name = "parentLastName";
            this.parentLastName.Size = new System.Drawing.Size(208, 22);
            this.parentLastName.TabIndex = 0;
            // 
            // EditPasswordLabel
            // 
            this.EditPasswordLabel.AutoSize = true;
            this.EditPasswordLabel.Location = new System.Drawing.Point(104, 355);
            this.EditPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditPasswordLabel.Name = "EditPasswordLabel";
            this.EditPasswordLabel.Size = new System.Drawing.Size(69, 17);
            this.EditPasswordLabel.TabIndex = 3;
            this.EditPasswordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(104, 376);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.MaxLength = 50;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(208, 22);
            this.password.TabIndex = 6;
            // 
            // EditEmailLabel
            // 
            this.EditEmailLabel.AutoSize = true;
            this.EditEmailLabel.Location = new System.Drawing.Point(104, 299);
            this.EditEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditEmailLabel.Name = "EditEmailLabel";
            this.EditEmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EditEmailLabel.TabIndex = 4;
            this.EditEmailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(104, 320);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(208, 22);
            this.emailTextBox.TabIndex = 5;
            // 
            // LastNameEditLabel
            // 
            this.LastNameEditLabel.AutoSize = true;
            this.LastNameEditLabel.Location = new System.Drawing.Point(104, 246);
            this.LastNameEditLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameEditLabel.Name = "LastNameEditLabel";
            this.LastNameEditLabel.Size = new System.Drawing.Size(74, 17);
            this.LastNameEditLabel.TabIndex = 7;
            this.LastNameEditLabel.Text = "Last name";
            // 
            // EditPincodeLabel
            // 
            this.EditPincodeLabel.AutoSize = true;
            this.EditPincodeLabel.Location = new System.Drawing.Point(104, 410);
            this.EditPincodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditPincodeLabel.Name = "EditPincodeLabel";
            this.EditPincodeLabel.Size = new System.Drawing.Size(59, 17);
            this.EditPincodeLabel.TabIndex = 8;
            this.EditPincodeLabel.Text = "Pincode";
            // 
            // pincode
            // 
            this.pincode.Location = new System.Drawing.Point(104, 431);
            this.pincode.Margin = new System.Windows.Forms.Padding(4);
            this.pincode.MaxLength = 4;
            this.pincode.Name = "pincode";
            this.pincode.Size = new System.Drawing.Size(208, 22);
            this.pincode.TabIndex = 9;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(160, 461);
            this.Save.Margin = new System.Windows.Forms.Padding(4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 30);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // EditNameLabel
            // 
            this.EditNameLabel.AutoSize = true;
            this.EditNameLabel.Location = new System.Drawing.Point(104, 193);
            this.EditNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditNameLabel.Name = "EditNameLabel";
            this.EditNameLabel.Size = new System.Drawing.Size(45, 17);
            this.EditNameLabel.TabIndex = 11;
            this.EditNameLabel.Text = "Name";
            // 
            // parentName
            // 
            this.parentName.Location = new System.Drawing.Point(104, 214);
            this.parentName.Margin = new System.Windows.Forms.Padding(4);
            this.parentName.MaxLength = 50;
            this.parentName.Name = "parentName";
            this.parentName.Size = new System.Drawing.Size(211, 22);
            this.parentName.TabIndex = 12;
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadPictureBox.Image = global::ChoreApplication.Properties.Resources.user;
            this.uploadPictureBox.Location = new System.Drawing.Point(131, 33);
            this.uploadPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(153, 131);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadPictureBox.TabIndex = 13;
            this.uploadPictureBox.TabStop = false;
            // 
            // EditParentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 554);
            this.Controls.Add(this.uploadPictureBox);
            this.Controls.Add(this.EditNameLabel);
            this.Controls.Add(this.parentName);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.EditPincodeLabel);
            this.Controls.Add(this.pincode);
            this.Controls.Add(this.LastNameEditLabel);
            this.Controls.Add(this.EditPasswordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.EditEmailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.parentLastName);
            this.Name = "EditParentUI";
            this.Text = "EditParentUI";
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parentLastName;
        private System.Windows.Forms.Label EditPasswordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label EditEmailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label LastNameEditLabel;
        private System.Windows.Forms.Label EditPincodeLabel;
        private System.Windows.Forms.TextBox pincode;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label EditNameLabel;
        private System.Windows.Forms.TextBox parentName;
        private System.Windows.Forms.PictureBox uploadPictureBox;
    }
}