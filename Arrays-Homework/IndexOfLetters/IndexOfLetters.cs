using System;
class IndexOfLetters
{
    static void Main()
    {
        //Write a program that creates an array containing all letters from the alphabet (A-Z).
        //Read a word from the console and print the index of each of its letters in the array.
        char[] alpha = new char[26];
        char first = 'A';
        for (int i = 0; i < 26; i++)
        {
            alpha[i] = first;
            first++;
        }
        Console.WriteLine("Please enter a word:");
        string word = Console.ReadLine();
        word = word.ToUpper();
        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine("Letter {0} has an index of {1}.", word[i],Array.IndexOf(alpha, word[i]));
        }
    }
}