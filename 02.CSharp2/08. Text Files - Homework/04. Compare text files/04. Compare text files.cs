/*Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.*/

using System;
using System.IO;
using ConcatenateTextFiles;

class CompareTextFiles
{
    static void Main()
    {
        StreamReader reader1 = new StreamReader("../../TextFile1.txt");
        StreamReader reader2 = new StreamReader("../../TextFile2.txt");

        //print the two streams
        Console.WriteLine("File 1 contains:");
        ConcatenateTextFiles.ConcatenateTextFiles.PrintReader(reader1);
        Console.WriteLine("File 2 contains:");
        ConcatenateTextFiles.ConcatenateTextFiles.PrintReader(reader2);

        //start reading the two streams from the beginning
        reader1.BaseStream.Position = 0;
        reader2.BaseStream.Position = 0;

        string line1 = "";
        string line2 = "";
        int equalLines = 0;
        int differentLines = 0;

        while (line1 != null & line2 != null)
        {
            line1 = reader1.ReadLine();
            line2 = reader2.ReadLine();

            if (line1 == null | line2 == null)
            {
                break;
            }

            if (line1 == line2)
            {
                equalLines++;
            }
            else
            {
                differentLines++;
            }
        }

        Console.WriteLine("    Number of equal lines: {0}", equalLines);
        Console.WriteLine("Number of different lines: {0}\r\n", differentLines);

        reader1.Close();
        reader2.Close();
    }
}

