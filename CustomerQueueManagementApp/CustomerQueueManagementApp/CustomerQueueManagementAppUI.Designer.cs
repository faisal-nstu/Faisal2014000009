namespace CustomerQueueManagementApp
{
    partial class CustomerQueueManagementAppUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.enqueueComplainTextbox = new System.Windows.Forms.TextBox();
            this.enqueueNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serialNoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.dequeueComplainTextBox = new System.Windows.Forms.TextBox();
            this.dequeueNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.queueListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enqueueButton);
            this.groupBox1.Controls.Add(this.enqueueComplainTextbox);
            this.groupBox1.Controls.Add(this.enqueueNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(70, 89);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 4;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // enqueueComplainTextbox
            // 
            this.enqueueComplainTextbox.Location = new System.Drawing.Point(70, 54);
            this.enqueueComplainTextbox.Name = "enqueueComplainTextbox";
            this.enqueueComplainTextbox.Size = new System.Drawing.Size(266, 20);
            this.enqueueComplainTextbox.TabIndex = 3;
            // 
            // enqueueNameTextBox
            // 
            this.enqueueNameTextBox.Location = new System.Drawing.Point(70, 19);
            this.enqueueNameTextBox.Name = "enqueueNameTextBox";
            this.enqueueNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.enqueueNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complain:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serialNoTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dequeueButton);
            this.groupBox2.Controls.Add(this.dequeueComplainTextBox);
            this.groupBox2.Controls.Add(this.dequeueNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(373, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 129);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enqueue Customer";
            // 
            // serialNoTextBox
            // 
            this.serialNoTextBox.Location = new System.Drawing.Point(73, 19);
            this.serialNoTextBox.Name = "serialNoTextBox";
            this.serialNoTextBox.ReadOnly = true;
            this.serialNoTextBox.Size = new System.Drawing.Size(126, 20);
            this.serialNoTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Serial No:";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(261, 17);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 4;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // dequeueComplainTextBox
            // 
            this.dequeueComplainTextBox.Location = new System.Drawing.Point(70, 91);
            this.dequeueComplainTextBox.Name = "dequeueComplainTextBox";
            this.dequeueComplainTextBox.ReadOnly = true;
            this.dequeueComplainTextBox.Size = new System.Drawing.Size(266, 20);
            this.dequeueComplainTextBox.TabIndex = 3;
            // 
            // dequeueNameTextBox
            // 
            this.dequeueNameTextBox.Location = new System.Drawing.Point(73, 54);
            this.dequeueNameTextBox.Name = "dequeueNameTextBox";
            this.dequeueNameTextBox.ReadOnly = true;
            this.dequeueNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.dequeueNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Complain:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.queueListView);
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(716, 223);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Queue";
            // 
            // queueListView
            // 
            this.queueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.queueListView.Location = new System.Drawing.Point(14, 19);
            this.queueListView.Name = "queueListView";
            this.queueListView.Size = new System.Drawing.Size(683, 188);
            this.queueListView.TabIndex = 0;
            this.queueListView.UseCompatibleStateImageBehavior = false;
            this.queueListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No.";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            this.columnHeader3.Width = 300;
            // 
            // CustomerQueueManagementAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 385);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerQueueManagementAppUI";
            this.Text = "Customer Queue Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enqueueComplainTextbox;
        private System.Windows.Forms.TextBox enqueueNameTextBox;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox dequeueComplainTextBox;
        private System.Windows.Forms.TextBox dequeueNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox serialNoTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView queueListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

