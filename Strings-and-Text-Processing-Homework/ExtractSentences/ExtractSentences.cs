using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class ExtractSentences
    {
        //Write a program that extracts from a given text all sentences containing given word.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text");
            string text = Console.ReadLine();
            string[] sentences = text.Split('.');
            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = sentences[i] + '.';
            }
            for (int i = 0; i < sentences.Length; i++)
            {
                bool flag = false;
                for (int k = 0; k < sentences[i].Length-3; k++)
                {
                    if(!char.IsLetter(sentences[i][k]) && sentences[i].Substring(k+1,2)=="in" && !char.IsLetter(sentences[i][k+3]))flag=true;
                }
                if (flag) Console.Write(sentences[i]);
            }
            Console.WriteLine();
        }
    }
}
