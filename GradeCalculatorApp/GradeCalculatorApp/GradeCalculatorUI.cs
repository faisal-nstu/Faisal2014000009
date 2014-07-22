using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculatorApp
{
    public partial class GradeCalculatorUI : Form
    {
        Grade aGrade=new Grade();
        public GradeCalculatorUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            GetMarks();
            double averageVal;
            averageVal = aGrade.GetAverage(aGrade.physics, aGrade.chemistry, aGrade.math);
            averageTextBox.Text = averageVal.ToString();
            gradeLetterTextBox.Text = aGrade.GradeLetter(averageVal);
        }

        private void GetMarks()
        {
            aGrade.physics = Convert.ToDouble(physicsTextBox.Text);
            aGrade.chemistry = Convert.ToDouble(chemistryTextBox.Text);
            aGrade.math = Convert.ToDouble(mathTextBox.Text);
        }
    }
}
