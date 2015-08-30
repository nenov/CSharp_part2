using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumber
{
    class FormatNumber
    {
        //Write a program that reads a number and prints it as a decimal number,
        //hexadecimal number, percentage and in scientific notation.
        //Format the output aligned right in 15 symbols.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("{0,15}", num));
            Console.WriteLine(String.Format("{0,15:X}", num));
            Console.WriteLine(String.Format("{0,15:P2}", (decimal)num/100));
            Console.WriteLine(String.Format("{0,15:E}", num));
        }
    }
}
