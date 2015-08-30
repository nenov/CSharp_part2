using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
        static void Main(string[] args)
        {
            //Write a program that converts a string to a sequence of C# Unicode character literals.
            //Use format strings.
            Console.WriteLine("Please enter a string");
            string input = Console.ReadLine();
            foreach (char item in input)
            {
                Console.Write(GetEscapeSequence(item));
            }
            Console.WriteLine();
        }
    }
}
