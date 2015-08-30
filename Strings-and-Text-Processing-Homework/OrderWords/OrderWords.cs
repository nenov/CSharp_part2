using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrderWords
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            //Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
            Console.WriteLine("Please enter a list of words, separated by spaces");
            string input = Console.ReadLine();
            List<string> StringList = new List<string>();
            foreach (var match in Regex.Matches(input, @"\w+")) StringList.Add(match.ToString());
            StringList.Sort();
            foreach (string a in StringList) Console.WriteLine(a);
            
        }
    }
}
