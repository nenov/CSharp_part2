using System;
class MaximalKSum
{
    static void Main()
    {
        //Write a program that reads two integer numbers N and K and an array of N elements from the console.
        //Find in the array those K elements that have maximal sum.
        Console.WriteLine("How big is the array going to be (N):");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter K:");
        int k = int.Parse(Console.ReadLine());
        int[] first = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter element number " + (i + 1) + " from the array:");
            first[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(first);
        Console.Write("The {0} numbers from the array that have the biggest sum are:", k);
        for (int i = size-1; i >= size -k; i--)
        {
            Console.Write(first[i]);
            if (i != size - k) Console.Write(", ");
            else Console.WriteLine();
        }
    }
}