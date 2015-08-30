using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveWords
{
    class RemoveWords
    {
        static void Main(string[] args)
        {
            try
            {
                string empty = string.Empty;
                string[] words;
                using (StreamReader reader = new StreamReader("../../words.txt"))
                {
                    words = reader.ReadToEnd().Replace("\r\n", " ").Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    reader.Close();
                }
                string text = string.Empty;
                using (StreamReader reader = new StreamReader("../../file.txt"))
                {
                    text = reader.ReadToEnd();
                    reader.Close();
                }
                StreamWriter streamWriter = new StreamWriter(@"../../file.txt");
                using (streamWriter)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        text = text.Replace(words[i], "");
                    }
                    streamWriter.WriteLine(text);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            finally
            {
                Console.WriteLine("Program is done");
            }

        }
    }
}
