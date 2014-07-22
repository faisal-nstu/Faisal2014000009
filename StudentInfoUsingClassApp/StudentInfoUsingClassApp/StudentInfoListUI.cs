using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoUsingClassApp
{
    public partial class StudentInfoListUI : Form
    {
        List<Student> studentList = new List<Student>(); 
        public StudentInfoListUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();

            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            ClearAll();
            
            studentList.Add(aStudent);
            MessageBox.Show("Student Added.\nFirst Name: " + studentList[0].firstName + "\nLast Name: " + studentList[0].lastName + "\nReg no: " + studentList[0].regNo);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            regNoTextBox.Text = "";
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            studentListview.Items.Clear();
            foreach (Student aStudent in studentList)
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = aStudent.regNo;
                aListViewItem.SubItems.Add(aStudent.firstName);
                aListViewItem.SubItems.Add(aStudent.lastName);
                studentListview.Items.Add(aListViewItem);
            }
        }

        public void ClearAll()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            regNoTextBox.Text = "";
        }
    }
}
