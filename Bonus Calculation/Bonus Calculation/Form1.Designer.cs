namespace Bonus_Calculation
{
    partial class EmployeeSalary
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
            this.salaryAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryAmount
            // 
            this.salaryAmount.AutoSize = true;
            this.salaryAmount.Location = new System.Drawing.Point(33, 28);
            this.salaryAmount.Name = "salaryAmount";
            this.salaryAmount.Size = new System.Drawing.Size(75, 13);
            this.salaryAmount.TabIndex = 0;
            this.salaryAmount.Text = "Salary Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bonus Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Amount";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(146, 20);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 1;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(146, 140);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.bonusTextBox.TabIndex = 3;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(146, 171);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalAmountTextBox.TabIndex = 4;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(42, 76);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(230, 34);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show Bonus and Total";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // EmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salaryAmount);
            this.Name = "EmployeeSalary";
            this.Text = "3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salaryAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Button showButton;
    }
}

