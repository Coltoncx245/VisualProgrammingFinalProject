using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VisualProgrammingFinalProject
{
    public partial class SelectBudgetForm : Form
    {
        // Gets ref to base form from list of currently active forms
        // Will break if the base form isn't the first in the list, but that *shouldn't* happen
        Form1 baseForm = (Form1)Application.OpenForms[0]; 

        public SelectBudgetForm()
        {
            InitializeComponent();
            foreach (Budget b in Form1.availableBudgets)
            {
                lb_AvailableBudgets.Items.Add(b.name);
            }
            
        }


        private void btn_LoadBudget_Click(object sender, EventArgs e)
        {
            if (lb_AvailableBudgets.Items.Count == 0) //to make sure that the list is not empty
            {
                MessageBox.Show("There are no previous budgets saved. Create a new budget!", "Error");
                this.Close();
            }
            else
            {
                baseForm.SetCurrentBudget(FindBudget(lb_AvailableBudgets.SelectedItem.ToString()));
            }
            
   


        }

        private Budget FindBudget(string name)
        {
            foreach (Budget b in Form1.availableBudgets)
            {
                if (b.name == name) { return b; }
            }

            return null;
        }

        private void btnSaveBudget_Click(object sender, EventArgs e)
        {
            if (lb_AvailableBudgets.Items.Count == 0) //to make sure that the list is not empty
            {
                MessageBox.Show("There are no previous budgets created that can be saved.", "Error");
                this.Close();
            }
            else
            {
                //baseForm.SetCurrentBudget(FindBudget(lb_AvailableBudgets.SelectedItem.ToString()));
                Budget BudgetToSave = null;
                foreach (Budget b in Form1.availableBudgets)
                {
                    if (b.name == lb_AvailableBudgets.SelectedItem.ToString()) { BudgetToSave = b; }
                }

                string budgetName = BudgetToSave.name;

                //path where it will save file on machine: C:\...\VisualProgrammingFinalProject-master\bin\Debug
                string path = budgetName+".txt";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("BUDGET_NAME: ");
                    sw.WriteLine(budgetName);
                    sw.WriteLine("TOTAL_EXPENSES: ");
                    sw.WriteLine(BudgetToSave.totalExpenses);
                    sw.WriteLine("TOTAL_INCOME: ");
                    sw.WriteLine(BudgetToSave.totalIncome);
                    sw.WriteLine("NET_IN_OUT: ");
                    sw.WriteLine(BudgetToSave.NetInOut);
                    sw.WriteLine("");

                    /*sw.WriteLine("BUDGET_INCOME: ");
                    foreach(String b in BudgetToSave.budgetIncome)
                    {
                        sw.WriteLine(b);
                    }
                    sw.WriteLine("");
                    sw.WriteLine("BUDGET_EXPENSES: ");
                    foreach (var b in BudgetToSave.budgetExpenses)
                    {
                        sw.WriteLine(b);
                    }
                    sw.WriteLine("");
                    sw.WriteLine("PAY_PERIODS: ");
                    sw.WriteLine(BudgetToSave.payPeriods); */
              
                }
                //writes full path to messagebox
                string fullPath = Path.GetFullPath(path);
                MessageBox.Show("Your budget: " + path + " has been successfully written to the disk.", path);

            }
        }
    }
}
