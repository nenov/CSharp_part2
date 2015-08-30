using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            //Write a program that compares two text files line by line and prints the number of lines
            //that are the same and the number of lines that are different.
            //Assume the files have equal number of lines.
            StreamReader reader = new StreamReader(@"..\..\file.txt");
            StreamReader reader2 = new StreamReader(@"..\..\file2.txt");
            int countSame = 0;
            int countNot = 0;
            using (reader)
            {
                string line = reader.ReadLine();
                string line2 = reader2.ReadLine();
                while (line != null)
                {
                    if (line == line2) countSame++;
                    else countNot++;
                    line = reader.ReadLine();
                    line2 = reader2.ReadLine();
                }
            }
            Console.WriteLine("Number is same lines :"+countSame);
            Console.WriteLine("Number of different lines :"+countNot);
        }

    }
}

