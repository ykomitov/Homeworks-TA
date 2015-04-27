/*Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt. The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class CountWords
{
    static void Main()
    {
        //read the words & place them in a string array
        string[] words = File.ReadAllLines("../../words.txt");
        
        //count the occurances
        int[] countWords = new int[words.Length];

        using (StreamReader reader = new StreamReader("../../test.txt"))
        {
            string input = reader.ReadToEnd().ToLower();
            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                string expression = String.Format(@"{0}", words[i]);
                count = input.Select((c, j) => input.Substring(j)).Count(sub => sub.StartsWith(expression));
                countWords[i] = count;
            }
        }
        //sort the two arrays using countWords as a key & reverse to be in descending order
        Array.Sort(countWords, words);
        Array.Reverse(countWords);
        Array.Reverse(words);

        //merge the two arrays in the output file
        using (StreamWriter writer = new StreamWriter("../../result.txt"))
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (countWords[i] == 1)
                {
                    writer.WriteLine("{0} - {1} time", words[i], countWords[i]);
                }
                else
                {
                    writer.WriteLine("{0} - {1} times", words[i], countWords[i]);
                }
            }
        }
        Console.WriteLine("Live long and prosper!");
    }
}

