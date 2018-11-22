using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeekLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine("Program displays names of days of the week");

            var days = from day in weekDays
                       select day;

            Console.WriteLine("First check by LINQ query:");

            var lambdaDays = weekDays.Select(day => day);
            foreach ( var day in days)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine("Second check by LINQ method:");
            foreach (var day in lambdaDays)
            {
                Console.WriteLine(day);
            }
            Console.ReadKey();
        }
    }
}
