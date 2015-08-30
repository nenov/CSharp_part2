﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and prints on the console its odd lines.
            StreamReader reader = new StreamReader(@"..\..\file.txt");
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if(lineNumber%2==1)
                    Console.WriteLine("Line {0}: {1}",
                        lineNumber, line);
                    line = reader.ReadLine();
                }
            }

        }
    }
}
