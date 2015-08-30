using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        //Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
        //Display them in the standard date format for Canada.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text");
            string input = Console.ReadLine();
            Regex r = new Regex(@"\d{2}.\d{2}.\d{4}");
            MatchCollection matches = r.Matches(input);
            var culture = CultureInfo.CreateSpecificCulture("en-ca");
            for (int i = 0; i < matches.Count; i++)
            {
                DateTime dt = DateTime.ParseExact(matches[i].Value , "dd.MM.yyyy",culture);
                Console.WriteLine(dt);
            }
          
        }
    }
}
