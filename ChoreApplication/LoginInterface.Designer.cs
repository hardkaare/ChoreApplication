﻿namespace ChoreApplication
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.PwdTextbox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.NewUserLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WelcomeLabel.Location = new System.Drawing.Point(81, 22);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(323, 29);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = " Welcome to Chore System";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LoginLabel.Location = new System.Drawing.Point(189, 38);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(73, 29);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.AcceptsTab = true;
            this.EmailTextbox.Location = new System.Drawing.Point(119, 95);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(233, 22);
            this.EmailTextbox.TabIndex = 2;
            this.EmailTextbox.Text = "Email";
            this.EmailTextbox.Click += new System.EventHandler(this.EmailTextbox_Click);
            // 
            // PwdTextbox
            // 
            this.PwdTextbox.AcceptsTab = true;
            this.PwdTextbox.Location = new System.Drawing.Point(119, 127);
            this.PwdTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.PwdTextbox.Name = "PwdTextbox";
            this.PwdTextbox.Size = new System.Drawing.Size(233, 22);
            this.PwdTextbox.TabIndex = 3;
            this.PwdTextbox.Text = "Password";
            this.PwdTextbox.Click += new System.EventHandler(this.PwdTextbox_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(183, 159);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 28);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // NewUserLinkLabel
            // 
            this.NewUserLinkLabel.AutoSize = true;
            this.NewUserLinkLabel.Location = new System.Drawing.Point(193, 191);
            this.NewUserLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewUserLinkLabel.Name = "NewUserLinkLabel";
            this.NewUserLinkLabel.Size = new System.Drawing.Size(75, 17);
            this.NewUserLinkLabel.TabIndex = 5;
            this.NewUserLinkLabel.TabStop = true;
            this.NewUserLinkLabel.Text = "New user?";
            this.NewUserLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewUserLinkLabel_LinkClicked);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.LoginLabel);
            this.LoginPanel.Controls.Add(this.NewUserLinkLabel);
            this.LoginPanel.Controls.Add(this.EmailTextbox);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.PwdTextbox);
            this.LoginPanel.Location = new System.Drawing.Point(16, 75);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(460, 464);
            this.LoginPanel.TabIndex = 4;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // LoginInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(492, 554);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginInterface";
            this.Text = "Login Interface";
            this.Load += new System.EventHandler(this.LoginInterface_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox PwdTextbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel NewUserLinkLabel;
        private System.Windows.Forms.Panel LoginPanel;
    }
}