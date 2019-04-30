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
            this.surnameLabel = new System.Windows.Forms.Label();
            this.chooseProfileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // profilesPanel
            // 
            this.profilesPanel.Location = new System.Drawing.Point(16, 106);
            this.profilesPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profilesPanel.Name = "profilesPanel";
            this.profilesPanel.Size = new System.Drawing.Size(744, 433);
            this.profilesPanel.TabIndex = 0;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.surnameLabel.Location = new System.Drawing.Point(284, 23);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(210, 31);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "The {surname}\'s";
            this.surnameLabel.Click += new System.EventHandler(this.SurnameLabel_Click);
            // 
            // chooseProfileLabel
            // 
            this.chooseProfileLabel.AutoSize = true;
            this.chooseProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chooseProfileLabel.Location = new System.Drawing.Point(311, 55);
            this.chooseProfileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseProfileLabel.Name = "chooseProfileLabel";
            this.chooseProfileLabel.Size = new System.Drawing.Size(173, 29);
            this.chooseProfileLabel.TabIndex = 1;
            this.chooseProfileLabel.Text = "Choose Profile";
            this.chooseProfileLabel.Click += new System.EventHandler(this.ChooseProfileLabel_Click);
            // 
            // ChooseProfileInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(776, 554);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.chooseProfileLabel);
            this.Controls.Add(this.profilesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChooseProfileInterface";
            this.Text = "Choose Profile";
            this.Load += new System.EventHandler(this.ChooseProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel profilesPanel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label chooseProfileLabel;
    }
}