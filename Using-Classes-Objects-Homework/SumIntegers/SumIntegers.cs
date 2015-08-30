using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            //You are given a sequence of positive integer values written into a string, separated by spaces.
            //Write a function that reads these values from given string and calculates their sum.
            Console.WriteLine("Please enter a sequence of positive integer value separated by spaces");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            long sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }
            Console.WriteLine("The sum of the numbers is: " + sum);
        }
    }
}
