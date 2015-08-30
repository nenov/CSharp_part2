using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            //Write a program to check if in a given expression the brackets are put correctly.
            //Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
            Console.WriteLine("Please enter an expression:");
            string input = Console.ReadLine();
            int countOpen = 0;
            int countClose = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') countOpen++;
                if (input[i] == ')') countClose++;
                if (countClose > countOpen)
                {
                    Console.WriteLine("Incorrect expression");
                    return;
                }
            }
            if (countOpen == countClose) Console.WriteLine("Correct expression");
            else Console.WriteLine("Incorrect expression");
        }
    }
}
