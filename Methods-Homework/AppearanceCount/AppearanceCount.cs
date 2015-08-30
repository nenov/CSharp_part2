using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class AppearanceCount
    {
        //Write a method that counts how many times given number appears in given array.
        //Write a test program to check if the method is workings correctly.

        static int Search(int[] array, int num)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num) count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How long is the array going to be:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter number under index {0}:", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array looks like this: " + string.Join(", ",array));
            Console.WriteLine("What number are you looking for:");
            int num = int.Parse(Console.ReadLine());
            if (Search(array,num) == 0) Console.WriteLine("The number is not present in the array");
            else Console.WriteLine("The number appears {0} times in the array", Search(array,num));
        }
    }
}
