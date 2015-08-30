using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        //Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text");
            string input = Console.ReadLine();
            foreach (var match in Regex.Matches(input, @"\w+"))
            {
                bool flag = true;
                for (int i = 0; i < match.ToString().Length; i++)
                {
                    if (!(match.ToString()[i] == match.ToString()[match.ToString().Length - i - 1]) && flag ==true) flag = false;
                }
                if (flag == true) Console.WriteLine(match.ToString());
            }
        }
    }
}
