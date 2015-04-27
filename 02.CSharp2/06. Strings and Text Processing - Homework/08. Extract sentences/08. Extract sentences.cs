//Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;


class ExtractSentences
{

    static void Main(string[] args)
    {
        string s = "Someone, please put me out of my misery. Wordmatch! Second sentence. I hate wordmatch, you know. Fourth sentence containing wordmatch? Another one; You're a smart guy, you'll figure it out. An at last - the last wordmatch, end of my misery!";
        
        Console.WriteLine(s);

        //string starting from, but excluding [^.!?;]* not case sensitive (?i) only include sentences containing (wordmatch)
        //until,but excluding [^.!?;]* add [.!?;] one time {1}
        Regex r = new Regex("[^.!?;]*(?i)(wordmatch)[^.!?;]*[.!?;]{1}");
        MatchCollection extraction = r.Matches(s);

        List<string> results = Enumerable.Range(0, extraction.Count).Select(index => extraction[index].Value.Trim()).ToList();
        
        //Print sentenses which fit the condition
        Console.WriteLine("\r\nSentences:\r\n");
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
        Console.WriteLine();
    }
}