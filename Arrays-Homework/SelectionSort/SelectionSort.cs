using System;
class SelectionSort
{
    static void Main()
    {
        //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        //Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
        //find the smallest from the rest, move it at the second position, etc.
        Console.WriteLine("How big is the array going to be (N):");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter element number " + (i + 1) + " from the array:");
            array[i] = int.Parse(Console.ReadLine());
        }
        int small;
        int index;
        int swap;
        for (int i = 0; i < array.Length; i++)
        {
            small = array[i];
            index = i;
            for (int k = i+1; k < array.Length; k++)
            {
                if (small > array[k])
                {
                    small = array[k];
                    index = k;
                }
            }
            swap=array[i];
            array[i] = small;
            array[index] = swap;       
        }
        Console.WriteLine("Sorted array:" + string.Join(", ",array));
    }
}
