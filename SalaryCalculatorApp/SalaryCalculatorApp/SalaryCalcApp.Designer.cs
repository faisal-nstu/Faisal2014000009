namespace SalaryCalculatorApp
{
    partial class SalaryCalcApp
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
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.basicAmountTextBox = new System.Windows.Forms.TextBox();
            this.houseRentTextBox = new System.Windows.Forms.TextBox();
            this.medicalTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BasicAmount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medical Allowance:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(163, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(322, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // basicAmountTextBox
            // 
            this.basicAmountTextBox.Location = new System.Drawing.Point(163, 101);
            this.basicAmountTextBox.Name = "basicAmountTextBox";
            this.basicAmountTextBox.Size = new System.Drawing.Size(212, 20);
            this.basicAmountTextBox.TabIndex = 5;
            // 
            // houseRentTextBox
            // 
            this.houseRentTextBox.Location = new System.Drawing.Point(163, 145);
            this.houseRentTextBox.Name = "houseRentTextBox";
            this.houseRentTextBox.Size = new System.Drawing.Size(100, 20);
            this.houseRentTextBox.TabIndex = 6;
            // 
            // medicalTextBox
            // 
            this.medicalTextBox.Location = new System.Drawing.Point(163, 189);
            this.medicalTextBox.Name = "medicalTextBox";
            this.medicalTextBox.Size = new System.Drawing.Size(100, 20);
            this.medicalTextBox.TabIndex = 7;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(186, 263);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(189, 23);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show Me Salary";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // SalaryCalcApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 389);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.medicalTextBox);
            this.Controls.Add(this.houseRentTextBox);
            this.Controls.Add(this.basicAmountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryCalcApp";
            this.Text = "Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox basicAmountTextBox;
        private System.Windows.Forms.TextBox houseRentTextBox;
        private System.Windows.Forms.TextBox medicalTextBox;
        private System.Windows.Forms.Button showButton;
    }
}

