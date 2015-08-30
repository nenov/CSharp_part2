using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            //Write a program that reads a year from the console and checks whether it is a leap one.
            //Use System.DateTime.
            Console.WriteLine("Please enter an year (such as 1991):");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(  DateTime.IsLeapYear(year));
        }
    }
}
