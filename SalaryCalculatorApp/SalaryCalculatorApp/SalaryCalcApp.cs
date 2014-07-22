using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalcApp : Form
    {
        Salary aSalary=new Salary();
        public SalaryCalcApp()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            GetValue();
            MessageBox.Show(aSalary.name+" Your salary is: "+aSalary.ShowSalary(aSalary.basicAmount,aSalary.rent,aSalary.medicalAllowance)+ " Taka");
        }

        private void GetValue()
        {
            aSalary.name = nameTextBox.Text;

            aSalary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.rent = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.medicalAllowance = Convert.ToDouble(medicalTextBox.Text);
            
        }
    }
}
