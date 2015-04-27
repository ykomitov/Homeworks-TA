//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../sample-input.txt");
        string input = reader.ReadToEnd();

        //replace whole word start with whole word finish
        input = Regex.Replace(input, @"\bstart\b", "finish");

        //write the input string to a new file
        StreamWriter writer = new StreamWriter("../../sample-replaced.txt");
        writer.Write(input);
        writer.Close();

        Console.WriteLine("It is alive!");
    }
}

