using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            //Write a program that deletes from given text file all odd lines.
            //The result should be in the same file.
            using (StreamReader reader = new StreamReader("../../file.txt"))
            {
                string line = reader.ReadLine();
                StringBuilder text = new StringBuilder();

                int lineNumber = 1;

                while (line != null)
                {
                    if (lineNumber % 2 != 1)
                    {
                        text.Append(line);
                        if (!reader.EndOfStream)
                        {
                            text.Append("\r\n");
                        }
                    }
                    lineNumber++;
                    line = reader.ReadLine();
                }
                reader.Close();
                StreamWriter streamWriter = new StreamWriter(@"../../file.txt");

                using (streamWriter)
                {
                    streamWriter.WriteLine(text);
                }
            }
        }
    }
}
