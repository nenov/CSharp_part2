using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a string of maximum 20 characters.
            //If the length of the string is less than 20, the rest of the characters should be filled with *.
            //Print the result string into the console.
            string input;
            Console.WriteLine("Please enter a string");
            input = Console.ReadLine();
            if (input.Length > 20) Console.WriteLine("Your string is more that 20 characters long");
            else
            {
                string newOne = "";
                for (int i = 0; i < 20; i++)
                {
                    if (i < input.Length) newOne += input[i];
                    else newOne += '*';
                }
                Console.WriteLine(newOne);
            }
        }
    }
}
