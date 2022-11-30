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
    public partial class BudgetCreatorForm : Form
    {
        Budget newBudget = new Budget();

        public BudgetCreatorForm()
        {
            InitializeComponent();

        }

        private void btn_AddIncome_Click(object sender, EventArgs e)
        {
            NewIncomeForm nif = new NewIncomeForm(this);
            nif.ShowDialog();
        }

        // Adds Expense to working budget, used for passing data from other forms
        internal void AddExpense(Expense e)
        {
            this.newBudget.budgetExpenses.Add(e);
        }
        // Adds Income to working budget, used for passing data from other forms
        internal void AddIncome(Income I)
        {
            this.newBudget.budgetIncome.Add(I);
        }

        internal void UpdateLists()
        {
            lb_Expenses.Items.Clear();
            lb_Income.Items.Clear();

            foreach (Expense e in newBudget.budgetExpenses)
            {
                lb_Expenses.Items.Add(e.name);
            }
            foreach (Income i in newBudget.budgetIncome)
            {
                lb_Income.Items.Add(i.name);
            }
            
        }

        private void btn_SaveBudget_Click(object sender, EventArgs e)
        {
            if (tb_BudgetName.Text == "")
            {
                MessageBox.Show("Must enter a valid budget name");
            }
            else
            {
                newBudget.name = tb_BudgetName.Text;
                Form1.availableBudgets.Add(newBudget);
                this.Close();
            }
            
        }
    }
}
