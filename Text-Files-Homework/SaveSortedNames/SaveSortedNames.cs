using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
            StreamReader reader = new StreamReader(@"..\..\file.txt");

            using (reader)
            {
                string[] line = reader.ReadToEnd().Split('\n');
                Array.Sort(line);
                StreamWriter streamWriter = new StreamWriter(@"..\..\result.txt");
                Console.WriteLine("Result is:");
                using (streamWriter)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        streamWriter.WriteLine(line[i]);
                        Console.WriteLine(line[i]);

                    }
                }
            }
        }
    }
}
