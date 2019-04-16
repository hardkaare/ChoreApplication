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
            this.registerPanel = new System.Windows.Forms.Panel();
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            this.registerUserLabel = new System.Windows.Forms.Label();
            this.registerUserButton = new System.Windows.Forms.Button();
            this.pincodeInput = new System.Windows.Forms.TextBox();
            this.pwd2Input = new System.Windows.Forms.TextBox();
            this.pwd1Input = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // registerPanel
            // 
            this.registerPanel.Controls.Add(this.uploadPictureBox);
            this.registerPanel.Controls.Add(this.registerUserLabel);
            this.registerPanel.Controls.Add(this.registerUserButton);
            this.registerPanel.Controls.Add(this.pincodeInput);
            this.registerPanel.Controls.Add(this.pwd2Input);
            this.registerPanel.Controls.Add(this.pwd1Input);
            this.registerPanel.Controls.Add(this.emailInput);
            this.registerPanel.Controls.Add(this.lastNameInput);
            this.registerPanel.Controls.Add(this.firstNameInput);
            this.registerPanel.Location = new System.Drawing.Point(12, 12);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(299, 348);
            this.registerPanel.TabIndex = 1;
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadPictureBox.Image = global::ChoreApplication.Properties.Resources.user;
            this.uploadPictureBox.Location = new System.Drawing.Point(99, 50);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(100, 90);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadPictureBox.TabIndex = 4;
            this.uploadPictureBox.TabStop = false;
            this.uploadPictureBox.Click += new System.EventHandler(this.UploadPictureBox_Click);
            this.uploadPictureBox.MouseHover += new System.EventHandler(this.UploadPictureBox_Hover);
            // 
            // registerUserLabel
            // 
            this.registerUserLabel.AutoSize = true;
            this.registerUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.registerUserLabel.Location = new System.Drawing.Point(86, 12);
            this.registerUserLabel.Name = "registerUserLabel";
            this.registerUserLabel.Size = new System.Drawing.Size(123, 24);
            this.registerUserLabel.TabIndex = 3;
            this.registerUserLabel.Text = "Register User";
            // 
            // registerUserButton
            // 
            this.registerUserButton.Location = new System.Drawing.Point(111, 302);
            this.registerUserButton.Name = "registerUserButton";
            this.registerUserButton.Size = new System.Drawing.Size(75, 23);
            this.registerUserButton.TabIndex = 1;
            this.registerUserButton.Text = "Register";
            this.registerUserButton.UseVisualStyleBackColor = true;
            // 
            // pincodeInput
            // 
            this.pincodeInput.Location = new System.Drawing.Point(65, 276);
            this.pincodeInput.Name = "pincodeInput";
            this.pincodeInput.Size = new System.Drawing.Size(166, 20);
            this.pincodeInput.TabIndex = 0;
            this.pincodeInput.Text = "Choose a pincode";
            // 
            // pwd2Input
            // 
            this.pwd2Input.Location = new System.Drawing.Point(65, 250);
            this.pwd2Input.Name = "pwd2Input";
            this.pwd2Input.Size = new System.Drawing.Size(166, 20);
            this.pwd2Input.TabIndex = 0;
            this.pwd2Input.Text = "Confirm password";
            // 
            // pwd1Input
            // 
            this.pwd1Input.Location = new System.Drawing.Point(65, 224);
            this.pwd1Input.Name = "pwd1Input";
            this.pwd1Input.Size = new System.Drawing.Size(166, 20);
            this.pwd1Input.TabIndex = 0;
            this.pwd1Input.Text = "Password";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(65, 198);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(166, 20);
            this.emailInput.TabIndex = 0;
            this.emailInput.Text = "Email";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(65, 172);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(166, 20);
            this.lastNameInput.TabIndex = 0;
            this.lastNameInput.Text = "Lastname";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(65, 146);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(166, 20);
            this.firstNameInput.TabIndex = 0;
            this.firstNameInput.Text = "Name";
            // 
            // RegisterUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(323, 377);
            this.Controls.Add(this.registerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegisterUserInterface";
            this.Text = "Register New User";
            this.Load += new System.EventHandler(this.RegisterUserInterface_Load);
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.PictureBox uploadPictureBox;
        private System.Windows.Forms.Label registerUserLabel;
        private System.Windows.Forms.Button registerUserButton;
        private System.Windows.Forms.TextBox pincodeInput;
        private System.Windows.Forms.TextBox pwd2Input;
        private System.Windows.Forms.TextBox pwd1Input;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox firstNameInput;
    }
}