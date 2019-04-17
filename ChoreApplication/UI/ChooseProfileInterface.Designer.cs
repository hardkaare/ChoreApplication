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
            this.profilesPanel.Location = new System.Drawing.Point(12, 86);
            this.profilesPanel.Name = "profilesPanel";
            this.profilesPanel.Size = new System.Drawing.Size(558, 352);
            this.profilesPanel.TabIndex = 0;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.surnameLabel.Location = new System.Drawing.Point(213, 19);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(168, 26);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "The {surname}\'s";
            // 
            // chooseProfileLabel
            // 
            this.chooseProfileLabel.AutoSize = true;
            this.chooseProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chooseProfileLabel.Location = new System.Drawing.Point(233, 45);
            this.chooseProfileLabel.Name = "chooseProfileLabel";
            this.chooseProfileLabel.Size = new System.Drawing.Size(133, 24);
            this.chooseProfileLabel.TabIndex = 1;
            this.chooseProfileLabel.Text = "Choose Profile";
            // 
            // ChooseProfileInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.chooseProfileLabel);
            this.Controls.Add(this.profilesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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