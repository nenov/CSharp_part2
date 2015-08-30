using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtractingPolynomials
{
    class SubtractingPolynomials
    {
        //Extend the previous program to support also subtraction and multiplication of polynomials.

        static decimal[] sum(decimal[] first, decimal[] second)
        {
            int size;
            if (first.Length > second.Length) size = first.Length;
            else size = second.Length;
            decimal[] sum = new decimal[size];
            for (int i = 0; i < size; i++)
            {
                if (i < first.Length && i < second.Length)
                {
                    sum[i] = first[i] + second[i];
                }
                else if (first.Length > second.Length)
                {
                    sum[i] = first[i];
                }
                else
                {
                    sum[i] = second[i];
                }
            }
            return sum;
        }

        static void print(decimal[] result)
        {
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (i == result.Length - 1 && result[i] != 0)
                {
                    Console.Write("{0}{1}x^{2} ", result[i] > 0 ? "" : "-", Math.Abs(result[i]), i);
                }
                else if (i == 0)
                {
                    if (result[i] < 0) Console.Write("{0}{1} ", "- ", -result[i]);
                    else if (result[i] > 0) Console.Write("{0}{1} ", "+ ", result[i]);
                }
                else
                {
                    if (result[i] < 0) Console.Write("{0}{1}x^{2} ", "- ", -result[i], i);
                    else if (result[i] > 0) Console.Write("{0}{1}x^{2} ", "+ ", result[i], i);
                }
            }
            Console.WriteLine();
        }
        static decimal[] substract(decimal[] first, decimal[] second)
        {
            int size;
            if (first.Length > second.Length) size = first.Length;
            else size = second.Length;
            decimal[] sum = new decimal[size];
            for (int i = 0; i < size; i++)
            {
                if (i < first.Length && i < second.Length)
                {
                    sum[i] = first[i] - second[i];
                }
                else if (first.Length > second.Length)
                {
                    sum[i] = first[i];
                }
                else
                {
                    sum[i] = 0 - second[i];
                }
            }
            return sum;
        }
        static decimal[] multy(decimal[] first, decimal[] second)
        {
            decimal[] result = new decimal[(first.Length + second.Length)];
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    result[i+j] += (first[i] * second[j]);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            //Write a method that adds two polynomials.
            //Represent them as arrays of their coefficients.

            Console.Write("Enter your polynomial degree: ");
            int degree = int.Parse(Console.ReadLine());

            decimal[] first = new decimal[degree + 1];

            for (int i = first.Length - 1; i >= 0; i--)
            {
                Console.Write("x^" + i + ": ");
                first[i] = decimal.Parse(Console.ReadLine());
            }
            Console.Write("Enter your polynomial degree: ");
            degree = int.Parse(Console.ReadLine());

            decimal[] second = new decimal[degree + 1];

            for (int i = second.Length - 1; i >= 0; i--)
            {
                Console.Write("x^" + i + ": ");
                second[i] = decimal.Parse(Console.ReadLine());
            }
            decimal[] result = sum(first, second);
            Console.WriteLine("The sum of the two polynomials is:");
            print(sum(first, second));
            Console.WriteLine("The subtraction of the two polynomials is:");
            print(substract(first, second));
            Console.WriteLine("The multiplication of the two polynomials is:");
            print(multy(first, second));
        }
    }
}
