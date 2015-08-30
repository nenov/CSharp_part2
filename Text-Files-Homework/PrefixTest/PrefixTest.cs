using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrefixTest
{
    class PrefixTest
    {
        static void Main(string[] args)
        {
            //Write a program that deletes from a text file all words that start with the prefix test.
            //Words contain only the symbols 0…9, a…z, A…Z, _.
            string line = string.Empty;
            string empty = string.Empty;
            using (StreamReader reader = new StreamReader("../../file.txt"))
            {
                line = reader.ReadToEnd();

                reader.Close();

            }
            StreamWriter streamWriter = new StreamWriter(@"../../output.txt");

            using (streamWriter)
            {
                streamWriter.WriteLine(Regex.Replace(line, @"\btest([a-zA-Z0-9_]*)\b", empty));
            }
        }
    }
}
