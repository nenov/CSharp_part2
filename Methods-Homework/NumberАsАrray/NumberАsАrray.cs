using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberАsАrray
{
    class NumberАsАrray
    {
        //Write a method that adds two positive integer numbers represented as arrays of digits
        //(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
        //Each of the numbers that will be added could have up to 10 000 digits.

        static int[] Sum(int[] first, int[] second)
        {
            int length = (first.Length > second.Length) ? first.Length : second.Length;
            int[] sum = new int[length + 1];
            for (int i = 0; i < length; i++)
            {
                if (i < first.Length && i < second.Length)
                {
                    int temp = (first[i] + second[i]);
                    sum[i] += temp;
                    sum[i + 1] += temp / 10;
                    sum[i] = sum[i] % 10;
                }
                else if (i < first.Length && i >= second.Length)
                {
                    int temp = (first[i]);
                    sum[i] += temp;
                    sum[i + 1] += temp / 10;
                    sum[i] = sum[i] % 10;
                }
                else
                {
                    int temp = (second[i]);
                    sum[i] += temp;
                    sum[i + 1] += temp / 10;
                    sum[i] = sum[i] % 10;
                }
            }
            int[] result = new int[length];
            if (sum[length] == 0) Array.Copy(sum, result, length);
            return result;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first positive integer:");
            string firstInt = Console.ReadLine();
            Console.WriteLine("Enter the second positive integer:");
            string secondInt = Console.ReadLine();
            int[] first = new int[firstInt.Length];
            int[] second = new int[secondInt.Length];
            for (int i = 0; i < firstInt.Length; i++)
            {
                first[i] = firstInt[i] -'0';
            }
            for (int i = 0; i < secondInt.Length; i++)
            {
                second[i] = secondInt[i] - '0'; ;
            }
            Array.Reverse(first);
            Array.Reverse(second);
            Console.WriteLine("The sum is {0}", string.Join("", Sum(first, second).Reverse()));
        }
    }
}
