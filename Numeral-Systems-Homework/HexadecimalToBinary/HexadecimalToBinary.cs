using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static void Main(string[] args)
        {
            //Write a program to convert hexadecimal numbers to binary numbers (directly).
            Console.WriteLine("Please enter a hexadecimal integer number:");
            string input = Console.ReadLine();
            string binarystring = 
                String.Join(String.Empty,input.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
            Console.WriteLine(binarystring);
        }
    }
}
