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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // parentLastName
            // 
            this.parentLastName.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.parentLastName.Location = new System.Drawing.Point(70, 230);
            this.parentLastName.Margin = new System.Windows.Forms.Padding(2);
            this.parentLastName.MaxLength = 50;
            this.parentLastName.Name = "parentLastName";
            this.parentLastName.Size = new System.Drawing.Size(200, 22);
            this.parentLastName.TabIndex = 2;
            this.parentLastName.Tag = "";
            // 
            // EditPasswordLabel
            // 
            this.EditPasswordLabel.AutoSize = true;
            this.EditPasswordLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.EditPasswordLabel.Location = new System.Drawing.Point(70, 298);
            this.EditPasswordLabel.Name = "EditPasswordLabel";
            this.EditPasswordLabel.Size = new System.Drawing.Size(68, 16);
            this.EditPasswordLabel.TabIndex = 3;
            this.EditPasswordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.password.Location = new System.Drawing.Point(70, 317);
            this.password.MaxLength = 20;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(200, 22);
            this.password.TabIndex = 4;
            // 
            // EditEmailLabel
            // 
            this.EditEmailLabel.AutoSize = true;
            this.EditEmailLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.EditEmailLabel.Location = new System.Drawing.Point(70, 254);
            this.EditEmailLabel.Name = "EditEmailLabel";
            this.EditEmailLabel.Size = new System.Drawing.Size(42, 16);
            this.EditEmailLabel.TabIndex = 4;
            this.EditEmailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.emailTextBox.Location = new System.Drawing.Point(70, 273);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.Tag = "";
            // 
            // LastNameEditLabel
            // 
            this.LastNameEditLabel.AutoSize = true;
            this.LastNameEditLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.LastNameEditLabel.Location = new System.Drawing.Point(68, 212);
            this.LastNameEditLabel.Name = "LastNameEditLabel";
            this.LastNameEditLabel.Size = new System.Drawing.Size(70, 16);
            this.LastNameEditLabel.TabIndex = 7;
            this.LastNameEditLabel.Text = "Last name";
            // 
            // EditPincodeLabel
            // 
            this.EditPincodeLabel.AutoSize = true;
            this.EditPincodeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.EditPincodeLabel.Location = new System.Drawing.Point(70, 342);
            this.EditPincodeLabel.Name = "EditPincodeLabel";
            this.EditPincodeLabel.Size = new System.Drawing.Size(58, 16);
            this.EditPincodeLabel.TabIndex = 8;
            this.EditPincodeLabel.Text = "Pincode";
            // 
            // pincode
            // 
            this.pincode.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.pincode.Location = new System.Drawing.Point(70, 361);
            this.pincode.MaxLength = 4;
            this.pincode.Name = "pincode";
            this.pincode.Size = new System.Drawing.Size(200, 22);
            this.pincode.TabIndex = 5;
            // 
            // Save
            // 
            this.Save.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.Save.Location = new System.Drawing.Point(70, 389);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(200, 25);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // EditNameLabel
            // 
            this.EditNameLabel.AutoSize = true;
            this.EditNameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.EditNameLabel.Location = new System.Drawing.Point(70, 168);
            this.EditNameLabel.Name = "EditNameLabel";
            this.EditNameLabel.Size = new System.Drawing.Size(45, 16);
            this.EditNameLabel.TabIndex = 11;
            this.EditNameLabel.Text = "Name";
            // 
            // parentName
            // 
            this.parentName.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.parentName.Location = new System.Drawing.Point(70, 187);
            this.parentName.MaxLength = 50;
            this.parentName.Name = "parentName";
            this.parentName.Size = new System.Drawing.Size(200, 22);
            this.parentName.TabIndex = 1;
            this.parentName.Tag = "";
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadPictureBox.Image = global::ChoreApplication.Properties.Resources.user;
            this.uploadPictureBox.Location = new System.Drawing.Point(0, 48);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(339, 106);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadPictureBox.TabIndex = 13;
            this.uploadPictureBox.TabStop = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(310, 24);
            this.WelcomeLabel.TabIndex = 14;
            this.WelcomeLabel.Text = "Edit Firstname";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditParentUI
            // 
            this.AcceptButton = this.Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(337, 419);
            this.Controls.Add(this.WelcomeLabel);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditParentUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Parent";
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
        private System.Windows.Forms.Label WelcomeLabel;
    }
}