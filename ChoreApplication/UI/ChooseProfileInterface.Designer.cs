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
            this.ChooseProfileLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfilesPanel
            // 
            this.ProfilesPanel.AutoScroll = true;
            this.ProfilesPanel.Location = new System.Drawing.Point(12, 72);
            this.ProfilesPanel.Name = "ProfilesPanel";
            this.ProfilesPanel.Size = new System.Drawing.Size(420, 366);
            this.ProfilesPanel.TabIndex = 0;
            // 
            // ChooseProfileLabel
            // 
            this.ChooseProfileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseProfileLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontSubtitle;
            this.ChooseProfileLabel.Location = new System.Drawing.Point(12, 38);
            this.ChooseProfileLabel.Name = "ChooseProfileLabel";
            this.ChooseProfileLabel.Size = new System.Drawing.Size(420, 24);
            this.ChooseProfileLabel.TabIndex = 1;
            this.ChooseProfileLabel.Text = "Choose Profile";
            this.ChooseProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::ChoreApplication.Properties.Settings.Default, "StandardFontTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SurnameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.SurnameLabel.Location = new System.Drawing.Point(12, 8);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(420, 26);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "The {surname}\'s";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::ChoreApplication.Properties.Resources.chevron_circle_left_solid;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(12, 9);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(25, 26);
            this.BackButton.TabIndex = 2;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ChooseProfileInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.ChooseProfileLabel);
            this.Controls.Add(this.ProfilesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseProfileInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChooseProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProfilesPanel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label ChooseProfileLabel;
        private System.Windows.Forms.Button BackButton;
    }
}