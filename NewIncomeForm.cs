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
    public partial class NewIncomeForm : Form
    {
        BudgetCreatorForm parentBudgetForm;
        public NewIncomeForm(BudgetCreatorForm parentBudgetForm)
        {
            InitializeComponent();
            this.parentBudgetForm = parentBudgetForm;
        }

        private void cb_Recurring_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility of recurring ud to false when recurring is false
            if (cb_Recurring.Checked) { ud_Recurring.Visible = true; }
            else if (!cb_Recurring.Checked) { ud_Recurring.Visible = false; }
        }

        private void btn_SubmitNewIncome_Click(object sender, EventArgs e)
        {
            string incomeName = tb_IncomeName.Text;
            double incomeAmount = Double.Parse(tb_IncomeAmount.Text);
           
            // Get date values from calendar and create Date obj
            int dateYear = cal_NewIncomeCalendar.SelectionRange.Start.Year;
            int dateMonth = cal_NewIncomeCalendar.SelectionRange.Start.Month;
            int dateDay = cal_NewIncomeCalendar.SelectionRange.Start.Day;
            Date incomeDate = new Date(dateYear, dateMonth, dateDay);

            bool recurring = cb_Recurring.Checked;
            string recurringFreq = "";
            if (recurring) { recurringFreq = ud_Recurring.SelectedItem.ToString(); }
            
            // Compile info into Income object
            Income newIncome = new Income(incomeName, incomeAmount, incomeDate, recurring, recurringFreq);

            // Push Income object back to budget obj in BudgetCreatorForm
            parentBudgetForm.AddIncome(newIncome);
            parentBudgetForm.UpdateLists();
            this.Close();

        }
    }
}
