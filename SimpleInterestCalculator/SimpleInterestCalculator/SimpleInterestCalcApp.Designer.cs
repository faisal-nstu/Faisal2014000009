namespace SimpleInterestCalculator
{
    partial class SimpleInterestCalcApp
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Period";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(91, 281);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(146, 59);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(231, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(146, 109);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(177, 20);
            this.rateTextBox.TabIndex = 5;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(146, 159);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(177, 20);
            this.timeTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "year(s)";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(146, 228);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // SimpleInterestCalcApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 338);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimpleInterestCalcApp";
            this.Text = "Simple Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculateButton;
    }
}

