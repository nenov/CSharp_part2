using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {

            Console.Write("Convert a binary number to hex number: ");
            string input = Console.ReadLine();
            string result = string.Empty;
            if (input.Length % 4 != 0)
            {
                input = input.PadLeft(4 - (input.Length % 4) + input.Length, '0');
            }

            for (int i = 0; i < input.Length; i += 4)
            {
                switch (input.Substring(i, 4))
                {
                    case "0000": result += '0'; break;
                    case "0001": result += '1'; break;
                    case "0010": result += '2'; break;
                    case "0011": result += '3'; break;
                    case "0100": result += '4'; break;
                    case "0101": result += '5'; break;
                    case "0110": result += '6'; break;
                    case "0111": result += '7'; break;
                    case "1000": result += '8'; break;
                    case "1001": result += '9'; break;
                    case "1010": result += 'A'; break;
                    case "1011": result += 'B'; break;
                    case "1100": result += 'C'; break;
                    case "1101": result += 'D'; break;
                    case "1110": result += 'E'; break;
                    case "1111": result += 'F'; break;
                }
            }
            Console.WriteLine( result.TrimStart('0') == string.Empty ? "0" : result.TrimStart('0'));
        }
    }
}
