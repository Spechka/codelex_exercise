using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise14
{
    internal class Date
    {
        public static string WeekdayInDutch(int year, int month, int day)
        {
            DateTime dateValue = new DateTime(year, month, day);
            return dateValue.ToString("dddd", new CultureInfo("nl-NL"));
        }
    }
}
