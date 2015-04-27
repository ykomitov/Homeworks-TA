//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("../../input-file.txt");
            StreamWriter writer = new StreamWriter("../../output.txt");

            string line = "";
            int lineNum = 1;
            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    writer.WriteLine("{0} {1}", lineNum, line);
                }
                lineNum++;
            }
            writer.Flush(); //flush the result to new file
            reader.Close();
            writer.Close();
            Console.WriteLine("File successfully created!");
        }
        catch (Exception)
        {
            Console.WriteLine("Oops, something went wrong!");
        }
    }
}

