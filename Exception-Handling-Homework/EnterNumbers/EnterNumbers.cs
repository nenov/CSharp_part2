using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        //Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
        //If an invalid number or non-number text is entered, the method should throw an exception.
        //Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

        static int ReadNumber(int start, int end)
        {
            int num = int.MinValue;
            do
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num <= start || num >= end)
                    {
                        num = int.MinValue;
                        throw new System.Exception(
                           "Number is not in the given range");
                    }
                }
                catch (Exception me)
                {
                    if (me.Message == "Number is not in the given range") Console.WriteLine(me.Message);
                    else Console.WriteLine("You have enter an invalid input");
                }
            } while (num == int.MinValue);
            return num;
        }
        static void Main(string[] args)
        {
            int first = 1;
            int last = 100;
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a number between {0} and {1}", first,last);
                array[i] = ReadNumber(first, last);
                first = array[i];
            }
            Console.WriteLine("The entered numbers are :" + string.Join(",",array));
        }
    }
}
