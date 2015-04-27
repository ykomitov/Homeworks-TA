//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.IO;
using System.Collections.Generic;

class SaveSortedNames
{
    static void Main()
    {
        //read the input file
        StreamReader reader = new StreamReader("../../unsorted-names.txt");

        //create a list to hold all the lines from the input file
        List<string> unsortedList = new List<string>();

        //read the file line by line and add each line to the list
        string line = reader.ReadLine();
        while (line != null)
        {
            unsortedList.Add(line);
            line = reader.ReadLine();
        }

        //sort the list & save a new file
        unsortedList.Sort();

        StreamWriter writer = new StreamWriter("../../sorted-names.txt");

        foreach (var item in unsortedList)
        {
            writer.WriteLine(item);
        }
        writer.Flush();
        Console.WriteLine("Names sorted! File successfully created.");

        //close StreamReader & StreamWriter
        reader.Close();
        writer.Close();
    }
}

