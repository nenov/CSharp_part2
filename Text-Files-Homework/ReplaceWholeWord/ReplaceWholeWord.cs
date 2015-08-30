using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceWholeWord
{
    class ReplaceWholeWord
    {
        static void Main(string[] args)
        {
            //Modify the solution of the previous problem to replace only whole words (not strings).
            using (StreamReader streamReader = new StreamReader("../../file.txt"))
            {
                using (StreamWriter streamWriter = new StreamWriter("../../Result.txt"))
                {
                    string line = streamReader.ReadLine();

                    while (line != null)
                    {
                            streamWriter.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                            line = streamReader.ReadLine();
                    }

                    Console.WriteLine("Bye");
                }
            }
        }
    }
}
