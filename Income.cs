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
        public float amount { get; set; }          // Dollar amount of income
        public Date date { get; set; }              
        public bool recurring { get; set; }        // Income is on a recurring basis



    }
    internal class Paycheck : Income
    {

        public Paycheck(float amountPaid, Date payDate, bool isRecurring = false)
        {
            this.amount = amountPaid;
            this.date = payDate;
            this.recurring = isRecurring;

        }

    }
}
