using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary1
{
    class DecimalToBinary
    {
        //Write a program to convert decimal numbers to their binary representation.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer number:");
            long input = long.Parse(Console.ReadLine());
            string result = "";
            if (input < 0)
            {
                input = input ^ long.MinValue;
            }
            if (input == 0) result = "0";
            else while (input != 0)
                {
                    if (input % 2 == 1) result = '1' + result;
                    else result = '0' + result;
                    input /= 2;
                }
            Console.WriteLine(result);
        }
    }
}
