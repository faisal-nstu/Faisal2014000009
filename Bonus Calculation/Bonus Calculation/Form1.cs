using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonus_Calculation
{
    public partial class EmployeeSalary : Form
    {
        public EmployeeSalary()
        {
            InitializeComponent();
        }


        private void showButton_Click(object sender, EventArgs e)
        {
            Double salaryAmount=Convert.ToDouble(salaryTextBox.Text);
            Double bonus;
            if(salaryAmount>10000){
                bonus = salaryAmount * .05;

            }
            else if( salaryAmount>=8000 && salaryAmount<=10000){
                bonus = salaryAmount * .06;


            }
            else
            {

                bonus = salaryAmount * .07;
            }

            bonusTextBox.Text = bonus.ToString();
            totalAmountTextBox.Text = (salaryAmount + bonus).ToString();
        }
    }
}
