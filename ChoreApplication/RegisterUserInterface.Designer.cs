namespace ChoreApplication
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
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.UploadPictureBox = new System.Windows.Forms.PictureBox();
            this.RegisterUserLabel = new System.Windows.Forms.Label();
            this.RegisterUser = new System.Windows.Forms.Button();
            this.PincodeTextBox = new System.Windows.Forms.TextBox();
            this.Pwd2TextBox = new System.Windows.Forms.TextBox();
            this.Pwd1Textbox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RegisterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.UploadPictureBox);
            this.RegisterPanel.Controls.Add(this.RegisterUserLabel);
            this.RegisterPanel.Controls.Add(this.RegisterUser);
            this.RegisterPanel.Controls.Add(this.PincodeTextBox);
            this.RegisterPanel.Controls.Add(this.Pwd2TextBox);
            this.RegisterPanel.Controls.Add(this.Pwd1Textbox);
            this.RegisterPanel.Controls.Add(this.EmailTextBox);
            this.RegisterPanel.Controls.Add(this.LastNameTextBox);
            this.RegisterPanel.Controls.Add(this.NameTextBox);
            this.RegisterPanel.Location = new System.Drawing.Point(12, 12);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(299, 348);
            this.RegisterPanel.TabIndex = 1;
            // 
            // UploadPictureBox
            // 
            this.UploadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UploadPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadPictureBox.Image = global::ChoreApplication.Properties.Resources.UserIcon;
            this.UploadPictureBox.Location = new System.Drawing.Point(99, 50);
            this.UploadPictureBox.Name = "UploadPictureBox";
            this.UploadPictureBox.Size = new System.Drawing.Size(100, 90);
            this.UploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UploadPictureBox.TabIndex = 4;
            this.UploadPictureBox.TabStop = false;
            this.UploadPictureBox.Click += new System.EventHandler(this.UploadPictureBox_Click);
            this.UploadPictureBox.MouseHover += new System.EventHandler(this.UploadPictureBox_Hover);
            // 
            // RegisterUserLabel
            // 
            this.RegisterUserLabel.AutoSize = true;
            this.RegisterUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RegisterUserLabel.Location = new System.Drawing.Point(86, 12);
            this.RegisterUserLabel.Name = "RegisterUserLabel";
            this.RegisterUserLabel.Size = new System.Drawing.Size(123, 24);
            this.RegisterUserLabel.TabIndex = 3;
            this.RegisterUserLabel.Text = "Register User";
            // 
            // RegisterUser
            // 
            this.RegisterUser.Location = new System.Drawing.Point(111, 302);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Size = new System.Drawing.Size(75, 23);
            this.RegisterUser.TabIndex = 1;
            this.RegisterUser.Text = "Register";
            this.RegisterUser.UseVisualStyleBackColor = true;
            this.RegisterUser.Click += new System.EventHandler(this.RegisterUser_Click);
            // 
            // PincodeTextBox
            // 
            this.PincodeTextBox.Location = new System.Drawing.Point(65, 276);
            this.PincodeTextBox.Name = "PincodeTextBox";
            this.PincodeTextBox.Size = new System.Drawing.Size(166, 20);
            this.PincodeTextBox.TabIndex = 0;
            this.PincodeTextBox.Text = "Choose a pincode";
            // 
            // Pwd2TextBox
            // 
            this.Pwd2TextBox.Location = new System.Drawing.Point(65, 250);
            this.Pwd2TextBox.Name = "Pwd2TextBox";
            this.Pwd2TextBox.Size = new System.Drawing.Size(166, 20);
            this.Pwd2TextBox.TabIndex = 0;
            this.Pwd2TextBox.Text = "Confirm password";
            // 
            // Pwd1Textbox
            // 
            this.Pwd1Textbox.Location = new System.Drawing.Point(65, 224);
            this.Pwd1Textbox.Name = "Pwd1Textbox";
            this.Pwd1Textbox.Size = new System.Drawing.Size(166, 20);
            this.Pwd1Textbox.TabIndex = 0;
            this.Pwd1Textbox.Text = "Password";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(65, 198);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(166, 20);
            this.EmailTextBox.TabIndex = 0;
            this.EmailTextBox.Text = "Email";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(65, 172);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(166, 20);
            this.LastNameTextBox.TabIndex = 0;
            this.LastNameTextBox.Text = "Lastname";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(65, 146);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(166, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.Text = "Name";
            // 
            // RegisterUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(323, 377);
            this.Controls.Add(this.RegisterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegisterUserInterface";
            this.Text = "Register New User";
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.PictureBox UploadPictureBox;
        private System.Windows.Forms.Label RegisterUserLabel;
        private System.Windows.Forms.Button RegisterUser;
        private System.Windows.Forms.TextBox PincodeTextBox;
        private System.Windows.Forms.TextBox Pwd2TextBox;
        private System.Windows.Forms.TextBox Pwd1Textbox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}