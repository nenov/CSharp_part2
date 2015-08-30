using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecode
{
    class EncodeDecode
    {
        static void Main(string[] args)
        {
            //Write a program that encodes and decodes a string using given encryption key (cipher).
            //The key consists of a sequence of characters.
            //The encoding/decoding is done by performing XOR (exclusive or) operation over 
            //the first letter of the string with the first of the key, the second – with the second, etc. 
            //When the last key character is reached, the next is the first.
            Console.WriteLine("Please enter a string to be encoded:");
            string input = Console.ReadLine();
            Console.WriteLine("Please enter the encryption key:");
            string key = Console.ReadLine();
            char[] input2= input.ToArray();
            char[] key2 = key.ToArray();
            for (int i = 0; i < input2.Length; i++)
            {
                
                    input2[i] = (char)(input2[i] ^ key[i%key.Length]);

            }
            Console.WriteLine(string.Join("",input2));
        }
    }
}
