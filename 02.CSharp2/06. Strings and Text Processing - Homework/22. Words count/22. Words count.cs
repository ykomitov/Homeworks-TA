//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        string input = Console.ReadLine();
        //string input = "C# is not C++, not PHP and not and Delphi. Do you?";

        //Split the string usisng delimiters array
        string[] delimiters = { ".", ",", "!", "?", " " };
        string pattern = "(" + String.Join("|", delimiters.Select(d => Regex.Escape(d)).ToArray()) + ")";
        string[] result = Regex.Split(input, pattern);

        List<string> wordArray = new List<string>();
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] != String.Empty & result[i] != " ")
            {
                wordArray.Add(result[i].ToLower());
            }
        }

        //Create list of distinct words
        List<string> wordDistinct = wordArray.Distinct().ToList();

        //Itterate through the array & count occurances of each word
        Console.WriteLine(input);
        foreach (var word in wordDistinct)
        {
            if (word.Length > 1)
            {
                int count = wordArray.Count(x => x == word);
                Console.WriteLine("{0}: {1} times", word, count);
            }
            else if (word.Length == 1) //if lenght is 1, process it only if the char is a letter
            {
                char[] tempChar = word.ToCharArray();
                if (Char.IsLetter(tempChar[0]))
                {
                    int count = wordArray.Count(x => x == word);
                    Console.WriteLine("{0}: {1} times", word, count);
                }
            }
        }
        Console.WriteLine();
    }
}

