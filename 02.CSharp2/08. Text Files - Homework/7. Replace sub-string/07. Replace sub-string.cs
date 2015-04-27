/*•	Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
  •	Ensure it will work with large files (e.g. 100 MB).*/

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceSubString
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../sample-input.txt");
        string input = reader.ReadToEnd();
        
        //replace substring start with finish
        input = Regex.Replace(input, "start", "finish");

        //write the input string to a new file
        StreamWriter writer = new StreamWriter("../../sample-replaced.txt");
        writer.Write(input);
        writer.Close();

        Console.WriteLine("It is alive!");
    }
}

