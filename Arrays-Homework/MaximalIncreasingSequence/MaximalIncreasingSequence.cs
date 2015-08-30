using System;
class MaximalIncreasingSequence
{
    static void Main()
    {
        //Write a program that finds the maximal increasing sequence in an array.
        Console.WriteLine("Enter the elements on one line separated by a comma and a space:");
        string input = Console.ReadLine();
        int index = 0;
        char[] first = new char[input.Length];
        for (int i = 0; i < input.Length; i += 3)
        {
            first[index] = input[i];
            index++;
        }
        int count = 0;
        int max = int.MinValue;
        int position = 0;
        for (int i = 0; i < index; i++)
        {
            if (first[i] < first[i + 1])
            {
                count++;
                if (count > max)
                {
                    max = count;
                    position = i + 1;
                }
            }
            else count = 0;
        }
        for (int i = max; i >= 0; i--)
        {
            Console.Write(first[position - (i)]);
            if (i > 0) Console.Write(", ");
        }
        Console.WriteLine();

    }
}