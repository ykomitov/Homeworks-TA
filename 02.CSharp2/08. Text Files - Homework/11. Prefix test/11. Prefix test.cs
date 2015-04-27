//•	Write a program that deletes from a text file all words that start with the prefix test.
//•	Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../sample-input.txt");

        //get the contents of the text file in a string
        string input = reader.ReadToEnd();

        //replace all words starting with test in the string
        //[A-Za-z0-9]+ matches one or more (because of the +) characters after "test" substring
        input = Regex.Replace(input, "test[A-Za-z0-9_]+", "");
        reader.Close();

        //delete the contents of the file & write in it the modified string "input"
        StreamWriter writer = new StreamWriter("../../sample-input.txt");
        writer.WriteLine(input);
        writer.Close();
        
        Console.WriteLine("Live long and prosper!");
    }
}

