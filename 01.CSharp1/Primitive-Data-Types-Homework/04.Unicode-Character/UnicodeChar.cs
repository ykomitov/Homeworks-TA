using System;

//Declare a char variable and assign it with the symbol that has Unicode code `42` (decimal) using the `\u00XX` syntax, and then print it.

class UnicodeChar
{
    static void Main()
    {
        char a = '\u0042';
        Console.WriteLine(a);
    }
}