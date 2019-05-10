namespace ChoreApplication.UI
{
    partial class LoginInterface
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(310, 25);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = " Welcome";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontSubtitle;
            this.loginLabel.Location = new System.Drawing.Point(3, 17);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(304, 40);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            this.emailTextBox.AcceptsTab = true;
            this.emailTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.emailTextBox.Location = new System.Drawing.Point(60, 76);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Text = "Enter email";
            this.emailTextBox.Click += new System.EventHandler(this.EmailTextbox_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AcceptsTab = true;
            this.passwordTextBox.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.passwordTextBox.Location = new System.Drawing.Point(60, 125);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(200, 22);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.loginButton.Location = new System.Drawing.Point(60, 153);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 28);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.emailLabel);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Controls.Add(this.emailTextBox);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Location = new System.Drawing.Point(12, 38);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(310, 214);
            this.loginPanel.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.passwordLabel.Location = new System.Drawing.Point(57, 106);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 16);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFont;
            this.emailLabel.Location = new System.Drawing.Point(57, 57);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 16);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // LoginInterface
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 264);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
    }
}