using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
        //Use variable number of arguments.

        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
            }
            return min;
        }
        static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
            return max;
        }
        static BigInteger Sum(int[] array)
        {
            BigInteger sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static BigInteger Product(int[] array)
        {
            BigInteger prod = 1;
            for (int i = 0; i < array.Length; i++)
            {
                prod *= array[i];
            }
            return prod;
        }
        static int Average(int[] array)
        {
            return (int)(Sum(array) / array.Length);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many integer numbers are you going to enter:");
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Please enter number under index {0}:", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array looks like this: " + string.Join(", ", array));
            Console.WriteLine("The smallest integer in the set is: {0}", Min(array));
            Console.WriteLine("The largest integer in the set is: {0}", Max(array));
            Console.WriteLine("The average of the numbers in the set is {0}", Average(array));
            Console.WriteLine("The sum of the numbers in the set is: {0}", Sum(array));
            Console.WriteLine("The product of the numbers in the set is: {0}", Product(array));
        }
    }
}
