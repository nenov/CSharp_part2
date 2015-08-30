using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubString
{
    class ReplaceSubString
    {
        static void Main(string[] args)
        {
            //Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
            //Ensure it will work with large files (e.g. 100 MB).
            using (StreamReader streamReader = new StreamReader("../../file.txt"))
            {
                using (StreamWriter streamWriter = new StreamWriter("../../Result.txt"))
                {
                    string line = streamReader.ReadLine();

                    while (line != null)
                    {
                        streamWriter.WriteLine(line.Replace("start", "finish"));
                        line = streamReader.ReadLine();
                    }

                    Console.WriteLine("Bye");
                }
            }
        }
    }
}
