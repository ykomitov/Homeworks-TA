//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        string input = "aabbb s     sd ccccc s a b c";
        
        //Regex explanation
        //(.)   - Match any single character and put in a capturing group
        //\1    - Match the captured character
        //{2,}  - Two or more times

        string result = Regex.Replace(input, @"(.)\1{1,}", "$1");
        Console.WriteLine(" Input string: {0}", input);
        Console.WriteLine("Output string: {0}\r\n", result);
    }
}

