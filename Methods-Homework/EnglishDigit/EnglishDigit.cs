using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class EnglishDigit
    {
        //Write a method that returns the last digit of given integer as an English word.

        static string LastDigit(int num)
        {
            int last = Math.Abs(num % 10);
            switch (last)
            {
                case 0: return "zero"; break;
                case 1: return "one"; break;
                case 2: return "two"; break;
                case 3: return "three"; break;
                case 4: return "four"; break;
                case 5: return "five"; break;
                case 6: return "six"; break;
                case 7: return "seven"; break;
                case 8: return "eight"; break;
                default: return "nine"; break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(LastDigit(num));
        }
    }
}
