using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class ReverseSentence
    {
        //Write a program that reverses the words in given sentence.

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            StringBuilder input = new StringBuilder(Console.ReadLine());
            string[] sep = { " ", ", ", "!", ".", "?" };
            string[] words = input.ToString().Split(sep,StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            var regex = new Regex(Regex.Escape("o"));
            for (int i = 0; i < words.Length; i++)
            {
                input.Replace(words[i],words[words.Length-i-1],count,input.Length-count);
                count += words[words.Length - i - 1].Length ;

                int index = input.ToString().IndexOf(words[i]);

                input.Remove(index, words[.Length);
                sb.Insert(index, "New");
            }
            Console.WriteLine(input.ToString());
        }
    }
}
