using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            //Write a program that prints to the console which day of the week is today.
            //Use System.DateTime.
            Console.WriteLine("Today is " + DateTime.Today.DayOfWeek);
        }
    }
}
