using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingFinalProject
{
    internal class Expense
    {
        public float amount { get; set; }
        public Date date { get; set; }
        public bool recurring { get; set; }

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
