using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main(string[] args)
        {
            //Write a program that reads a date and time given in the format: day.month.year hour:minute:second
            //and prints the date and time 
            //after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
            Console.WriteLine("Enter the date:");
            string[] del = { " ", ".", ":" };
            string[] first = Console.ReadLine().Split(del, StringSplitOptions.RemoveEmptyEntries);
            DateTime date = new DateTime(int.Parse(first[2]), int.Parse(first[1]), int.Parse(first[0]), int.Parse(first[3]), int.Parse(first[4]), int.Parse(first[5]));
            date = date.AddHours(6);
            date = date.AddMinutes(30);
            var culture = CultureInfo.CreateSpecificCulture("bg-BG");
            Console.WriteLine(date);
            Console.WriteLine(new DateTime(date.Year,date.Month, date.Day).DayOfWeek);
        }
    }
}
