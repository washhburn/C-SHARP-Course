using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysUntilChristmas
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Date of today
            var dateToday = DateTime.Today;
            Console.WriteLine($"Date of today is {dateToday:d}.");

            //Date of Christmas Day
            DateTime XmasDay = new DateTime(2025, 12, 25);

            var daysUntilChristmas = (XmasDay - dateToday).Days;

            //Check if today is Christmas Day or how many days are left until Christmas
            if (dateToday == XmasDay)
            {
                Console.WriteLine($"Today is Christmas Day!");
            }
            else if (dateToday < XmasDay)
            {
                Console.WriteLine($"There are {daysUntilChristmas} days until Christmas!");

            }
            else
            {
                Console.WriteLine("Christmas has passed.");
            }

        }
    }
}
