using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementApp
{
    public partial class CustomerQueueManagementAppUI : Form
    {
        List<Customer> customerList = new List<Customer>();
        private int countEnqueue = 0;
        private int countDequeue = 0;
        private int i = 0;
        public CustomerQueueManagementAppUI()
        {
            InitializeComponent();
        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();

            if (enqueueNameTextBox.Text == "" || enqueueComplainTextbox.Text == "")
            {
                MessageBox.Show("Enter Both Name and Complain");
            }
            else
            {
                countEnqueue++;
                
                aCustomer.customerName = enqueueNameTextBox.Text;
                aCustomer.complain = enqueueComplainTextbox.Text;
                aCustomer.serialNo = countEnqueue;
                customerList.Add(aCustomer);
                AddToListView();
                ClearAllTextBox();
                //MessageBox.Show("Customer Added\nName: " + customerList[countEnqueue - 1].customerName +
                //                "\nComplain: " + customerList[countEnqueue - 1].complain + "\nSerial No.: " + customerList[countEnqueue - 1].serialNo);
                

            }

            

        }

        private void AddToListView()
        {
            queueListView.Items.Clear();

            for (int i = 0; i < countEnqueue; i++)
            {
                if ((i ) < countDequeue)
                    ;
                else if(i == countEnqueue)
                    MessageBox.Show("No more customers");
                else
                {

                    ListViewItem aListViewItem = new ListViewItem();
                    aListViewItem.Text = customerList[i].serialNo.ToString();
                    aListViewItem.SubItems.Add(customerList[i].customerName);
                    aListViewItem.SubItems.Add(customerList[i].complain);
                    queueListView.Items.Add(aListViewItem);
                }

            }

            //foreach (Customer queuedCustomer in customerList)
            //{
            //    ListViewItem aListViewItem = new ListViewItem();
            //    aListViewItem.Text = queuedCustomer.serialNo.ToString();
            //    aListViewItem.SubItems.Add(queuedCustomer.customerName);
            //    aListViewItem.SubItems.Add(queuedCustomer.complain);
            //    queueListView.Items.Add(aListViewItem);
            //} 
        }

        private void ClearAllTextBox()
        {
            enqueueNameTextBox.Text = "";
            enqueueComplainTextbox.Text = "";
        }

        private void dequeueButton_Click(object sender, EventArgs e)
         {
            queueListView.Items.Clear();
            if (countDequeue == countEnqueue)
            {
                MessageBox.Show("No more customers");
                return;
            }

            Customer aCustomer = new Customer();
            aCustomer = customerList[countDequeue];
            serialNoTextBox.Text = aCustomer.serialNo.ToString();
            dequeueNameTextBox.Text = aCustomer.customerName;
            dequeueComplainTextBox.Text = aCustomer.complain;
            countDequeue++;
            

            for (int i = 1; i < countEnqueue; i++)
            {
                if (i < countDequeue)
                    ;
                
                else
                {

                    ListViewItem aListViewItem = new ListViewItem();
                    aListViewItem.Text = customerList[i].serialNo.ToString();
                    aListViewItem.SubItems.Add(customerList[i].customerName);
                    aListViewItem.SubItems.Add(customerList[i].complain);
                    queueListView.Items.Add(aListViewItem);
                }

            }

            



            //foreach (Customer queuedCustomer in customerList)
            //{
                
            //    if ( )
            //    {
            //        MessageBox.Show("Relax ... No More Customer ...");
            //        //return;
            //    }

            //    else
            //    {
            //        //i++;
            //    }
                
            //}
            
        }
    }
}
