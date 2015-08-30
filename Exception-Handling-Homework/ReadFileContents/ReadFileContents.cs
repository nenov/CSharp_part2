using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileContents
{
    class ReadFileContents
    {
        static void Main(string[] args)
        {
            //Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
            //reads its contents and prints it on the console.
            //Find in MSDN how to use System.IO.File.ReadAllText(…).
            //Be sure to catch all possible exceptions and print user-friendly error messages.
            Console.WriteLine(@"Please enter the full file path(e.g. C:\WINDOWS\win.ini)");
            string path = Console.ReadLine();
            //if (!File.Exists(path))
            //{
            //    // Create a file to write to. 
            //    string createText = "Hello and Welcome" + Environment.NewLine;
            //    File.WriteAllText(path, createText);
            //}
            try
            {
                string text =File.ReadAllText(path);
                Console.WriteLine( text);
            }
            catch (Exception mess)
            {

                Console.WriteLine(mess.Message );
            }

        }
    }
}
