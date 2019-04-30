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
            this.registerPanel.Location = new System.Drawing.Point(16, 15);
            this.registerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(399, 428);
            this.registerPanel.TabIndex = 1;
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadPictureBox.Image = global::ChoreApplication.Properties.Resources.user;
            this.uploadPictureBox.Location = new System.Drawing.Point(132, 62);
            this.uploadPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(133, 111);
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
            this.registerUserLabel.Location = new System.Drawing.Point(115, 15);
            this.registerUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerUserLabel.Name = "registerUserLabel";
            this.registerUserLabel.Size = new System.Drawing.Size(161, 29);
            this.registerUserLabel.TabIndex = 3;
            this.registerUserLabel.Text = "Register User";
            // 
            // registerUserButton
            // 
            this.registerUserButton.Location = new System.Drawing.Point(148, 372);
            this.registerUserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerUserButton.Name = "registerUserButton";
            this.registerUserButton.Size = new System.Drawing.Size(100, 28);
            this.registerUserButton.TabIndex = 1;
            this.registerUserButton.Text = "Register";
            this.registerUserButton.UseVisualStyleBackColor = true;
            // 
            // pincodeInput
            // 
            this.pincodeInput.Location = new System.Drawing.Point(87, 340);
            this.pincodeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pincodeInput.Name = "pincodeInput";
            this.pincodeInput.Size = new System.Drawing.Size(220, 22);
            this.pincodeInput.TabIndex = 0;
            this.pincodeInput.Text = "Choose a pincode";
            // 
            // pwd2Input
            // 
            this.pwd2Input.Location = new System.Drawing.Point(87, 308);
            this.pwd2Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwd2Input.Name = "pwd2Input";
            this.pwd2Input.Size = new System.Drawing.Size(220, 22);
            this.pwd2Input.TabIndex = 0;
            this.pwd2Input.Text = "Confirm password";
            // 
            // pwd1Input
            // 
            this.pwd1Input.Location = new System.Drawing.Point(87, 276);
            this.pwd1Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwd1Input.Name = "pwd1Input";
            this.pwd1Input.Size = new System.Drawing.Size(220, 22);
            this.pwd1Input.TabIndex = 0;
            this.pwd1Input.Text = "Password";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(87, 244);
            this.emailInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(220, 22);
            this.emailInput.TabIndex = 0;
            this.emailInput.Text = "Email";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(87, 212);
            this.lastNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(220, 22);
            this.lastNameInput.TabIndex = 0;
            this.lastNameInput.Text = "Lastname";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(87, 180);
            this.firstNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(220, 22);
            this.firstNameInput.TabIndex = 0;
            this.firstNameInput.Text = "Name";
            // 
            // RegisterUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(431, 464);
            this.Controls.Add(this.registerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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