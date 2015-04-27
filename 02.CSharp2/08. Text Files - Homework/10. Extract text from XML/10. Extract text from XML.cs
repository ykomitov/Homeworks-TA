//Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class ExtractTextFromXML
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../note.xml");
        string input = reader.ReadToEnd();

        string pattern = @">\w+</";
        List <string> dataCollection = Regex.Matches(input, pattern).Cast<Match>().Select(m => m.Value).ToList();

        for (int i = 0; i < dataCollection.Count; i++)
        {
            dataCollection[i] = dataCollection[i].Trim(new Char[] { '>', '<', '/' });
        }

        foreach (var item in dataCollection)
        {
            Console.WriteLine(item);
        }
        reader.Close();
    }
}

