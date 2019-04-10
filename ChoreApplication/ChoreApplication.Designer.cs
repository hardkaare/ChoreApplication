namespace ChoreApplication
{
    partial class ChoreApplication
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
            this.TestButtonLuten = new System.Windows.Forms.Button();
            this.TestLabelLuten = new System.Windows.Forms.Label();
            this.TestButtonJoenler = new System.Windows.Forms.Button();
            this.TestLabelJoenler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestButtonLuten
            // 
            this.TestButtonLuten.Location = new System.Drawing.Point(55, 143);
            this.TestButtonLuten.Name = "TestButtonLuten";
            this.TestButtonLuten.Size = new System.Drawing.Size(106, 23);
            this.TestButtonLuten.TabIndex = 1;
            this.TestButtonLuten.Text = "Test button Luten";
            this.TestButtonLuten.UseVisualStyleBackColor = true;
            this.TestButtonLuten.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TestLabelLuten
            // 
            this.TestLabelLuten.Location = new System.Drawing.Point(52, 185);
            this.TestLabelLuten.Name = "TestLabelLuten";
            this.TestLabelLuten.Size = new System.Drawing.Size(212, 223);
            this.TestLabelLuten.TabIndex = 2;
            this.TestLabelLuten.Text = "Test label Luten";
            // 
            // TestButtonJoenler
            // 
            this.TestButtonJoenler.Location = new System.Drawing.Point(313, 143);
            this.TestButtonJoenler.Name = "TestButtonJoenler";
            this.TestButtonJoenler.Size = new System.Drawing.Size(106, 23);
            this.TestButtonJoenler.TabIndex = 3;
            this.TestButtonJoenler.Text = "Test button Joenler";
            this.TestButtonJoenler.UseVisualStyleBackColor = true;
            this.TestButtonJoenler.Click += new System.EventHandler(this.TestButtonJoenler_Click);
            // 
            // TestLabelJoenler
            // 
            this.TestLabelJoenler.Location = new System.Drawing.Point(310, 185);
            this.TestLabelJoenler.Name = "TestLabelJoenler";
            this.TestLabelJoenler.Size = new System.Drawing.Size(212, 223);
            this.TestLabelJoenler.TabIndex = 4;
            this.TestLabelJoenler.Text = "Test label Joenler";
            // 
            // ChoreApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.TestLabelJoenler);
            this.Controls.Add(this.TestButtonJoenler);
            this.Controls.Add(this.TestLabelLuten);
            this.Controls.Add(this.TestButtonLuten);
            this.Name = "ChoreApplication";
            this.Text = "ChoreApplication";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TestButtonLuten;
        private System.Windows.Forms.Label TestLabelLuten;
        private System.Windows.Forms.Button TestButtonJoenler;
        private System.Windows.Forms.Label TestLabelJoenler;
    }
}

