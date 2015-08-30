using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            //Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
            Console.WriteLine("Enter the first date:");
            string[] first = Console.ReadLine().Split('.');
            Console.WriteLine("Enter the second date:");
            string[] second = Console.ReadLine().Split('.');
            DateTime firstD = new DateTime(int.Parse(first[2]),int.Parse( first[1]), int.Parse( first[0]));
            DateTime secondD = new DateTime(int.Parse(second[2]), int.Parse(second[1]), int.Parse(second[0]));
            Console.WriteLine((secondD - firstD).TotalDays);
        }
    }
}
