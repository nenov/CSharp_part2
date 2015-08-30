using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordsCount
{
    class WordsCount
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console 
            //and lists all different words in the string along with information how many times each word is found.
            Console.WriteLine("Please enter the text");
            string input = Console.ReadLine();
            Dictionary<string, int> letters = new Dictionary<string, int>();
            foreach (var match in Regex.Matches(input, @"\w+"))
            {
                if (!letters.ContainsKey(match.ToString()))
                {
                    letters.Add(match.ToString(), 1);
                }
                else letters[match.ToString()]++;
            }
           
            foreach (var letter in letters)
            {
                Console.WriteLine("Word {0} is contained {1} times", letter.Key, letter.Value);
            }
        }
    }
}
