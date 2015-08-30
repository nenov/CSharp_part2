using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class ParseURL
    {
        //Write a program that parses an URL address given in the format: [protocol]:
        //[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a URL address");
            string input = Console.ReadLine();
            string protocol=string.Empty;
            string server = string.Empty;
            string resource = string.Empty;
            bool flag = false;
            int i = 0;
            int stop=0;
            while (!flag)
            {
                if (input.Substring(i, 3) == "://")
                {
                    protocol = input.Substring(0, i);
                    flag = true;
                    stop=i+3;
                }
                else i++;
            }
            flag = false;
            i=stop;
            while (!flag)
            {
                if (input[i] == '/')
                {
                    server = input.Substring(stop, i - stop);
                    stop = i;
                    flag = true;
                }
                i++;
            }
            resource = input.Substring(stop, input.Length-stop);
            Console.WriteLine(@"[protocol]=" + protocol);
            Console.WriteLine(@"[server]=" + server);
            Console.WriteLine(@"[resource]=" + resource);
        }
    }
}
