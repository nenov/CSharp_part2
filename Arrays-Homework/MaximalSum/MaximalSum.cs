using System;
class MaximalSum
{
    static void Main()
    {
       // Write a program that finds the sequence of maximal sum in given array.
        Console.WriteLine("How big is the array going to be (N):");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter element number " + (i + 1) + " from the array:");
            array[i] = int.Parse(Console.ReadLine());
        }
        long sum = long.MinValue;
        long midsum = 0;
        int start = 0, end = 0;
        for (int i = 0; i < array.Length; i++)
        {
            midsum = array[i];
            for (int k = i + 1; k < array.Length; k++)
            {
                midsum += array[k];
                if (midsum > sum)
                {
                    sum = midsum;
                    start = i;
                    end = k;
                }
            }
        }
        for (int i = start; i <= end; i++)
        {
            if (i != end) Console.Write(array[i] + ", ");
            else Console.WriteLine(array[i]);
        }
    }
}