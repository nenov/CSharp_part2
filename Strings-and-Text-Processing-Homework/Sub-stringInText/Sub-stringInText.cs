using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub_stringInText
{
    class Program
    {
        //Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
        //Example:

        //The target sub-string is 'in'

        //The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

        //The result is: 9

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string input = Console.ReadLine();
            Console.WriteLine("Please enter a sub string");
            string part = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < input.Length - part.Length; i++)
            {
                if (input.Substring(i, part.Length).ToLower() == part.ToLower()) count++;
            }
            Console.WriteLine(count);
        }
    }
}
