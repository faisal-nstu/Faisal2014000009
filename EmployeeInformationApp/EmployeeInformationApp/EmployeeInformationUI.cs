using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationApp
{
    public partial class EmployeeInformationUI : Form
    {
        Employee anEmployee = new Employee();
        
        public EmployeeInformationUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            anEmployee.id = idTextBox.Text;
            anEmployee.name = nameTextBox.Text;
            anEmployee.salary = Convert.ToDouble(salaryTextBox.Text);

            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
            MessageBox.Show("Employee Information.\nID: " + anEmployee.id + "\nName: " + anEmployee.name + "\nSalary: " + anEmployee.salary);
           
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = anEmployee.id;
            nameTextBox.Text = anEmployee.name;
            salaryTextBox.Text = anEmployee.salary.ToString();

        }
    }
}
