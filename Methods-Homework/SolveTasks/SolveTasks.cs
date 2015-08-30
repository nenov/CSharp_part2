using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTasks
{
    class SolveTasks
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter \n1 if you want to Reverses the digits of a number");
            Console.WriteLine("2 if you want to calculates the average of a sequence of integers");
            Console.WriteLine("3 if you want to solves a linear equation a * x + b = 0");
            Console.WriteLine("0 for exit");
            int result = 0;
            while (result >= 0 && result <=3)
            {
                result = int.Parse(Console.ReadLine());
            }
            switch (result)
            {
                case 1: Reverse(); return;
                case 2: Average(); return;
                //case 3: Solve(); return;
                default:
                    break;
            }
        }
        static void Reverse()
        {
            Console.WriteLine("\n{0}\n", new string('-', 40));

            decimal number = 0;
            do
            {
                Console.Write("Enter a non-negative number (real or integer): ");
                number = decimal.Parse(Console.ReadLine());
            }
            while (number < 0);

            string temp = number.ToString(CultureInfo.InvariantCulture);
            string result = string.Empty;

            for (int i = temp.Length - 1; i >= 0; i--)
                result += temp[i];

            Console.WriteLine("\nResult: {0} -> {1}\n{2}\n", number, decimal.Parse(result), new string('-', 40));

            return;
        }
        static void Average()
        {
            int num = 0;
            do
            {
                Console.Write("Enter a positive number N (size of array): ");
                num = int.Parse(Console.ReadLine());
            }
            while (num <= 0);

            int[] array = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Please enter number under index {0}:", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nAverage sum is {0}\n", array.Average());
            return;
        }
    }
}
