using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        //Write a method that reverses the digits of given decimal number.

        static decimal Reverse(decimal number)
        {
            string input = number.ToString();
            string result="";
            for (int i = input.Length-1; i >=0; i--)
            {
                result = result + input[i];
            }

            return decimal.Parse(result) ;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a decimal number:");
            decimal num = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(num));
        }
    }
}
