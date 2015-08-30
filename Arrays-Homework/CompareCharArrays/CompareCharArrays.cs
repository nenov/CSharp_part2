using System;
class CompareCharArrays
{
    static void Main()
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).
        Console.WriteLine("How big is the first array going to be:");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("How big is the second the array going to be:");
        int size2 = int.Parse(Console.ReadLine());
        char[] first = new char[size];
        char[] second = new char[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter char number " + (i + 1) + " from the first array:");
            first[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < size2; i++)
        {
            Console.WriteLine("Enter char number " + (i + 1) + " from the second array:");
            second[i] = char.Parse(Console.ReadLine());
        }
        if (first.Length != second.Length) Console.WriteLine("The arrays are not of the same size! They cannot be compared.");
        else for (int i = 0; i < size; i++)
            {
                Console.Write("For elements number " + (i + 1) + " from the two arrays: ");
                if (first[i] == second[i]) Console.WriteLine("The are equal");
                else if (first[i] > second[i]) Console.WriteLine(first[i] + " from the first array is bigger than " + second[i] + " from the second array");
                else Console.WriteLine(second[i] + " from the second array is bigger than " + first[i] + " from the first array");
            }
    }
}