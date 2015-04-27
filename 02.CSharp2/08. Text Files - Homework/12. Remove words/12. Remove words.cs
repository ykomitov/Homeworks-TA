//Write a program that removes from a text file all words listed in given another text file.

using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class RemoveWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../words-to-replace.txt");

        //read the words to replace file and store the words in a list
        List<string> lines = new List<string>();
        string line = reader.ReadLine();
        while (line != null)
        {
            lines.Add(line);
            line = reader.ReadLine();
        }
        reader.Close();

        StreamReader readerTwo = new StreamReader("../../sample-input.txt");
        string input = readerTwo.ReadToEnd();

        //replace the words in the file
        for (int i = 0; i < lines.Count; i++)
        {
            string expression = String.Format(@"(?i)\b{0}\b", lines[i]); //(?i) for case insensitive removal
            input = Regex.Replace(input, expression, "");
        }

        readerTwo.Close();

        //delete the contents of the input file & write in it the modified string "input"
        StreamWriter writer = new StreamWriter("../../sample-input.txt");
        writer.WriteLine(input);
        writer.Close();

        Console.WriteLine("Live long and prosper!");
    }
}

