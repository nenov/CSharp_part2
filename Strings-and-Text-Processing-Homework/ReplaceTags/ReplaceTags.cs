using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            //Write a program that replaces in a HTML document given as string 
            //all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
            Console.WriteLine("Please enter the string");
            string input = Console.ReadLine();
            int startIndex = input.IndexOf("<a href=");
            int finishIndex = input.IndexOf("</a>");
            string[] parts = input.Split(new string[] {"<a href=\"", "</a>"},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++)
            {
                Console.Write(parts[i]);
                if (i % 2 == 0 && i != parts.Length - 1)
                {
                    Console.Write("[URL=");
                    parts [i+1] = parts[i + 1].Replace("\">", "]");
                }
                else if (i != parts.Length - 1) Console.Write("[/URL]");
            }
        }
    }
}
