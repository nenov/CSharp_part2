using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractTextFromXML
{
    class ExtractTextFromXML
    {
        //Write a program that extracts from given XML file all the text without the tags.
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            string line = string.Empty;

            using (StreamReader reader = new StreamReader(@"../../file.xml"))
            {
                line = reader.ReadToEnd();
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                        if (line[i - 1] == '>' && line[i] != '<')
                        {
                            do
                            {
                                text.Append(line[i]);
                                i++;
                            }
                            while (line[i] != '<');

                            Console.WriteLine(text.ToString());
                            text.Clear();
                        }
                    }
                }
            }
        }
    }
}
