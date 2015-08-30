using System;
class QuickSort
{
    static void Main()
    {
        //Write a program that sorts an array of integers using the Quick sort algorithm.
        Console.WriteLine("How big is the array going to be (N):");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter element number " + (i + 1) + " from the array:");
            array[i] = int.Parse(Console.ReadLine());
        }
        sortIt(array, 0, array.Length - 1);
        Console.WriteLine("The sorted array looks like this: " + string.Join(", ", array));
    }
    public static void sortIt(int[] array, int begin, int finish)
    {
        int mid = array[(begin + finish) / 2];
        int i = begin;
        int j = finish;
        while (i <= j)
        {
            while (array[i] < mid) i++;
            while (array[j] > mid) j--;
            if (i <= j)
            {
                int swap = array[i];
                array[i] = array[j];
                array[j] = swap;
                i++;
                j--;
            }
        }
        if (j > begin)
            sortIt(array, begin, j);
        if (i < finish)
            sortIt(array, i, finish);

    }
}