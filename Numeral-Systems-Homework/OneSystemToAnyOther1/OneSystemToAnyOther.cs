using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSystemToAnyOther1
{
    class OneSystemToAnyOther
    {
        static string DecimalToBase(long num, int tBase)
        {
            string result = string.Empty;
            while (num > 0)
            {
                long remainder = num % tBase;
                if (remainder >= 0 && remainder <= 9)
                {
                    result = remainder + result;
                }
                else
                {
                    result = (char)(remainder - 10 + 'A') + result;
                }
                num /= tBase    ;
            }
            return result;
        }
        static long BaseToDecimal(string num, int sBase)
        {
            long result= new long();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] >= '0' && num[i] <= '9')
                {
                    result += (num[i] - '0') * (long)Math.Pow(sBase, num.Length - 1 - i);
                }
                else
                {
                    result += (num[i] - 'A' + 10) * (long)Math.Pow(sBase, num.Length - 1 - i);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            //Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
            Console.WriteLine("Enter number to be converted :");
            string input = Console.ReadLine();
            
            Console.WriteLine("Enter base s (2 ≤ s, d ≤ 16) :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter base d (2 ≤ s, d ≤ 16) :");
            int d = int.Parse(Console.ReadLine());
            if (s == 2) Console.WriteLine(DecimalToBase(long.Parse(input),d));
            else if (d == 2) Console.WriteLine(DecimalToBase(long.Parse(input),s));
            else
            {
                string temp = BaseToDecimal(input,s).ToString();
                Console.WriteLine(DecimalToBase(long.Parse(temp),d));
            }


        }
    }
}
