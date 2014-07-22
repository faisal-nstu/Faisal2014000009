using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeloWorldInDesktopApplication
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int value1, value2, result;
            value1 = Convert.ToInt32(textBox1.Text);
            value2 = Convert.ToInt32(textBox2.Text);

            result = value1 + value2;

            textBox3.Text = result.ToString();
        }


       
    }
}
