using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class ExtractEmails
    {
        //Write a program for extracting all email addresses from given text.
        //All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text");
            string input = Console.ReadLine();
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex re = new Regex(pattern);
            MatchCollection matches = re.Matches(input);
            for (int i = 0; i < matches.Count; i++)
            {
                System.Console.WriteLine(matches[i]);
            }
            
        }
    }
}
