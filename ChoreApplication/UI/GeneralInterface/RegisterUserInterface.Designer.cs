namespace ChoreApplication.UI.GeneralInterface
{
    partial class RegisterUserInterface
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
            this.pincodeLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            this.registerUserLabel = new System.Windows.Forms.Label();
            this.registerUserButton = new System.Windows.Forms.Button();
            this.pincodeTextBox = new System.Windows.Forms.TextBox();
            this.password2TextBox = new System.Windows.Forms.TextBox();
            this.password1TextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.pincodeLabel.AutoSize = true;
            this.pincodeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.pincodeLabel.Location = new System.Drawing.Point(70, 341);
            this.pincodeLabel.Name = "label6";
            this.pincodeLabel.Size = new System.Drawing.Size(58, 16);
            this.pincodeLabel.TabIndex = 5;
            this.pincodeLabel.Text = "Pincode";
            // 
            // label5
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(71, 300);
            this.confirmPasswordLabel.Name = "label5";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(115, 16);
            this.confirmPasswordLabel.TabIndex = 5;
            this.confirmPasswordLabel.Text = "Confirm password";
            // 
            // label4
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.passwordLabel.Location = new System.Drawing.Point(71, 259);
            this.passwordLabel.Name = "label4";
            this.passwordLabel.Size = new System.Drawing.Size(68, 16);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // label3
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.emailLabel.Location = new System.Drawing.Point(71, 218);
            this.emailLabel.Name = "label3";
            this.emailLabel.Size = new System.Drawing.Size(42, 16);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // label2
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.lastNameLabel.Location = new System.Drawing.Point(70, 177);
            this.lastNameLabel.Name = "label2";
            this.lastNameLabel.Size = new System.Drawing.Size(67, 16);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Lastname";
            // 
            // label1
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.firstNameLabel.Location = new System.Drawing.Point(71, 133);
            this.firstNameLabel.Name = "label1";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 16);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "Firstname";
            // 
            // UploadPictureBox
            // 
            this.uploadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadPictureBox.Image = global::ChoreApplication.Properties.Resources.user;
            this.uploadPictureBox.Location = new System.Drawing.Point(0, 37);
            this.uploadPictureBox.Name = "UploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(334, 90);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadPictureBox.TabIndex = 4;
            this.uploadPictureBox.TabStop = false;
            // 
            // RegisterUserLabel
            // 
            this.registerUserLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.registerUserLabel.Location = new System.Drawing.Point(12, 10);
            this.registerUserLabel.Name = "RegisterUserLabel";
            this.registerUserLabel.Size = new System.Drawing.Size(310, 24);
            this.registerUserLabel.TabIndex = 3;
            this.registerUserLabel.Text = "Register User";
            this.registerUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterUserButton
            // 
            this.registerUserButton.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.registerUserButton.Location = new System.Drawing.Point(70, 385);
            this.registerUserButton.Name = "RegisterUserButton";
            this.registerUserButton.Size = new System.Drawing.Size(200, 25);
            this.registerUserButton.TabIndex = 7;
            this.registerUserButton.Text = "Register";
            this.registerUserButton.UseVisualStyleBackColor = true;
            this.registerUserButton.Click += new System.EventHandler(this.RegisterUserButton_Click);
            // 
            // PincodeInput
            // 
            this.pincodeTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.pincodeTextBox.Location = new System.Drawing.Point(70, 357);
            this.pincodeTextBox.MaxLength = 4;
            this.pincodeTextBox.Name = "PincodeInput";
            this.pincodeTextBox.Size = new System.Drawing.Size(200, 22);
            this.pincodeTextBox.TabIndex = 6;
            // 
            // Password2Input
            // 
            this.password2TextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.password2TextBox.Location = new System.Drawing.Point(71, 316);
            this.password2TextBox.MaxLength = 20;
            this.password2TextBox.Name = "Password2Input";
            this.password2TextBox.Size = new System.Drawing.Size(200, 22);
            this.password2TextBox.TabIndex = 5;
            this.password2TextBox.UseSystemPasswordChar = true;
            // 
            // Password1Input
            // 
            this.password1TextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.password1TextBox.Location = new System.Drawing.Point(71, 275);
            this.password1TextBox.MaxLength = 20;
            this.password1TextBox.Name = "Password1Input";
            this.password1TextBox.Size = new System.Drawing.Size(200, 22);
            this.password1TextBox.TabIndex = 4;
            this.password1TextBox.UseSystemPasswordChar = true;
            // 
            // EmailInput
            // 
            this.emailTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.emailTextBox.Location = new System.Drawing.Point(71, 234);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "EmailInput";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 3;
            // 
            // LastNameInput
            // 
            this.lastNameTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.lastNameTextBox.Location = new System.Drawing.Point(70, 193);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Name = "LastNameInput";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // FirstNameInput
            // 
            this.firstNameTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.firstNameTextBox.Location = new System.Drawing.Point(70, 152);
            this.firstNameTextBox.MaxLength = 20;
            this.firstNameTextBox.Name = "FirstNameInput";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // RegisterUserInterface
            // 
            this.AcceptButton = this.registerUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 421);
            this.Controls.Add(this.pincodeLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.password1TextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.password2TextBox);
            this.Controls.Add(this.uploadPictureBox);
            this.Controls.Add(this.pincodeTextBox);
            this.Controls.Add(this.registerUserLabel);
            this.Controls.Add(this.registerUserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterUserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox uploadPictureBox;
        private System.Windows.Forms.Label registerUserLabel;
        private System.Windows.Forms.Button registerUserButton;
        private System.Windows.Forms.TextBox pincodeTextBox;
        private System.Windows.Forms.TextBox password2TextBox;
        private System.Windows.Forms.TextBox password1TextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label pincodeLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
    }
}