using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IterativeListViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(itemTextBox.Text);
            int j= 0;
            while (j < i)
            {
                itemListBox.Items.Add(j);
                j++;
            }
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(itemListBox.Text);
        }

        
    }
}
