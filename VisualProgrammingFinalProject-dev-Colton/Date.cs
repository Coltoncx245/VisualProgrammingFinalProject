using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingFinalProject
{
    internal class Date
    {
        public int year;
        public int month;
        public int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public bool FallsWithin(DateRange range)
        {
            /* Will test if the range between this date and the last day of the 
             * paramater range is smaller that the total paramater range.
             * If so, this date falls within that range
             */


            // Range between this date and the final date in the param range
            DateRange testRange = new DateRange(this, range.dateFinal);

            if (testRange.deltaDays <= range.deltaDays)
            {
                return true;
            }

            else { return false; }
        }
    }


    /// <summary>
    /// A range of dates from an initial value to a final value. 
    /// </summary>
    internal class DateRange
    {
        public Date dateInitial { get; set; }
        public Date dateFinal { get; set; }

        public int deltaDays { get; }               // Number of days between date1 and date2
        public int deltaMonths { get; }             // Number of months between date1 and date2
        public int deltaYears { get; }              // Number of years between date1 and date2
       
        /// <summary>
        /// Generates a range of dates from initial to final date paramaters.
        /// </summary>
        /// <param name="initialDate"></param>
        /// <param name="finalDate"></param>
        public DateRange(Date initialDate, Date finalDate)
        {
            this.dateInitial = initialDate;
            this.dateFinal = finalDate;

            deltaDays = GetDeltaDays(initialDate, finalDate);
            deltaMonths = GetDeltaMonths(initialDate, finalDate);
            deltaYears = GetDeltaYears(initialDate, finalDate);

        }


        /// <summary>Calculates total number of days between initial and final date</summary>
        /// <returns>Integer number of days between initial and final</returns>
        private int GetDeltaDays(Date initial, Date final)
        {
            int totalInitial = 0;
            int totalFinal = 0;

            // Index corresponds to month
            int[] numOfDaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Calculate diff of initial date and base 00000000

            // Years + current month days up to initial
            totalInitial += (initial.year * 365) + initial.day;

            // Add days for each month in range
            for (int i=0; i < initial.month - 1; i++) { totalInitial += numOfDaysInMonth[i]; }

            // Add one day for each leap year in range
            totalInitial += LeapYears(initial);


            // Do same for final date

            totalFinal += (final.year * 365) + final.day;
            for (int i = 0; i < final.month - 1; i++) { totalFinal += numOfDaysInMonth[i]; }
            totalFinal += LeapYears(final);


            // return difference 
            return totalFinal - totalInitial;


        }

        /// <summary>
        /// Calculates number of month changovers between initial and final dates. This means
        /// that passing (December 31 1999, January 1 2000) will return 1 month.
        /// </summary>
        /// <param name="initial"></param>
        /// <param name="final"></param>
        /// <returns>Integer number of months, will return negative if diff is negative</returns>
        private int GetDeltaMonths(Date initial, Date final)
        {
            return ((final.month - initial.month) + (12 * final.year - initial.year));
        }

        /// <summary>Returns number of years between initial and final date</summary>
        private int GetDeltaYears(Date initial, Date final)
        {
            return final.year - initial.year;
        }


        /// <summary>Returns number of leap years of base 0000 to param year.</summary>
        private static int LeapYears(Date date)
        {
            int year = date.year;

            if (date.month <= 2)
            {
                year--;
            }

            // Leap years are evenly divisible by 4, 100, and 400
            return (year / 4 - year / 100 + year / 400);
        }
    }
}
