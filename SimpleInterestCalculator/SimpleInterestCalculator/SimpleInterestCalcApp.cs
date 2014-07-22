using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestCalculator
{
    public partial class SimpleInterestCalcApp : Form
    {
        AccountInfo anAccountInfo = new AccountInfo();
        public SimpleInterestCalcApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(CalculateInterest().ToString());
            anAccountInfo.principalAmount = Convert.ToDouble(amountTextBox.Text);
            anAccountInfo.rate = Convert.ToDouble(rateTextBox.Text);
            anAccountInfo.timePeriod = Convert.ToInt32(timeTextBox.Text);
            resultLabel.Text = "Result: " + anAccountInfo.CalculateInterest();
        }

        
    }
}
