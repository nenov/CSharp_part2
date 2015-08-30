using System;
class PrimeNumbers
{
    static void Main()
    {
        //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm

//Input: an integer n > 1
//Let A be an array of Boolean values, indexed by integers 2 to n,
//initially all set to true.
//for i = 2, 3, 4, ..., not exceeding √n:
//if A[i] is true:
//for j = i2, i2+i, i2+2i, i2+3i, ..., not exceeding n :
//A[j] := false
//Output: all i such that A[i] is true.

        bool[] result = new bool[10000001];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = true;
        }
        //2, 3, 5, 7, 11, 13, 17, 19, 23
        for (int i = 2; i < Math.Sqrt(result.Length); i++)
        {
            if (result[i] == true) for (int k = i*i; k < result.Length; k +=i )
                {
                    result[k] = false;
                }
        }
        for (int i = 2; i < result.Length; i++)
        {
            if (result[i] == true)
            {
                Console.Write(i);
                if (i == result.Length - 1) Console.WriteLine();
                else Console.Write(", ");
            }
        }
    }
}