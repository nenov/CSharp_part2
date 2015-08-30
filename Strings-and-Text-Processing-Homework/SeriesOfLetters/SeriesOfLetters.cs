using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console 
            //and replaces all series of consecutive identical letters with a single one.
            Console.WriteLine("Please enter a string");
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            char last = ' ';
            foreach(char a in input)
            {
                if (char.IsLetter(a) && a != last) result.Append(a);
                else if (!char.IsLetter(a)) result.Append(a);
                last = a;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
