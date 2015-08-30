using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class SayHello
    {
        static void printHello()
        {
            string name;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!",name);
        }
        static void Main(string[] args)
        {
            printHello();
        }
    }
}
