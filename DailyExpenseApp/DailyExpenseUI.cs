using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CSVLib;

namespace DailyExpenseApp
{
    public partial class DailyExpenseUI : Form
    {
        private string databasePath = @"DailyExpenseDatabase.csv";

        enum ExpenseCategory
        {
            HouseRent,
            UtilityBill,
            Conveyance,
            Grocery,
            Misc
        }

        public DailyExpenseUI()
        {
            InitializeComponent();

            categorySaveComboBox.DataSource = Enum.GetNames(typeof (ExpenseCategory));
            categoryShowComboBox.DataSource = Enum.GetNames(typeof(ExpenseCategory));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(amountTextBox.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Amount number is invalid!");
                return;
            }

            FileStream expenseFileStream = new FileStream(databasePath, FileMode.Append);
            CsvFileWriter csvWriter = new CsvFileWriter(expenseFileStream);
            List<string> expenseData = new List<string>();

            expenseData.Add(amountTextBox.Text);
            expenseData.Add((string)categorySaveComboBox.SelectedItem);
            expenseData.Add(particularTextBox.Text);
            csvWriter.WriteRow(expenseData);

            MessageBox.Show("Successully Saved!");
            amountTextBox.Text = string.Empty;
            particularTextBox.Text = string.Empty;
            expenseFileStream.Close();
        }

        private void showSummeryButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(databasePath))
            {
                FileStream expenseFileStream = new FileStream(databasePath, FileMode.Open);
                CsvFileReader csvReader = new CsvFileReader(expenseFileStream);
                List<string> expenseData = new List<string>();

                double amount = 0;
                double totalExpense = 0;
                double maximumExpense = 0;
                while (csvReader.ReadRow(expenseData))
                {
                    amount = Convert.ToDouble(expenseData[0]);
                    totalExpense += amount;
                    if (amount > maximumExpense)
                    {
                        maximumExpense = amount;
                    }
                }
                expenseFileStream.Close();

                totalExpenseTextBox.Text = totalExpense.ToString();
                maximumExpenseTextBox.Text = maximumExpense.ToString();
            }
        }

        private void showCategorywiseButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(databasePath))
            {
                FileStream expenseFileStream = new FileStream(databasePath, FileMode.Open);
                CsvFileReader csvReader = new CsvFileReader(expenseFileStream);
                List<string> expenseData = new List<string>();

                ExpenseCategory selectedCategory =
                    (ExpenseCategory) Enum.Parse(typeof (ExpenseCategory), (string) categoryShowComboBox.SelectedItem);

                string particular = string.Empty;
                string amountString = string.Empty;
                double amount = 0;
                double totalExpense = 0;

                showCategorywiseListBox.Items.Clear();
                showCategorywiseListBox.Items.Add("Perticular" + "\t\t" + "Amount");
                showCategorywiseListBox.Items.Add("-------------------------------------------");
                while (csvReader.ReadRow(expenseData))
                {
                    ExpenseCategory category = (ExpenseCategory)Enum.Parse(typeof(ExpenseCategory), expenseData[1]);

                    if (selectedCategory == ExpenseCategory.HouseRent)
                    {
                        if (category == ExpenseCategory.HouseRent)
                        {
                            amountString = expenseData[0];
                            particular = expenseData[2];
                            amount = Convert.ToDouble(amountString);
                            showCategorywiseListBox.Items.Add(particular + "\t\t" + amount);
                            totalExpense += amount;
                        }
                    }
                    else if (selectedCategory == ExpenseCategory.UtilityBill)
                    {
                        if (category == ExpenseCategory.UtilityBill)
                        {
                            amountString = expenseData[0];
                            particular = expenseData[2];
                            amount = Convert.ToDouble(amountString);
                            showCategorywiseListBox.Items.Add(particular + "\t\t" + amount);
                            totalExpense += amount;
                        }
                    }
                    else if (selectedCategory == ExpenseCategory.Conveyance)
                    {
                        if (category == ExpenseCategory.Conveyance)
                        {
                            amountString = expenseData[0];
                            particular = expenseData[2];
                            amount = Convert.ToDouble(amountString);
                            showCategorywiseListBox.Items.Add(particular + "\t\t" + amount);
                            totalExpense += amount;
                        }
                    }
                    else if (selectedCategory == ExpenseCategory.Grocery)
                    {
                        if (category == ExpenseCategory.Grocery)
                        {
                            amountString = expenseData[0];
                            particular = expenseData[2];
                            amount = Convert.ToDouble(amountString);
                            showCategorywiseListBox.Items.Add(particular + "\t\t" + amount);
                            totalExpense += amount;
                        }
                    }
                    else if (selectedCategory == ExpenseCategory.Misc)
                    {
                        if (category == ExpenseCategory.Misc)
                        {
                            amountString = expenseData[0];
                            particular = expenseData[2];
                            amount = Convert.ToDouble(amountString);
                            showCategorywiseListBox.Items.Add(particular + "\t\t" + amount);
                            totalExpense += amount;
                        }
                    }
                }
                totalCategorywiseTextBox.Text = totalExpense.ToString();
                expenseFileStream.Close();
            }

        }
    }
}
