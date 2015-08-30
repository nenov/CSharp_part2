using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LettersCount
{
    class LettersCount
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and 
            //prints all different letters in the string along with information how many times each letter is found.
            Console.WriteLine("Please enter the text");
            string input = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (char a in input)
            {
                if (!letters.ContainsKey(a))
                {
                    letters.Add(a, 1);
                }
                else letters[a]++;
            }
            foreach(var letter in letters)
            {
                Console.WriteLine("Letter {0} is contained {1} times",letter.Key,letter.Value);
            }
        }
    }
}
