using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        //Write a program to convert binary numbers to their decimal representation.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the binary number:");
            string input = Console.ReadLine();
            string[] array = new string[input.Length];
            int index = 0;
            long result = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == '1') result = result + (long)(Math.Pow(2, index));
                index++;
            }
            Console.WriteLine(result);
        }
    }
}
