/*Write a program that counts how many times each word from given text file words.txt appears in it. The character casing differences should be ignored. The result words should be ordered by their number of occurrences in the text. Example:

This is the TEXT. Text, text, text – THIS TEXT! Is this the text?

    is -> 2
    the -> 2
    this -> 3
    text -> 6
*/

namespace _03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var wordCount = new Dictionary<string, int>();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("../../words.txt");
            while ((line = file.ReadLine()) != null)
            {
                var wordsInLine = line.Split(new string[] { ",", "?", ".", "!", "\'", " ", "\'s", "-" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in wordsInLine)
                {
                    var currentKey = word.ToLower();
                    if (!wordCount.ContainsKey(currentKey))
                    {
                        wordCount.Add(currentKey, 1);
                    }
                    else
                    {
                        wordCount[currentKey] += 1;
                    }
                }
            }

            file.Close();

            List<KeyValuePair<string, int>> sortedWords = wordCount.ToList();
            sortedWords
                .Sort(delegate(KeyValuePair<string, int> firstPair, KeyValuePair<string, int> nextPair)
                {
                    return firstPair.Value.CompareTo(nextPair.Value);
                });

            foreach (var word in sortedWords)
            {
                Console.WriteLine("{0}: {1}", word.Key, word.Value);
            }
        }
    }
}
