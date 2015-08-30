using System;
class SequenceNMatrix
{
    static void Main()
    {
        //We are given a matrix of strings of size N x M.
        //Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
        //Write a program that finds the longest sequence of equal strings in the matrix.
        Console.WriteLine("Please enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter M:");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < m; k++)
            {
                Console.Write("Please enter the string to be put at [{0},{1}]:", i, k);
                matrix[i, k] = Console.ReadLine();
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
        int maxCount = 0;
        int curCount = 0;
        string part = "";
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                curCount = 0;
                for (int i = col; i < m - 1; i++) //horizontal
                {
                    if (matrix[row, i + 1] == matrix[row, i])
                    {
                        curCount++;
                    }

                    if (curCount > maxCount)
                    {
                        maxCount = curCount;
                        part = matrix[row, i];
                    }
                }
                curCount = 0;
                for (int i = row; i < n - 1; i++) //vertical
                {
                    if (matrix[i + 1, col] == matrix[i, col])
                    {
                        curCount++;
                    }

                    if (curCount > maxCount)
                    {
                        maxCount = curCount;
                        part = matrix[i, col];
                    }
                }
                curCount = 0;
                for (int k = row, l = col; (k < n - 1) && (l < m - 1); k++, l++) //right diagonal
                {
                    if (matrix[k, l] == matrix[k + 1, l + 1])
                    {
                        curCount++;
                    }

                    if (curCount > maxCount)
                    {
                        maxCount = curCount;
                        part = matrix[k, l];
                    }
                }
                curCount = 0;
                for (int k = row, l = col; (k < n-1) && (l >0); k++, l--) //left diagonal
                {
                    if (matrix[k, l] == matrix[k + 1, l - 1])
                    {
                        curCount++;
                    }

                    if (curCount > maxCount)
                    {
                        maxCount = curCount;
                        part = matrix[k, l];
                    }
                }
            }
        }
        Console.WriteLine("The longest sequence is:");
        for (int i = 0; i < maxCount + 1; i++) Console.Write(part + ", ");

    }
}
