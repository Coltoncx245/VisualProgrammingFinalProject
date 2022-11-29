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
        public float amount;            // Dollar amount of expense
        public Date date;               // Date of expense
        public bool recurring;          // Expense is recurring

    }

    internal class Bill : Expense
    {
        public Bill(float billAmount, Date billDate, bool isRecurring = false)
        {
            this.amount = billAmount;
            this.date = billDate;
            this.recurring = isRecurring;
        }
    }
}
