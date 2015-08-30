using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class NFactorial
    {
        //Write a program to calculate n! for each n in the range [1..100].

        static int[] Multy(int[] array, int num)
        {
            int[] result = { 0 };

            for (int i = 0; i < num; i++) result = Add(result, array);

            return result;
        }
        static int[] Add(int[] first, int[] second)
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

        static void PrintNumber(int[] p)
        {
            for (int i = p.Length - 1; i >= 0; i--) Console.Write(p[i]);

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] factorial = { 1 };
            for (int i = 1; i <= 100; i++) PrintNumber(factorial = Multy(factorial, i));
        }
    }
}
