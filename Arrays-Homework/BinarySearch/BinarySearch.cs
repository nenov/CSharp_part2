using System;
class BinarySearch
{
    static int Search(int[] array, int element)
    {
        Array.Sort(array);
        int imax = array.Length-1 ;
        int imin = 0;
        while (imax >= imin)
        {
            int imid = (imin + imax) / 2;
            if (array[imid] < element) imin = imid + 1;
            else if (array[imid] > element)
                imax = imid - 1;
            else
                return imid;
        }
        return -1;
    }
    static void Main()
    {
        //Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
        Console.WriteLine("How big is the array going to be (N):");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter element number " + (i + 1) + " from the array:");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("What is the elemenct you are looking for?");
        int element = int.Parse(Console.ReadLine());

        Array.Sort(array);

        Console.WriteLine("The sorted array looks like this:" + string.Join(", ", array));
        if (Search(array, element) < 0) Console.WriteLine("The element is not present in the array!");
        else Console.WriteLine("The index of the searched element is:{0}", Search(array, element));
    }
}