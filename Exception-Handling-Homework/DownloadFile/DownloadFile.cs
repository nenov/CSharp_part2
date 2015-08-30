using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadFile
{
    class DownloadFile
    {
        //Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
        //Find in Google how to download files in C#.
        //Be sure to catch all exceptions and to free any used resources in the finally block.

        static void Main(string[] args)
        {
            string input = @"http://telerikacademy.com/Content/Images/news-img01.png";
            using (WebClient downloadClient = new WebClient())
            {
                try
                {
                    downloadClient.DownloadFile(input, "news-img01.png");

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally 
                {
                    input = string.Empty;
                    Console.WriteLine("Bye");
                }
            }

        }
    }
}
