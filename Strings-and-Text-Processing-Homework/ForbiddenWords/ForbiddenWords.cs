using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenWords
{
    class ForbiddenWords
    {
        //We are given a string containing a list of forbidden words and a text containing some of these words.
        //Write a program that replaces the forbidden words with asterisks.
        //Example text: Microsoft announced its next generation PHP compiler today.
        //It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
        static void Main(string[] args)
        {
            Console.WriteLine("Etner the list of forbidden words");
            string[] words = Console.ReadLine().Split(',');
            for (int i = 0; i < words.Length; i++)
            {
                words [i] = words[i].Trim();
            }
            Console.WriteLine("Enter the text");
            StringBuilder text = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < words.Length; i++)
            {
                text.Replace(words[i], new string('*', words[i].Length));
            }
            Console.WriteLine(text.ToString());
        }
    }
}
