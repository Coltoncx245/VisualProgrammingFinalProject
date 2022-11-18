using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingFinalProject
{
    internal class Income
    {
        public string name;
        public double amount;         // Dollar amount of income
        public Date date;            // Date income is expected
        public bool recurring;       // Income is on a recurring basis

        string recurringFrequency;      // How often income recurs, i.e. weekly, monthly, etc

        public Income(string name, double amount, Date date, bool recurring, string recurringFrequency = "")
        {
            this.name = name;
            this.amount = amount;
            this.date = date;
            this.recurring = recurring;
            this.recurringFrequency = recurringFrequency;
        }
    }

}
