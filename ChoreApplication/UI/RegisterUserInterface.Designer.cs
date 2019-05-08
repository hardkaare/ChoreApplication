﻿namespace ChoreApplication.UI
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UploadPictureBox = new System.Windows.Forms.PictureBox();
            this.RegisterUserLabel = new System.Windows.Forms.Label();
            this.RegisterUserButton = new System.Windows.Forms.Button();
            this.PincodeInput = new System.Windows.Forms.TextBox();
            this.Password2Input = new System.Windows.Forms.TextBox();
            this.Password1Input = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label6.Location = new System.Drawing.Point(70, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pincode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label5.Location = new System.Drawing.Point(71, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirm password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label4.Location = new System.Drawing.Point(71, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label3.Location = new System.Drawing.Point(71, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label2.Location = new System.Drawing.Point(70, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.label1.Location = new System.Drawing.Point(71, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firstname";
            // 
            // UploadPictureBox
            // 
            this.UploadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UploadPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadPictureBox.Image = global::ChoreApplication.Properties.Resources.user;
            this.UploadPictureBox.Location = new System.Drawing.Point(0, 37);
            this.UploadPictureBox.Name = "UploadPictureBox";
            this.UploadPictureBox.Size = new System.Drawing.Size(334, 90);
            this.UploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UploadPictureBox.TabIndex = 4;
            this.UploadPictureBox.TabStop = false;
            // 
            // RegisterUserLabel
            // 
            this.RegisterUserLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.RegisterUserLabel.Location = new System.Drawing.Point(12, 10);
            this.RegisterUserLabel.Name = "RegisterUserLabel";
            this.RegisterUserLabel.Size = new System.Drawing.Size(310, 24);
            this.RegisterUserLabel.TabIndex = 3;
            this.RegisterUserLabel.Text = "Register User";
            this.RegisterUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterUserButton
            // 
            this.RegisterUserButton.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.RegisterUserButton.Location = new System.Drawing.Point(70, 385);
            this.RegisterUserButton.Name = "RegisterUserButton";
            this.RegisterUserButton.Size = new System.Drawing.Size(200, 25);
            this.RegisterUserButton.TabIndex = 7;
            this.RegisterUserButton.Text = "Register";
            this.RegisterUserButton.UseVisualStyleBackColor = true;
            this.RegisterUserButton.Click += new System.EventHandler(this.RegisterUserButton_Click);
            // 
            // PincodeInput
            // 
            this.PincodeInput.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.PincodeInput.Location = new System.Drawing.Point(70, 357);
            this.PincodeInput.Name = "PincodeInput";
            this.PincodeInput.Size = new System.Drawing.Size(200, 22);
            this.PincodeInput.TabIndex = 6;
            // 
            // Password2Input
            // 
            this.Password2Input.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.Password2Input.Location = new System.Drawing.Point(71, 316);
            this.Password2Input.Name = "Password2Input";
            this.Password2Input.Size = new System.Drawing.Size(200, 22);
            this.Password2Input.TabIndex = 5;
            this.Password2Input.UseSystemPasswordChar = true;
            // 
            // Password1Input
            // 
            this.Password1Input.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.Password1Input.Location = new System.Drawing.Point(71, 275);
            this.Password1Input.Name = "Password1Input";
            this.Password1Input.Size = new System.Drawing.Size(200, 22);
            this.Password1Input.TabIndex = 4;
            this.Password1Input.UseSystemPasswordChar = true;
            // 
            // EmailInput
            // 
            this.EmailInput.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.EmailInput.Location = new System.Drawing.Point(71, 234);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(200, 22);
            this.EmailInput.TabIndex = 3;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.LastNameInput.Location = new System.Drawing.Point(70, 193);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(200, 22);
            this.LastNameInput.TabIndex = 2;
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.FirstNameInput.Location = new System.Drawing.Point(70, 152);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(200, 22);
            this.FirstNameInput.TabIndex = 1;
            // 
            // RegisterUserInterface
            // 
            this.AcceptButton = this.RegisterUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 421);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password1Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password2Input);
            this.Controls.Add(this.UploadPictureBox);
            this.Controls.Add(this.PincodeInput);
            this.Controls.Add(this.RegisterUserLabel);
            this.Controls.Add(this.RegisterUserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterUserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox UploadPictureBox;
        private System.Windows.Forms.Label RegisterUserLabel;
        private System.Windows.Forms.Button RegisterUserButton;
        private System.Windows.Forms.TextBox PincodeInput;
        private System.Windows.Forms.TextBox Password2Input;
        private System.Windows.Forms.TextBox Password1Input;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}