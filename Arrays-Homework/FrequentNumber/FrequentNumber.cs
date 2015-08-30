using System;
class FrequentNumber
{
    static void Main()
    {
        //Write a program that finds the most frequent number in an array.
        Console.WriteLine("How big is the array going to be (N):");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter element number " + (i + 1) + " from the array:");
            array[i] = int.Parse(Console.ReadLine());
        }
        int count = 1;
        int maxcount=0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int k = i+1; k < array.Length; k++)
            {
                if (array[i] == array[k]) count++;
            }
            if (count > maxcount)
            {
                maxcount = count;
                index = i;
            }
            count = 1;
        }
        Console.WriteLine("The most frequent number in the array is: {0}. It exists {1} times", array[index], maxcount);
    }
}