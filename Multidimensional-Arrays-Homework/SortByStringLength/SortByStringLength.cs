using System;
using System.Linq;
class SortByStringLength
{
    static void SortArray(string[] array)
    {
        var desc = from s in array
                   orderby s.Length ascending
                   select s;
        int count = 0;
        foreach (string c in desc)
        {
            array[count] = c;
            count++;
        }

    }
    static void Main()
    {
        //You are given an array of strings.
        //Write a method that sorts the array by the length of its elements (the number of characters composing them).
        Console.WriteLine("Please enter N:");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter the string to be put at index {0}:", i);
            array[i] = Console.ReadLine();
        }
        Console.WriteLine("The array looks like this:");
        Console.WriteLine(string.Join(", ", array));
        SortArray(array);
        Console.WriteLine("The sorted array looks like this:");
        Console.WriteLine(string.Join(", ", array));

    }
}