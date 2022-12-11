using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingFinalProject
{
    public partial class NewIncomeBill : Form
    {
        BudgetCreatorForm parentBudgetForm;
        bool _isIncome; // This instance of the form creates an Income obj

        public NewIncomeBill(BudgetCreatorForm parentBudgetForm, bool isIncome)
        {
            InitializeComponent();
            this.parentBudgetForm = parentBudgetForm;
            if (isIncome)
            {
                _isIncome = true;
                this.Text = "New Income";
            }
            else
            {
                _isIncome = false;
                this.Text = "New Expense";
            }
        }

        private void cb_Recurring_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of recurring ud to false when recurring is false
            if (cb_Recurring.Checked) { ud_Recurring.Visible = true; }
            else if (!cb_Recurring.Checked) { ud_Recurring.Visible = false; }
        }

        private void btn_SubmitNewIncomeBill_Click(object sender, EventArgs e)
        {
            
            string entryName = tb_IncomeName.Text;
            double entryAmount = Double.Parse(tb_IncomeAmount.Text);
           
            // Get date values from calendar and create Date obj
            int dateYear = cal_NewIncomeCalendar.SelectionRange.Start.Year;
            int dateMonth = cal_NewIncomeCalendar.SelectionRange.Start.Month;
            int dateDay = cal_NewIncomeCalendar.SelectionRange.Start.Day;
            Date entryDate = new Date(dateYear, dateMonth, dateDay);

            bool recurring = cb_Recurring.Checked;
            string recurringFreq = "";
            if (recurring) { recurringFreq = ud_Recurring.SelectedItem.ToString(); }
            
            // New entry is income
            if (_isIncome)
            {
                
                // Compile info into Income object
                Income newIncome = new Income(entryName, entryAmount, entryDate, recurring, recurringFreq);
                // Push Income object back to budget obj in BudgetCreatorForm
                parentBudgetForm.AddIncome(newIncome);
            }
            
            // New entry is expense
            else
            {
                // Compile info into Expense object
                Expense newExpense = new Expense(entryName, entryAmount, entryDate, recurring);
                // Push Income object back to budget obj in BudgetCreatorForm
                parentBudgetForm.AddExpense(newExpense);
            }


            parentBudgetForm.UpdateLists();
            this.Close();

        }
    }
}
