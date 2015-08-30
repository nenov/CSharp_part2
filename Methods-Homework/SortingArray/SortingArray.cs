using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class SortingArray
    {
        //Write a method that return the maximal element in a portion of array of integers starting at given index.
        //Using it write another method that sorts an array in ascending / descending order.

        static int MaxElem(int[] array, int index) 
        {
            int max = array[index];
            for (int i = index; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
            return max;
        }
        static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int tempInd = Array.IndexOf(array,MaxElem(array,i));
                int temp = MaxElem(array,i);
                array[tempInd] = array[i];
                array[i] = temp;                
            }
            Console.WriteLine("The sorted array in descending order looks like this:\n" + String.Join(", ",array));
            Console.WriteLine("The sorted array in ascending order looks like this:\n" + String.Join(", ", array.Reverse()));
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
            Sort(array);
        }
    }
}
