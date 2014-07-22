namespace CustomerAndAccountApp
{
    partial class CustomerAccAppUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerNameInputTextBox = new System.Windows.Forms.TextBox();
            this.emailInoputTextBox = new System.Windows.Forms.TextBox();
            this.accountnoInputTextBox = new System.Windows.Forms.TextBox();
            this.openingDateInputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.amountInputTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.showBalanceTextBox = new System.Windows.Forms.TextBox();
            this.showOpeningDateTextBox = new System.Windows.Forms.TextBox();
            this.showAccountNoTextBox = new System.Windows.Forms.TextBox();
            this.showEmailTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.showCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Account No.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Opening Date:";
            // 
            // customerNameInputTextBox
            // 
            this.customerNameInputTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.customerNameInputTextBox.Location = new System.Drawing.Point(116, 36);
            this.customerNameInputTextBox.Name = "customerNameInputTextBox";
            this.customerNameInputTextBox.Size = new System.Drawing.Size(156, 22);
            this.customerNameInputTextBox.TabIndex = 0;
            // 
            // emailInoputTextBox
            // 
            this.emailInoputTextBox.Location = new System.Drawing.Point(116, 85);
            this.emailInoputTextBox.Name = "emailInoputTextBox";
            this.emailInoputTextBox.Size = new System.Drawing.Size(156, 22);
            this.emailInoputTextBox.TabIndex = 1;
            // 
            // accountnoInputTextBox
            // 
            this.accountnoInputTextBox.Location = new System.Drawing.Point(116, 146);
            this.accountnoInputTextBox.Name = "accountnoInputTextBox";
            this.accountnoInputTextBox.Size = new System.Drawing.Size(156, 22);
            this.accountnoInputTextBox.TabIndex = 2;
            // 
            // openingDateInputTextBox
            // 
            this.openingDateInputTextBox.Location = new System.Drawing.Point(116, 195);
            this.openingDateInputTextBox.Name = "openingDateInputTextBox";
            this.openingDateInputTextBox.Size = new System.Drawing.Size(156, 22);
            this.openingDateInputTextBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.openingDateInputTextBox);
            this.groupBox2.Controls.Add(this.accountnoInputTextBox);
            this.groupBox2.Controls.Add(this.emailInoputTextBox);
            this.groupBox2.Controls.Add(this.customerNameInputTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(27, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 271);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer and Account Info";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(197, 231);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withdrawButton);
            this.groupBox1.Controls.Add(this.depositButton);
            this.groupBox1.Controls.Add(this.amountInputTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(27, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(208, 72);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(208, 28);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 1;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // amountInputTextBox
            // 
            this.amountInputTextBox.Location = new System.Drawing.Point(77, 28);
            this.amountInputTextBox.Name = "amountInputTextBox";
            this.amountInputTextBox.Size = new System.Drawing.Size(119, 22);
            this.amountInputTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showButton);
            this.groupBox3.Controls.Add(this.showBalanceTextBox);
            this.groupBox3.Controls.Add(this.showOpeningDateTextBox);
            this.groupBox3.Controls.Add(this.showAccountNoTextBox);
            this.groupBox3.Controls.Add(this.showEmailTextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.showCustomerNameTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(336, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 271);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer and Account Info";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(238, 21);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(220, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show Me Data";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showBalanceTextBox
            // 
            this.showBalanceTextBox.Location = new System.Drawing.Point(238, 231);
            this.showBalanceTextBox.Name = "showBalanceTextBox";
            this.showBalanceTextBox.ReadOnly = true;
            this.showBalanceTextBox.Size = new System.Drawing.Size(220, 22);
            this.showBalanceTextBox.TabIndex = 5;
            // 
            // showOpeningDateTextBox
            // 
            this.showOpeningDateTextBox.Location = new System.Drawing.Point(238, 193);
            this.showOpeningDateTextBox.Name = "showOpeningDateTextBox";
            this.showOpeningDateTextBox.ReadOnly = true;
            this.showOpeningDateTextBox.Size = new System.Drawing.Size(220, 22);
            this.showOpeningDateTextBox.TabIndex = 4;
            // 
            // showAccountNoTextBox
            // 
            this.showAccountNoTextBox.Location = new System.Drawing.Point(238, 153);
            this.showAccountNoTextBox.Name = "showAccountNoTextBox";
            this.showAccountNoTextBox.ReadOnly = true;
            this.showAccountNoTextBox.Size = new System.Drawing.Size(220, 22);
            this.showAccountNoTextBox.TabIndex = 3;
            // 
            // showEmailTextBox
            // 
            this.showEmailTextBox.Location = new System.Drawing.Point(238, 99);
            this.showEmailTextBox.Name = "showEmailTextBox";
            this.showEmailTextBox.ReadOnly = true;
            this.showEmailTextBox.Size = new System.Drawing.Size(220, 22);
            this.showEmailTextBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Balance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Opening Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Customer Name:";
            // 
            // showCustomerNameTextBox
            // 
            this.showCustomerNameTextBox.Location = new System.Drawing.Point(238, 59);
            this.showCustomerNameTextBox.Name = "showCustomerNameTextBox";
            this.showCustomerNameTextBox.ReadOnly = true;
            this.showCustomerNameTextBox.Size = new System.Drawing.Size(220, 22);
            this.showCustomerNameTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Account No.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // CustomerAccAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 428);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "CustomerAccAppUI";
            this.Text = "Customer and Account";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerNameInputTextBox;
        private System.Windows.Forms.TextBox emailInoputTextBox;
        private System.Windows.Forms.TextBox accountnoInputTextBox;
        private System.Windows.Forms.TextBox openingDateInputTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox amountInputTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox showBalanceTextBox;
        private System.Windows.Forms.TextBox showOpeningDateTextBox;
        private System.Windows.Forms.TextBox showAccountNoTextBox;
        private System.Windows.Forms.TextBox showEmailTextBox;
        private System.Windows.Forms.TextBox showCustomerNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

