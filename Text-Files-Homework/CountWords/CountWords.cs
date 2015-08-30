using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountWords
{
    class CountWords
    {
        static void Main(string[] args)
        {
            try
            {
                string[] words;
                using (StreamReader reader = new StreamReader("../../words.txt"))
                {
                    words = reader.ReadToEnd().Replace("\r\n", " ").Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    reader.Close();
                }
                int[] counter = new int[words.Length];

                using (StreamReader reader = new StreamReader("../../test.txt"))
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        lineNumber++;

                        for (int index = 0; index < words.Length; index++)
                        {
                            counter[index] += ((Regex
                                .Matches(line, @"\b" + words[index] + @"\b").Count));
                        }

                        line = reader.ReadLine();
                    }
                }

                Array.Sort(counter, words);

                using (StreamWriter writer = new StreamWriter("../../result.txt"))
                {
                    for (int index = words.Length - 1; index >= 0; index--)
                    {
                        writer.WriteLine("{0}: {1}", words[index], counter[index]);
                    }

                }
            }
            catch (Exception mess)
            {
                Console.WriteLine(mess.Message);
            }
            finally
            {
                Console.WriteLine("Program is ready");

            }
        }
    }
}
