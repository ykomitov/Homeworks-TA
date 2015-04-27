//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../sample-input.txt");

        try
        {
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        Console.WriteLine("Line: {0}", line);
                    }
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }

}