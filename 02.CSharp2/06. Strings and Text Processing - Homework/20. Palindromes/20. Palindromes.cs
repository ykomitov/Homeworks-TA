//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

class Palindromes
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi . It is also not ABBA, lamal but it can produce exe files if you know what you're doing. Do you?";

        //Split the string usisng delimiters array
        string[] delimiters = { ".", ",", "!", "?", " " };
        string pattern = "(" + String.Join("|", delimiters.Select(d => Regex.Escape(d)).ToArray()) + ")";
        string[] result = Regex.Split(input, pattern);

        //Extract all substrings >1 char from the result array & put them in a list
        List<string> wordArray = new List<string>();
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] != String.Empty & result[i] != " " & result[i].Length > 1)
            {
                wordArray.Add(result[i]);
            }
        }

        //Check for palindromes and if found save them in a palindromes list
        List<string> palindromes = new List<string>();

        foreach (var word in wordArray)
        {
            char[] reversedArray = word.ToLower().ToCharArray(); //each word in the list to char array
            Array.Reverse(reversedArray);                        //reverse the array
            string reversedString = new string(reversedArray);   //reversed array to string   

            if (word.ToLower() == reversedString.ToLower())      //compare reversed string with the original word
            {
                palindromes.Add(word);                           //add to palindrome list if word = reversed word
            }
        }

        //Print the input string and all palindromes in it
        Console.WriteLine(input);
        Console.WriteLine("\r\nPalindromes: ");
        foreach (var pal in palindromes)
        {
            Console.WriteLine(pal);
        }
    }
}
