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
            this.emailInput = new System.Windows.Forms.TextBox();
            this.pwdInput = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.newUserLink = new System.Windows.Forms.LinkLabel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.welcomeLabel.Location = new System.Drawing.Point(81, 22);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(323, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = " Welcome to Chore System";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginLabel.Location = new System.Drawing.Point(189, 38);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(73, 29);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            // 
            // emailInput
            // 
            this.emailInput.AcceptsTab = true;
            this.emailInput.Location = new System.Drawing.Point(119, 95);
            this.emailInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(233, 22);
            this.emailInput.TabIndex = 2;
            this.emailInput.Text = "Email";
            this.emailInput.Click += new System.EventHandler(this.EmailTextbox_Click);
            // 
            // pwdInput
            // 
            this.pwdInput.AcceptsTab = true;
            this.pwdInput.Location = new System.Drawing.Point(119, 127);
            this.pwdInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwdInput.Name = "pwdInput";
            this.pwdInput.Size = new System.Drawing.Size(233, 22);
            this.pwdInput.TabIndex = 3;
            this.pwdInput.Text = "Password";
            this.pwdInput.Click += new System.EventHandler(this.PwdTextbox_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(183, 159);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 28);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // newUserLink
            // 
            this.newUserLink.AutoSize = true;
            this.newUserLink.Location = new System.Drawing.Point(193, 191);
            this.newUserLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newUserLink.Name = "newUserLink";
            this.newUserLink.Size = new System.Drawing.Size(75, 17);
            this.newUserLink.TabIndex = 5;
            this.newUserLink.TabStop = true;
            this.newUserLink.Text = "New user?";
            this.newUserLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewUserLinkLabel_LinkClicked);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.loginLabel);
            this.LoginPanel.Controls.Add(this.newUserLink);
            this.LoginPanel.Controls.Add(this.emailInput);
            this.LoginPanel.Controls.Add(this.loginButton);
            this.LoginPanel.Controls.Add(this.pwdInput);
            this.LoginPanel.Location = new System.Drawing.Point(16, 75);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(460, 464);
            this.LoginPanel.TabIndex = 4;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // LoginInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(492, 554);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "LoginInterface";
            this.Text = "Login Interface";
            this.Load += new System.EventHandler(this.LoginInterface_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox pwdInput;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel newUserLink;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Diagnostics.EventLog eventLog1;
    }
}