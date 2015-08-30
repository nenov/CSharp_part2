using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            //You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
            //The tags cannot be nested.
            Console.WriteLine("Please enter the text");
            string input = Console.ReadLine();
            string[] tag = { "<upcase>", "</upcase>" };
            string newOne = "";

            string[] array = input.Split(tag, StringSplitOptions.None);
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) newOne += array[i];
                else newOne += array[i].ToUpper();
            }

            Console.WriteLine(newOne);
        }
    }
}
