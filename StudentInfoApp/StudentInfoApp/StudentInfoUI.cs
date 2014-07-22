using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApp
{
    
    public partial class StudentInfoUI : Form
    {
        Student aStudent = new Student();
        public StudentInfoUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            aStudent.regNo = regNoTextBox.Text;
            ClearAllTextBoxes();
            MessageBox.Show(aStudent.GetFullName() + ", your Registration No. is : " + aStudent.regNo);
            

        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = aStudent.firstName;
            lastNameTextBox.Text = aStudent.lastName;
            regNoTextBox.Text = aStudent.regNo;
        }

        private void ClearAllTextBoxes()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            regNoTextBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }
    }
}
