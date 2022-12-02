using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (FindBudget(lb_AvailableBudgets.SelectedItem.ToString()) != null)
            {
                baseForm.SetCurrentBudget(FindBudget(lb_AvailableBudgets.SelectedItem.ToString()));
            }
            else
            {
                MessageBox.Show("Error, null budget");
            }

            this.Close();

        }

        private Budget FindBudget(string name)
        {
            foreach (Budget b in Form1.availableBudgets)
            {
                if (b.name == name) { return b; }
            }

            return null;
        }
    }
}
