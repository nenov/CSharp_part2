using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            //Write a program that reads an integer number and calculates and prints its square root.
            //If the number is invalid or negative, print Invalid number.
            //In all cases finally print Good bye.
            //Use try-catch-finally block.
            Console.WriteLine("Please enter an integer number");
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(input));
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number"); ;
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
