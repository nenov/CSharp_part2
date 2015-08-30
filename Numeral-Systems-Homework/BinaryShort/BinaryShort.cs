using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShort
{
    class BinaryShort
    {

        static string ConvertToBin(short input)
        {
            string result = "";
            while (input > 0)
            {
                result = (input % 2).ToString() + result;
                input = (short)(input / 2);
            }
            return result;
        }

        static void Main(string[] args)
        {
            //Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
            Console.Write("Please enter a short signed number: ");
            short number = short.Parse(Console.ReadLine());

            string result = String.Empty;

            if (number < 0)
                result = "1" + ConvertToBin((short)(32768 + number)).PadLeft(15, '0');
            else
                result = ConvertToBin(number).PadLeft(16, '0');
            Console.WriteLine(result);


        }
    }
}
