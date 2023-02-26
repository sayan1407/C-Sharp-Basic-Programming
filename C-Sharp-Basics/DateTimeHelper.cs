using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    class DateTimeHelper
    {
        DateTime dateTime;
        public DateTimeHelper(DateTime dt)
        {
            dateTime = dt;
        }
        public DateTime Add(int days)
        {
            return dateTime.AddDays(days);
        }
        public void Compare(DateTime newDt)
        {
            if(DateTime.Compare(dateTime, newDt) > 0)
            {
                Console.WriteLine("1st date is greater than second date");
            }
            else if(DateTime.Compare(dateTime, newDt) < 0)
            {
                Console.WriteLine("second date is greater than first date");

            }
            else
            {
                Console.WriteLine("Two dates are equal");
            }
        }
        public bool CheckLeapYear(int year)
        {
            if (year % 100 == 0 && year % 400 == 0)
                return true;
            else if (year % 100 != 0 && year % 4 == 0)
                return true;
            else
                return false;

        }
        public double DifferenceInYear(DateTime newDt)
        {
            long tick = dateTime.Ticks - newDt.Ticks;
            TimeSpan ts1 = new TimeSpan(tick);
            double years = Math.Floor((ts1.TotalDays)/365.25);

            return years;
        }
    }
}
