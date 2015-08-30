using System;
class RemoveElementsFromArray
{
    static void Main()
    {
        Console.WriteLine("How big is the array going to be (N):");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter element number " + (i + 1) + " from the array:");
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            if(i!=array.Length-1)if(array[i]>)
        }
    }
}