using System;
class CompareArrays
{
    static void Main()
    {
        //Write a program that reads two integer arrays from the console and compares them element by element.
        Console.WriteLine("How big is the first the array going to be:");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("How big is the second the array going to be:");
        int size2 = int.Parse(Console.ReadLine());
        int[] first = new int[size];
        int[] second = new int[size2];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter element number " + (i + 1) + " from the first array:");
            first[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < size2; i++)
        {
            Console.WriteLine("Enter element number " + (i + 1) + " from the second array:");
            second[i] = int.Parse(Console.ReadLine());
        }
        if (first.Length != second.Length) Console.WriteLine("The arrays are not of the same size! They cannot be compared.");
        else for (int i = 0; i < size; i++)
            {
                Console.Write("For elements number " + (i + 1) + " from the two arrays, the bigger one is: ");
                if (first[i] == second[i]) Console.WriteLine("The are equal");
                else if (first[i] > second[i]) Console.WriteLine(first[i] + " from the first array is bigger than " + second[i] + " from the second array");
                else Console.WriteLine(second[i] + " from the second array is bigger than " + first[i] + " from the first array");
            }
    }
}