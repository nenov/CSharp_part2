using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        //Write a method GetMax() with two parameters that returns the larger of two integers.
        //Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

        static int GetMax(int first, int second)
        {
            if (first > second) return first;
            else return second;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first integer number:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer number:");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third integer number:");
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine("The largest of the three numbers is: {0}", GetMax(first, GetMax(second,third)));
        }
    }
}
