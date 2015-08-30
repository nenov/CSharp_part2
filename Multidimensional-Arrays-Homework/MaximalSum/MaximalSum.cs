using System;
class MaximalSum
{
    static void Main()
    {
        //Write a program that reads a rectangular matrix of size N x M 
        //and finds in it the square 3 x 3 that has maximal sum of its elements.
        Console.WriteLine("Please enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter M:");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < m; k++)
            {
                Console.Write("Please enter the number to be put at [{0},{1}]:",i,k);
                matrix[i, k] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("The matrix looks like this:");
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < m; k++)
            {
                Console.Write(matrix[i, k] + " ");
            }
            Console.WriteLine();
        }
        int bestsum = int.MinValue;
        int bestx=0;
        int besty=0;
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                int sum = matrix[row,col]+matrix[row,col+1]+matrix[row,col+2]+
                    matrix[row+1,col]+matrix[row+1,col+1]+matrix[row+1,col+2]+
                    matrix[row+2,col]+matrix[row+2,col+1]+matrix[row+2,col+2];
                if (sum > bestsum)
                {
                    bestsum = sum;
                    bestx=row;
                    besty = col;
                }
            }
        }
        Console.WriteLine("The 3x3 square that have the greates sum is:");
        for (int i = bestx; i < bestx+3; i++)
        {
            for (int k = besty; k < besty+3; k++)
            {
                Console.Write(matrix[i,k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Which has a sum of " + bestsum);
    }
}
