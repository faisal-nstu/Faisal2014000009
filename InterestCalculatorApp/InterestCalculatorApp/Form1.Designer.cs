namespace InterestCalculatorApp
{
    partial class InterestCalculatorUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time (In year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(70, 286);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.interestLabel.Size = new System.Drawing.Size(84, 13);
            this.interestLabel.TabIndex = 3;
            this.interestLabel.Text = "Total Interest  = ";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(144, 227);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(210, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calcualte Interest";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Items.AddRange(new object[] {
            "BRAC",
            "DBBL",
            "HSBC"});
            this.bankNameComboBox.Location = new System.Drawing.Point(144, 69);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(210, 21);
            this.bankNameComboBox.TabIndex = 5;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(144, 120);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(210, 20);
            this.timeTextBox.TabIndex = 6;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(144, 171);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(210, 20);
            this.balanceTextBox.TabIndex = 7;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(70, 319);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(82, 13);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total Balance =";
            // 
            // InterestCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 374);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.bankNameComboBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InterestCalculatorUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label totalLabel;
    }
}

