namespace ChoreApplication.UI
{
    partial class ChooseProfileInterface
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
            this.ProfilesPanel = new System.Windows.Forms.Panel();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.ChooseProfileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProfilesPanel
            // 
            this.ProfilesPanel.AutoScroll = true;
            this.ProfilesPanel.Location = new System.Drawing.Point(12, 84);
            this.ProfilesPanel.Name = "ProfilesPanel";
            this.ProfilesPanel.Size = new System.Drawing.Size(448, 354);
            this.ProfilesPanel.TabIndex = 0;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SurnameLabel.Location = new System.Drawing.Point(12, 9);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(448, 26);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "The {surname}\'s";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseProfileLabel
            // 
            this.ChooseProfileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ChooseProfileLabel.Location = new System.Drawing.Point(12, 44);
            this.ChooseProfileLabel.Name = "ChooseProfileLabel";
            this.ChooseProfileLabel.Size = new System.Drawing.Size(448, 24);
            this.ChooseProfileLabel.TabIndex = 1;
            this.ChooseProfileLabel.Text = "Choose Profile";
            this.ChooseProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseProfileInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.ChooseProfileLabel);
            this.Controls.Add(this.ProfilesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChooseProfileInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Profile";
            this.Load += new System.EventHandler(this.ChooseProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProfilesPanel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label ChooseProfileLabel;
    }
}