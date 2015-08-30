using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        //Write a method that checks if the element at given position 
        //in given array of integers is larger than its two neighbours (when such exist).
        
        static void check(int[] array, int index)
        {
            if(array.Length==1)Console.WriteLine("There is only one element in the array");
            else if (index == 0)
            {
                if (array[index] > array[index + 1]) Console.WriteLine("The number at this index is the first number and is bigger than the one on its left");
                else Console.WriteLine("The number at this index is the first number and is smaller than the one on its left");
            }
            else if (index == array.Length - 1)
            {
                if (array[index] > array[index - 1]) Console.WriteLine("The number at this index is the last number and is bigger than the one on its fight");
                else Console.WriteLine("The number at this index is the last number and is bigger than the one on its right");
            }
            else if (array[index] > array[index + 1] && array[index] > array[index - 1]) Console.WriteLine("The number at this index is larger that its neighbours");
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
            Console.WriteLine("What is the index of the number you want to check");
            int num = int.Parse(Console.ReadLine());
            check(array, num);
        }
    }
}
