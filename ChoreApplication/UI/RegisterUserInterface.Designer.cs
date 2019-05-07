namespace ChoreApplication.UI
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
            this.RegisterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.label6);
            this.RegisterPanel.Controls.Add(this.label5);
            this.RegisterPanel.Controls.Add(this.label4);
            this.RegisterPanel.Controls.Add(this.label3);
            this.RegisterPanel.Controls.Add(this.label2);
            this.RegisterPanel.Controls.Add(this.label1);
            this.RegisterPanel.Controls.Add(this.UploadPictureBox);
            this.RegisterPanel.Controls.Add(this.RegisterUserLabel);
            this.RegisterPanel.Controls.Add(this.RegisterUserButton);
            this.RegisterPanel.Controls.Add(this.PincodeInput);
            this.RegisterPanel.Controls.Add(this.Password2Input);
            this.RegisterPanel.Controls.Add(this.Password1Input);
            this.RegisterPanel.Controls.Add(this.EmailInput);
            this.RegisterPanel.Controls.Add(this.LastNameInput);
            this.RegisterPanel.Controls.Add(this.FirstNameInput);
            this.RegisterPanel.Location = new System.Drawing.Point(12, 12);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(299, 400);
            this.RegisterPanel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pincode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirm password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firstname";
            // 
            // UploadPictureBox
            // 
            this.UploadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UploadPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadPictureBox.Image = global::ChoreApplication.Properties.Resources.user;
            this.UploadPictureBox.Location = new System.Drawing.Point(100, 30);
            this.UploadPictureBox.Name = "UploadPictureBox";
            this.UploadPictureBox.Size = new System.Drawing.Size(100, 90);
            this.UploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UploadPictureBox.TabIndex = 4;
            this.UploadPictureBox.TabStop = false;
            // 
            // RegisterUserLabel
            // 
            this.RegisterUserLabel.AutoSize = true;
            this.RegisterUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RegisterUserLabel.Location = new System.Drawing.Point(86, 3);
            this.RegisterUserLabel.Name = "RegisterUserLabel";
            this.RegisterUserLabel.Size = new System.Drawing.Size(123, 24);
            this.RegisterUserLabel.TabIndex = 3;
            this.RegisterUserLabel.Text = "Register User";
            // 
            // RegisterUserButton
            // 
            this.RegisterUserButton.Location = new System.Drawing.Point(64, 366);
            this.RegisterUserButton.Name = "RegisterUserButton";
            this.RegisterUserButton.Size = new System.Drawing.Size(166, 25);
            this.RegisterUserButton.TabIndex = 7;
            this.RegisterUserButton.Text = "Register";
            this.RegisterUserButton.UseVisualStyleBackColor = true;
            this.RegisterUserButton.Click += new System.EventHandler(this.RegisterUserButton_Click);
            // 
            // PincodeInput
            // 
            this.PincodeInput.Location = new System.Drawing.Point(64, 340);
            this.PincodeInput.Name = "PincodeInput";
            this.PincodeInput.Size = new System.Drawing.Size(166, 20);
            this.PincodeInput.TabIndex = 6;
            this.PincodeInput.Text = "Enter pincode";
            // 
            // Password2Input
            // 
            this.Password2Input.Location = new System.Drawing.Point(66, 301);
            this.Password2Input.Name = "Password2Input";
            this.Password2Input.Size = new System.Drawing.Size(166, 20);
            this.Password2Input.TabIndex = 5;
            this.Password2Input.Text = "Confirm password";
            // 
            // Password1Input
            // 
            this.Password1Input.Location = new System.Drawing.Point(65, 262);
            this.Password1Input.Name = "Password1Input";
            this.Password1Input.Size = new System.Drawing.Size(166, 20);
            this.Password1Input.TabIndex = 4;
            this.Password1Input.Text = "Enter password";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(65, 223);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(166, 20);
            this.EmailInput.TabIndex = 3;
            this.EmailInput.Text = "Enter email";
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(65, 184);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(166, 20);
            this.LastNameInput.TabIndex = 2;
            this.LastNameInput.Text = "Enter lastname";
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(65, 145);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(166, 20);
            this.FirstNameInput.TabIndex = 1;
            this.FirstNameInput.Text = "Enter firstname";
            // 
            // RegisterUserInterface
            // 
            this.AcceptButton = this.RegisterUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(323, 419);
            this.Controls.Add(this.RegisterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegisterUserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterPanel;
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