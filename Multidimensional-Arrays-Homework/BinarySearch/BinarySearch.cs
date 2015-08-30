using System;
class BinarySearch
{
    static void Main()
    {
        //Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
        //and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
        Console.WriteLine("Please enter N");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter value to be put under index {0}:",i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please enter k:");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(array);
        Console.WriteLine(string.Join(", ", array));
        int result = 0;
        do
        {
            result = Array.BinarySearch(array, k);
            if (result < 0) k--;
        } while (result<0);
        Console.WriteLine("The largest number in the array which is <=k is:" + array[result]);
    }
}