using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and inserts line numbers in front of each of its lines.
            //The result should be written to another text file.
            StreamReader reader = new StreamReader(@"..\..\file.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                StreamWriter streamWriter = new StreamWriter(@"..\..\result.txt");
                using (streamWriter)
                {
                    int lineNumber = 1;

                    while (line != null)
                    {
                        streamWriter.WriteLine(lineNumber + "." + line);
                        lineNumber++;
                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}
