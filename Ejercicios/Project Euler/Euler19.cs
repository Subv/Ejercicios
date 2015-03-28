using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Project_Euler
{
    class Euler19
    {
        public bool IsLeap(int year)
        {
            if ((year % 100) == 0) // A century
                return (year % 400) == 0;

            return (year % 4) == 0;
        }

        public void Run()
        {
            int day, count = 0, month = 1, year = 1900, dayOfWeek = 0;
            List<int> Months30 = new List<int>();
            Months30.Add(9); // September
            Months30.Add(6); // June
            Months30.Add(4); // April
            Months30.Add(11); // November
            for (day = 1; ; day++) // January 7 1900 was Sunday
            {
                bool leap = IsLeap(year);
                if (dayOfWeek == 6 && day == 1 && year >= 1901 && year <= 2000)
                    ++count;
                dayOfWeek = (dayOfWeek + 1) % 7;
                if (year > 2000)
                    break;
                // The day will get incremented on next loop iteration
                if (day > 31 && !(Months30.Contains(month) || month == 2))
                {
                    day = 0;
                    ++month;
                }
                else if (month == 2 && day > ( leap ? 29 : 28))
                {
                    day = 0;
                    ++month;
                }
                else if (Months30.Contains(month) && day > 30)
                {
                    day = 0;
                    ++month;
                }

                if (month > 12)
                {
                    ++year;
                    month = 1;
                }
            }

            Console.WriteLine("Result: {0} days", count);
        }
    }
}
