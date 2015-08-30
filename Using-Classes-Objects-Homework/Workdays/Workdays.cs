using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workdays
{
    class Workdays
    {
        static int count(DateTime date)
        {
            DateTime today = DateTime.Now;
            int count = -1;
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2015, 03, 03),
                new DateTime(2015, 04, 29),
                new DateTime(2015, 12, 25),
                // etc
            };
            Console.WriteLine("You are not working on the following holidays:");
            for (int i = 0; i < holidays.Length; i++)
            {
                Console.WriteLine(holidays[i].ToShortDateString());
            }
            while (date.CompareTo(today) > 0)
            {
                today = today.AddDays(1);
                if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
                {
                    bool flag = true;
                    for (int i = 0; i < holidays.Length; i++)
                    {
                        if (today.Date == holidays[0].Date && today.Month == holidays[0].Month) flag = false;
                    }
                    if(flag != false)count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            //Write a method that calculates the number of workdays between today and given date, passed as parameter.
            //Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
            Console.WriteLine("Enter your date in the format MM/DD/YYYY");
            string enteredString;
            enteredString = Console.ReadLine();
            DateTime enteredDate = Convert.ToDateTime(enteredString);

            Console.WriteLine("The number of workdays between today and the entered date is " + count(enteredDate)); ;
        }
    }
}
