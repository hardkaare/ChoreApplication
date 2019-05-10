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
            this.profilesPanel = new System.Windows.Forms.Panel();
            this.chooseProfileLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfilesPanel
            // 
            this.profilesPanel.AutoScroll = true;
            this.profilesPanel.Location = new System.Drawing.Point(12, 72);
            this.profilesPanel.Name = "ProfilesPanel";
            this.profilesPanel.Size = new System.Drawing.Size(420, 366);
            this.profilesPanel.TabIndex = 0;
            // 
            // ChooseProfileLabel
            // 
            this.chooseProfileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseProfileLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontSubtitle;
            this.chooseProfileLabel.Location = new System.Drawing.Point(12, 38);
            this.chooseProfileLabel.Name = "ChooseProfileLabel";
            this.chooseProfileLabel.Size = new System.Drawing.Size(420, 24);
            this.chooseProfileLabel.TabIndex = 1;
            this.chooseProfileLabel.Text = "Choose Profile";
            this.chooseProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurnameLabel
            // 
            this.surnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::ChoreApplication.Properties.Settings.Default, "StandardFontTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.surnameLabel.Font = global::ChoreApplication.Properties.Settings.Default.StandardFontTitle;
            this.surnameLabel.Location = new System.Drawing.Point(12, 8);
            this.surnameLabel.Name = "SurnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(420, 26);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "The {surname}\'s";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.backButton.BackgroundImage = global::ChoreApplication.Properties.Resources.chevron_circle_left_solid;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(12, 9);
            this.backButton.Name = "BackButton";
            this.backButton.Size = new System.Drawing.Size(25, 26);
            this.backButton.TabIndex = 2;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ChooseProfileInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.chooseProfileLabel);
            this.Controls.Add(this.profilesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseProfileInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChooseProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel profilesPanel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label chooseProfileLabel;
        private System.Windows.Forms.Button backButton;
    }
}