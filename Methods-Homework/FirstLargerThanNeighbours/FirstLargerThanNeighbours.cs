using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        //Write a method that returns the index of the first element in array that is larger than its neighbours,
        //or -1, if there’s no such element. Use the method from the previous exercise.
        static int check(int[] array, int index)
        {
            if (array.Length == 1) Console.WriteLine("There is only one element in the array");
            else if (index == 0)
            {
                if (array[index] > array[index + 1]) return 1;
            }
            else if (index == array.Length - 1)
            {
                if (array[index] > array[index - 1]) return 1;
            }
            else if (array[index] > array[index + 1] && array[index] > array[index - 1]) return 1;
            return -1;
        }
        static int ReturnIndex(int[] array)
        {
            int count = 0;
            while (count<array.Length)
            {
                if (check(array, count) == 1) return count;
                else count++;
            }
            return -1;
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
            Console.WriteLine("The array looks like this: " + string.Join(", ", array));
            if (ReturnIndex(array) == -1) Console.WriteLine("The is no such element which is larger that its neighbours");
            else Console.WriteLine("The index of the first element in array that is larger than its neighbours is: {0}", ReturnIndex(array));
        }
    }
}
