using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingFinalProject
{
    internal class Expense
    {
        public string name;
        public double amount;            // Dollar amount of expense
        public Date date;               // Date of expense
        public bool recurring;          // Expense is recurring

        public Expense(string name, double amount, Date date, bool recurring)
        {
            this.name = name;
            this.amount = amount;
            this.date = date;
            this.recurring = recurring;
        }
    }


}
