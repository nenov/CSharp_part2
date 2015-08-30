using System;
class FillTheMatrix
{
    static void Main()
    {
        //Write a program that fills and prints a matrix of size (n, n) as shown below:
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        //A
        int count = 1;
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                matrix[k, i] = count;
                count++;
            }
        }
        Console.WriteLine("A)");
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write(matrix[i, k] + " ");
            }
            Console.WriteLine();
        }
        //B
        count = 1;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int k = 0; k < n; k++)
                {
                    matrix[k, i] = count;
                    count++;
                }
            }
            else
            {
                for (int k = n - 1; k >= 0; k--)
                {
                    matrix[k, i] = count;
                    count++;
                }
            }
        }
        Console.WriteLine("B)");
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write(matrix[i, k] + " ");
            }
            Console.WriteLine();
        }
        //C
        count = 1;
        int hold = n - 1;
        int col = hold;
        int mid = 0;
        do
        {
            for (int k = 0; k <= mid; k++)
            {
                matrix[col, k] = count;
                count++;
                col++;
            }
            hold--;
            col = hold;
            mid++;

        }
        while (hold >= 0);
        hold = 1;
        col = hold;
        mid = 2;
        do
        {
            for (int k = 0; k <= mid; k++)
            {
                matrix[k, col] = count;
                count++;
                col++;
            }
            hold++;
            col = hold;
            mid--;

        }
        while (mid >=0);
        Console.WriteLine("C)");
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write(matrix[i, k] + " ");
            }
            Console.WriteLine();
        }
        
    }
}