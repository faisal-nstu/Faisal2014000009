namespace CalculatorApp
{
    partial class CalculatorUI
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
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.resulTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mulButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(174, 22);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNumberTextBox.TabIndex = 2;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(174, 77);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondNumberTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(39, 195);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(187, 195);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(104, 23);
            this.subtractButton.TabIndex = 5;
            this.subtractButton.Text = "SUBTRACT";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // resulTextBox
            // 
            this.resulTextBox.Location = new System.Drawing.Point(174, 133);
            this.resulTextBox.Name = "resulTextBox";
            this.resulTextBox.Size = new System.Drawing.Size(100, 20);
            this.resulTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result";
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(335, 194);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(104, 23);
            this.mulButton.TabIndex = 8;
            this.mulButton.Text = "MULTIPLICATION";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(483, 194);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(104, 23);
            this.divButton.TabIndex = 9;
            this.divButton.Text = "DIVIDE";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 419);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resulTextBox);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorUI";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.TextBox resulTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button divButton;
    }
}

