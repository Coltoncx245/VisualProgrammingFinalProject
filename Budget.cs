using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingFinalProject
{
    internal class Budget
    {
        public string name;

        public List<Income> budgetIncome;
        public List<Expense> budgetExpenses;

        public List<DateRange> payPeriods;             // Date ranges 


        public double totalIncome = 0;                 // Total income for the budget period
        public double totalExpenses = 0;               // Total expenses for the budget period
        public double NetInOut = 0;                    // Total difference between income and expenses for budget period


        // No arg constructor for temp buffer in forms
        public Budget()                         
        {
            this.budgetIncome = new List<Income>();
            this.budgetExpenses = new List<Expense>();
        }                     
        public Budget(List<Income> budgetIncome, List<Expense> budgetExpenses, List<DateRange> payPeriods)
        {
            this.budgetIncome = budgetIncome;
            this.budgetExpenses = budgetExpenses;
            this.payPeriods = payPeriods;

            foreach (Income i in budgetIncome)
            {
                this.totalIncome += i.amount;
            }

            foreach (Expense e in budgetExpenses)
            {
                this.totalExpenses += e.amount;
            }

            this.NetInOut = this.totalIncome - this.totalExpenses;

        }

        public void CalcTotals()
        {
            foreach (Income i in budgetIncome)
            {
                this.totalIncome += i.amount;
            }

            foreach (Expense e in budgetExpenses)
            {
                this.totalExpenses += e.amount;
            }

            this.NetInOut = this.totalIncome - this.totalExpenses;

        }
    }
}
