using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            //Write a program that concatenates two text files into another text file.
            StreamReader reader = new StreamReader(@"..\..\file.txt");
            string fileContents = reader.ReadToEnd();
            reader = new StreamReader(@"..\..\file2.txt");
            string fileContents2 = reader.ReadToEnd();
            StreamWriter streamWriter = new StreamWriter("result.txt");
            using (streamWriter)
            {
                    streamWriter.WriteLine(fileContents + fileContents2);
            }
        }
    }
}
