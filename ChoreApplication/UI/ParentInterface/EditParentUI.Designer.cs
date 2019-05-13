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
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.pincodeLabel = new System.Windows.Forms.Label();
            this.pincodeTextBox = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // parentLastName
            // 
            this.lastNameTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.lastNameTextBox.Location = new System.Drawing.Point(70, 230);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Name = "parentLastName";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Tag = "";
            // 
            // EditPasswordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.passwordLabel.Location = new System.Drawing.Point(70, 298);
            this.passwordLabel.Name = "EditPasswordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 16);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // password
            // 
            this.passwordTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.passwordTextBox.Location = new System.Drawing.Point(70, 317);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "password";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 22);
            this.passwordTextBox.TabIndex = 4;
            // 
            // EditEmailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.emailLabel.Location = new System.Drawing.Point(70, 254);
            this.emailLabel.Name = "EditEmailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 16);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
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
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.lastNameLabel.Location = new System.Drawing.Point(68, 212);
            this.lastNameLabel.Name = "LastNameEditLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(70, 16);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last name";
            // 
            // EditPincodeLabel
            // 
            this.pincodeLabel.AutoSize = true;
            this.pincodeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.pincodeLabel.Location = new System.Drawing.Point(70, 342);
            this.pincodeLabel.Name = "EditPincodeLabel";
            this.pincodeLabel.Size = new System.Drawing.Size(58, 16);
            this.pincodeLabel.TabIndex = 8;
            this.pincodeLabel.Text = "Pincode";
            // 
            // pincode
            // 
            this.pincodeTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.pincodeTextBox.Location = new System.Drawing.Point(70, 361);
            this.pincodeTextBox.MaxLength = 4;
            this.pincodeTextBox.Name = "pincode";
            this.pincodeTextBox.Size = new System.Drawing.Size(200, 22);
            this.pincodeTextBox.TabIndex = 5;
            // 
            // Save
            // 
            this.saveChangesButton.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.saveChangesButton.Location = new System.Drawing.Point(70, 389);
            this.saveChangesButton.Name = "Save";
            this.saveChangesButton.Size = new System.Drawing.Size(200, 25);
            this.saveChangesButton.TabIndex = 6;
            this.saveChangesButton.Text = "Save";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // EditNameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.nameLabel.Location = new System.Drawing.Point(70, 168);
            this.nameLabel.Name = "EditNameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 16);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            // 
            // parentName
            // 
            this.firstNameTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.firstNameTextBox.Location = new System.Drawing.Point(70, 187);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "parentName";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Tag = "";
            // 
            // uploadPictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Image = global::ChoreApplication.Properties.Resources.user;
            this.pictureBox.Location = new System.Drawing.Point(0, 54);
            this.pictureBox.Name = "uploadPictureBox";
            this.pictureBox.Size = new System.Drawing.Size(339, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // WelcomeLabel
            // 
            this.welcomeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "WelcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(310, 42);
            this.welcomeLabel.TabIndex = 14;
            this.welcomeLabel.Text = "Edit Firstname";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditParentUI
            // 
            this.AcceptButton = this.saveChangesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(337, 419);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.pincodeLabel);
            this.Controls.Add(this.pincodeTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditParentUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Parent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label pincodeLabel;
        private System.Windows.Forms.TextBox pincodeTextBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label welcomeLabel;
    }
}