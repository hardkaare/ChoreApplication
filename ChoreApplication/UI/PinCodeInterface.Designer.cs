namespace ChoreApplication.UI
{
    partial class PinCodeInterface
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
            this.pincodePanel = new System.Windows.Forms.Panel();
            this.roundButton1 = new UI.RoundButton();
            this.rbZero = new UI.RoundButton();
            this.rbDelete = new UI.RoundButton();
            this.rbNine = new UI.RoundButton();
            this.rbEight = new UI.RoundButton();
            this.rbSeven = new UI.RoundButton();
            this.rbSix = new UI.RoundButton();
            this.rbFive = new UI.RoundButton();
            this.rbFour = new UI.RoundButton();
            this.rbThree = new UI.RoundButton();
            this.rbTwo = new UI.RoundButton();
            this.rbOne = new UI.RoundButton();
            this.pincodeLabel = new System.Windows.Forms.Label();
            this.enterpinTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.rbAccept = new UI.RoundButton();
            this.pincodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pincodePanel
            // 
            this.pincodePanel.Controls.Add(this.roundButton1);
            this.pincodePanel.Controls.Add(this.rbZero);
            this.pincodePanel.Controls.Add(this.rbDelete);
            this.pincodePanel.Controls.Add(this.rbNine);
            this.pincodePanel.Controls.Add(this.rbEight);
            this.pincodePanel.Controls.Add(this.rbSeven);
            this.pincodePanel.Controls.Add(this.rbSix);
            this.pincodePanel.Controls.Add(this.rbFive);
            this.pincodePanel.Controls.Add(this.rbFour);
            this.pincodePanel.Controls.Add(this.rbThree);
            this.pincodePanel.Controls.Add(this.rbTwo);
            this.pincodePanel.Controls.Add(this.rbOne);
            this.pincodePanel.Controls.Add(this.pincodeLabel);
            this.pincodePanel.Controls.Add(this.enterpinTextBox);
            this.pincodePanel.Location = new System.Drawing.Point(55, 10);
            this.pincodePanel.Margin = new System.Windows.Forms.Padding(2);
            this.pincodePanel.Name = "pincodePanel";
            this.pincodePanel.Size = new System.Drawing.Size(243, 374);
            this.pincodePanel.TabIndex = 0;
            this.pincodePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PincodePanel_Paint);
            // 
            // roundButton1
            // 
            this.roundButton1.Location = new System.Drawing.Point(159, 299);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(66, 68);
            this.roundButton1.TabIndex = 15;
            this.roundButton1.Text = "Accept";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.AcceptButton_click);
            // 
            // rbZero
            // 
            this.rbZero.Location = new System.Drawing.Point(88, 299);
            this.rbZero.Margin = new System.Windows.Forms.Padding(2);
            this.rbZero.Name = "rbZero";
            this.rbZero.Size = new System.Drawing.Size(66, 68);
            this.rbZero.TabIndex = 14;
            this.rbZero.Text = "0";
            this.rbZero.UseVisualStyleBackColor = true;
            this.rbZero.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // rbDelete
            // 
            this.rbDelete.Location = new System.Drawing.Point(18, 299);
            this.rbDelete.Margin = new System.Windows.Forms.Padding(2);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(66, 68);
            this.rbDelete.TabIndex = 13;
            this.rbDelete.Text = "Delete";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // rbNine
            // 
            this.rbNine.Location = new System.Drawing.Point(159, 226);
            this.rbNine.Margin = new System.Windows.Forms.Padding(2);
            this.rbNine.Name = "rbNine";
            this.rbNine.Size = new System.Drawing.Size(66, 68);
            this.rbNine.TabIndex = 12;
            this.rbNine.Text = "9";
            this.rbNine.UseVisualStyleBackColor = true;
            this.rbNine.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // rbEight
            // 
            this.rbEight.Location = new System.Drawing.Point(88, 226);
            this.rbEight.Margin = new System.Windows.Forms.Padding(2);
            this.rbEight.Name = "rbEight";
            this.rbEight.Size = new System.Drawing.Size(66, 68);
            this.rbEight.TabIndex = 11;
            this.rbEight.Text = "8";
            this.rbEight.UseVisualStyleBackColor = true;
            this.rbEight.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // rbSeven
            // 
            this.rbSeven.Location = new System.Drawing.Point(18, 226);
            this.rbSeven.Margin = new System.Windows.Forms.Padding(2);
            this.rbSeven.Name = "rbSeven";
            this.rbSeven.Size = new System.Drawing.Size(66, 68);
            this.rbSeven.TabIndex = 10;
            this.rbSeven.Text = "7";
            this.rbSeven.UseVisualStyleBackColor = true;
            this.rbSeven.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // rbSix
            // 
            this.rbSix.Location = new System.Drawing.Point(159, 153);
            this.rbSix.Margin = new System.Windows.Forms.Padding(2);
            this.rbSix.Name = "rbSix";
            this.rbSix.Size = new System.Drawing.Size(66, 68);
            this.rbSix.TabIndex = 9;
            this.rbSix.Text = "6";
            this.rbSix.UseVisualStyleBackColor = true;
            this.rbSix.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // rbFive
            // 
            this.rbFive.Location = new System.Drawing.Point(88, 153);
            this.rbFive.Margin = new System.Windows.Forms.Padding(2);
            this.rbFive.Name = "rbFive";
            this.rbFive.Size = new System.Drawing.Size(66, 68);
            this.rbFive.TabIndex = 8;
            this.rbFive.Text = "5";
            this.rbFive.UseVisualStyleBackColor = true;
            this.rbFive.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // rbFour
            // 
            this.rbFour.Location = new System.Drawing.Point(18, 153);
            this.rbFour.Margin = new System.Windows.Forms.Padding(2);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(66, 68);
            this.rbFour.TabIndex = 7;
            this.rbFour.Text = "4";
            this.rbFour.UseVisualStyleBackColor = true;
            this.rbFour.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // rbThree
            // 
            this.rbThree.Location = new System.Drawing.Point(159, 72);
            this.rbThree.Margin = new System.Windows.Forms.Padding(2);
            this.rbThree.Name = "rbThree";
            this.rbThree.Size = new System.Drawing.Size(66, 68);
            this.rbThree.TabIndex = 6;
            this.rbThree.Text = "3";
            this.rbThree.UseVisualStyleBackColor = true;
            this.rbThree.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // rbTwo
            // 
            this.rbTwo.Location = new System.Drawing.Point(88, 72);
            this.rbTwo.Margin = new System.Windows.Forms.Padding(2);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(66, 68);
            this.rbTwo.TabIndex = 5;
            this.rbTwo.Text = "2";
            this.rbTwo.UseVisualStyleBackColor = true;
            this.rbTwo.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // rbOne
            // 
            this.rbOne.Location = new System.Drawing.Point(18, 72);
            this.rbOne.Margin = new System.Windows.Forms.Padding(2);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(66, 68);
            this.rbOne.TabIndex = 4;
            this.rbOne.Text = "1";
            this.rbOne.UseVisualStyleBackColor = true;
            this.rbOne.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // pincodeLabel
            // 
            this.pincodeLabel.AutoSize = true;
            this.pincodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pincodeLabel.Location = new System.Drawing.Point(64, 7);
            this.pincodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pincodeLabel.Name = "pincodeLabel";
            this.pincodeLabel.Size = new System.Drawing.Size(132, 18);
            this.pincodeLabel.TabIndex = 3;
            this.pincodeLabel.Text = "Enter your pincode";
            this.pincodeLabel.Click += new System.EventHandler(this.PincodeLabel_Click);
            // 
            // enterpinTextBox
            // 
            this.enterpinTextBox.Location = new System.Drawing.Point(68, 29);
            this.enterpinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.enterpinTextBox.MaxLength = 4;
            this.enterpinTextBox.Name = "enterpinTextBox";
            this.enterpinTextBox.PasswordChar = '*';
            this.enterpinTextBox.Size = new System.Drawing.Size(117, 20);
            this.enterpinTextBox.TabIndex = 1;
            // 
            // rbAccept
            // 
            this.rbAccept.Location = new System.Drawing.Point(212, 368);
            this.rbAccept.Name = "rbAccept";
            this.rbAccept.Size = new System.Drawing.Size(88, 84);
            this.rbAccept.TabIndex = 15;
            this.rbAccept.Text = "Accept";
            this.rbAccept.UseVisualStyleBackColor = true;
            // 
            // PinCodeInterface
            // 
            this.AcceptButton = this.rbAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 393);
            this.Controls.Add(this.pincodePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PinCodeInterface";
            this.Text = " ";
            this.Load += new System.EventHandler(this.PinCodeInterface_Load);
            this.pincodePanel.ResumeLayout(false);
            this.pincodePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pincodePanel;
        private System.Windows.Forms.Label pincodeLabel;
        private System.Windows.Forms.TextBox enterpinTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;

        private RoundButton rbOne;
        private RoundButton rbTwo;
        private RoundButton rbThree;
        private RoundButton rbFour;
        private RoundButton rbFive;
        private RoundButton rbSix;
        private RoundButton rbSeven;
        private RoundButton rbEight;
        private RoundButton rbNine;
        private RoundButton rbZero;
        private RoundButton rbDelete;
        private RoundButton rbAccept;
        private RoundButton roundButton1;
    }
}