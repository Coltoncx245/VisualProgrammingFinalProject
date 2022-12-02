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
    public partial class Form1 : Form
    {
        internal static List<Budget> availableBudgets;
        internal Budget currentBudget;
        public Form1()
        {
            InitializeComponent();
            availableBudgets = new List<Budget>(); // Saved budgets available to load into main view form
            lbl_BudgetName.Text = "";
        }

        private void newBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BudgetCreatorForm budgetCreatorForm = new BudgetCreatorForm();
            budgetCreatorForm.ShowDialog();
        }

        private void loadBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectBudgetForm selectBudgetForm = new SelectBudgetForm();
            selectBudgetForm.ShowDialog();
        }

        internal void SetCurrentBudget(Budget b)
        {
            this.currentBudget = b;
            MessageBox.Show("Budget Loaded");



            RefreshBudget();
        }

        internal void RefreshBudget()
        {
            lbl_BudgetName.Text = this.currentBudget.name;
            chart_main.Series["BudgetNet"].Points.AddXY("Total Income", this.currentBudget.totalIncome.ToString());
            chart_main.Series["BudgetNet"].Points.AddXY("Total Expense", this.currentBudget.totalExpenses.ToString());

        }

    }


   
}
