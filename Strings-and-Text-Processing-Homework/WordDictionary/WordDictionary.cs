using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDictionary
{
    class WordDictionary
    {
        static void Main(string[] args)
        {
            //A dictionary is stored as a sequence of text lines containing words and their explanations.
            //Write a program that enters a word and translates it by using the dictionary.

            Dictionary<string, string> dictionary =
                new Dictionary<string, string>();

            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");
            Console.WriteLine("Please enter a word");
            string word = Console.ReadLine();
            // See whether Dictionary contains this string.
            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine(dictionary[word]);
            }

        }
    }
}
