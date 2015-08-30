using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalAreaSum
{
    class MaximalAreaSum
    {
        //Write a program that reads a text file containing a square matrix of numbers.
        //Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        //The first line in the input file contains the size of matrix N.
        //Each of the next N lines contain N numbers separated by space.
        //The output should be a single number in a separate text file.
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\file.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int number = int.Parse(line);
                int[,] array = new int[number, number];
                for (int i = 0; i < number; i++)
                {
                    string[] numbers = reader.ReadLine().Split(' ');
                    for (int k = 0; k < number; k++)
                    {
                        array[i, k] = int.Parse(numbers[k]);
                    }
                }
                int bestsum = int.MinValue;
                for (int row = 0; row < array.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < array.GetLength(1) - 1; col++)
                    {
                        int sum = array[row, col] + array[row, col + 1] +
                            array[row + 1, col] + array[row + 1, col + 1];
                        if (sum > bestsum)
                        {
                            bestsum = sum;                           
                        }
                    }
                }
                Console.WriteLine(bestsum);
            }
        }
    }
}
