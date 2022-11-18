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
        List<Budget> availableBudgets; // Saved budgets available to load into main view form
        public Form1()
        {
            InitializeComponent();
        }

        private void newBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BudgetCreatorForm budgetCreatorForm = new BudgetCreatorForm();
            budgetCreatorForm.ShowDialog();
        }
    }
}
