//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../sample-input.txt");

        int lineNumber = 0;
        string line = "";
        string resultString = null;
        while (line != null)
        {
            line = reader.ReadLine();
            if (lineNumber % 2 != 0)
            {
                resultString = resultString + line + Environment.NewLine;
            }
            lineNumber++;
        }
        reader.Close();

        StreamWriter writer = new StreamWriter("../../sample-input.txt");
        writer.WriteLine(resultString);
        writer.Close();

        Console.WriteLine("Live long and prosper!");
    }
}

