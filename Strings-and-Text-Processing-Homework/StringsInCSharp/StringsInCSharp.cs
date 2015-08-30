using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsInCSharp
{
    class StringsInCSharp
    {
        static void Main(string[] args)
        {
            //Describe the strings in C#.
            string a = "A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects";
            Console.WriteLine(a);
            Console.WriteLine();
            //What is typical for the string data type?
            string b = "There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0'). The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters. To access the individual Unicode code points in a string, use the StringInfo object.";
            Console.WriteLine(b);
            Console.WriteLine();
            //Describe the most important methods of the String class
            string c = @"public static int Compare( string strA, string strB ) 
Compares two specified string objects and returns an integer that indicates their relative position in the sort order.

public static int Compare( string strA, string strB, bool ignoreCase ) 
Compares two specified string objects and returns an integer that indicates their relative position in the sort order. However, it ignores case if the Boolean parameter is true.

public static string Concat( string str0, string str1 ) 
Concatenates two string objects.

public static string Concat( string str0, string str1, string str2 ) 
Concatenates three string objects.

public static string Concat( string str0, string str1, string str2, string str3 ) 
Concatenates four string objects.

public bool Contains( string value ) 
Returns a value indicating whether the specified string object occurs within this string.

public static string Copy( string str ) 
Creates a new String object with the same value as the specified string.";
            Console.WriteLine("Some important String methods are :\n" + c);

        }
    }
}
