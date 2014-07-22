namespace DailyExpenseApp
{
    partial class DailyExpenseUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyExpenseUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.categorySaveComboBox = new System.Windows.Forms.ComboBox();
            this.particularTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showSummeryButton = new System.Windows.Forms.Button();
            this.maximumExpenseTextBox = new System.Windows.Forms.TextBox();
            this.totalExpenseTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showCategorywiseListBox = new System.Windows.Forms.ListBox();
            this.showCategorywiseButton = new System.Windows.Forms.Button();
            this.categoryShowComboBox = new System.Windows.Forms.ComboBox();
            this.totalCategorywiseTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.categorySaveComboBox);
            this.groupBox1.Controls.Add(this.particularTextBox);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Expense Entry";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(241, 204);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(74, 25);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // categorySaveComboBox
            // 
            this.categorySaveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorySaveComboBox.FormattingEnabled = true;
            this.categorySaveComboBox.Location = new System.Drawing.Point(74, 47);
            this.categorySaveComboBox.Name = "categorySaveComboBox";
            this.categorySaveComboBox.Size = new System.Drawing.Size(241, 21);
            this.categorySaveComboBox.TabIndex = 1;
            // 
            // particularTextBox
            // 
            this.particularTextBox.Location = new System.Drawing.Point(74, 74);
            this.particularTextBox.Multiline = true;
            this.particularTextBox.Name = "particularTextBox";
            this.particularTextBox.Size = new System.Drawing.Size(241, 124);
            this.particularTextBox.TabIndex = 2;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(74, 19);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(241, 20);
            this.amountTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Particular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showSummeryButton);
            this.groupBox2.Controls.Add(this.maximumExpenseTextBox);
            this.groupBox2.Controls.Add(this.totalExpenseTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Summery";
            // 
            // showSummeryButton
            // 
            this.showSummeryButton.Location = new System.Drawing.Point(241, 19);
            this.showSummeryButton.Name = "showSummeryButton";
            this.showSummeryButton.Size = new System.Drawing.Size(74, 25);
            this.showSummeryButton.TabIndex = 0;
            this.showSummeryButton.Text = "Show";
            this.showSummeryButton.UseVisualStyleBackColor = true;
            this.showSummeryButton.Click += new System.EventHandler(this.showSummeryButton_Click);
            // 
            // maximumExpenseTextBox
            // 
            this.maximumExpenseTextBox.Location = new System.Drawing.Point(138, 95);
            this.maximumExpenseTextBox.Name = "maximumExpenseTextBox";
            this.maximumExpenseTextBox.ReadOnly = true;
            this.maximumExpenseTextBox.Size = new System.Drawing.Size(177, 20);
            this.maximumExpenseTextBox.TabIndex = 6;
            // 
            // totalExpenseTextBox
            // 
            this.totalExpenseTextBox.Location = new System.Drawing.Point(138, 57);
            this.totalExpenseTextBox.Name = "totalExpenseTextBox";
            this.totalExpenseTextBox.ReadOnly = true;
            this.totalExpenseTextBox.Size = new System.Drawing.Size(177, 20);
            this.totalExpenseTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maximum Expense";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Expense";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showCategorywiseListBox);
            this.groupBox3.Controls.Add(this.showCategorywiseButton);
            this.groupBox3.Controls.Add(this.categoryShowComboBox);
            this.groupBox3.Controls.Add(this.totalCategorywiseTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(339, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 377);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Categorywise Expense";
            // 
            // showCategorywiseListBox
            // 
            this.showCategorywiseListBox.FormattingEnabled = true;
            this.showCategorywiseListBox.Location = new System.Drawing.Point(6, 81);
            this.showCategorywiseListBox.Name = "showCategorywiseListBox";
            this.showCategorywiseListBox.Size = new System.Drawing.Size(363, 264);
            this.showCategorywiseListBox.TabIndex = 10;
            // 
            // showCategorywiseButton
            // 
            this.showCategorywiseButton.Location = new System.Drawing.Point(295, 50);
            this.showCategorywiseButton.Name = "showCategorywiseButton";
            this.showCategorywiseButton.Size = new System.Drawing.Size(74, 25);
            this.showCategorywiseButton.TabIndex = 1;
            this.showCategorywiseButton.Text = "Show";
            this.showCategorywiseButton.UseVisualStyleBackColor = true;
            this.showCategorywiseButton.Click += new System.EventHandler(this.showCategorywiseButton_Click);
            // 
            // categoryShowComboBox
            // 
            this.categoryShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryShowComboBox.FormattingEnabled = true;
            this.categoryShowComboBox.Location = new System.Drawing.Point(61, 19);
            this.categoryShowComboBox.Name = "categoryShowComboBox";
            this.categoryShowComboBox.Size = new System.Drawing.Size(308, 21);
            this.categoryShowComboBox.TabIndex = 0;
            // 
            // totalCategorywiseTextBox
            // 
            this.totalCategorywiseTextBox.Location = new System.Drawing.Point(247, 351);
            this.totalCategorywiseTextBox.Name = "totalCategorywiseTextBox";
            this.totalCategorywiseTextBox.ReadOnly = true;
            this.totalCategorywiseTextBox.Size = new System.Drawing.Size(122, 20);
            this.totalCategorywiseTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category";
            // 
            // DailyExpenseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 401);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(740, 440);
            this.Name = "DailyExpenseUI";
            this.Text = "Daily Expanse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox categorySaveComboBox;
        private System.Windows.Forms.TextBox particularTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button showSummeryButton;
        private System.Windows.Forms.TextBox maximumExpenseTextBox;
        private System.Windows.Forms.TextBox totalExpenseTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox showCategorywiseListBox;
        private System.Windows.Forms.Button showCategorywiseButton;
        private System.Windows.Forms.ComboBox categoryShowComboBox;
        private System.Windows.Forms.TextBox totalCategorywiseTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

