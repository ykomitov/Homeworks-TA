//Write a program that reverses the words in given sentence.
//C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!

using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class ReverseSentence
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";

        //Split the string usisng delimiters array
        string[] delimiters = { ".", ",", "!", "?", " " };
        string pattern = "(" + String.Join("|", delimiters.Select(d => Regex.Escape(d)).ToArray()) + ")";
        string[] result = Regex.Split(input, pattern);

        //Extract all substrings from the result array & put them in a list
        List<string> reversed = new List<string>();
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (result[i] != String.Empty & result[i] != " ")
            {
                reversed.Add(result[i]);
            }
        }

        StringBuilder sb = new StringBuilder();

        //Start from the second element in the list & add the final punctuation in the last itteration
        for (int i = 1; i <= reversed.Count - 1; i++)
        {
            if (i < reversed.Count - 1)
            {
                //If next in the list there is a punctuation sign, do not add a space
                if (reversed[i + 1] == "." | reversed[i + 1] == "," | reversed[i + 1] == "!" | reversed[i + 1] == "?")
                {
                    sb.Append(reversed[i]);
                }
                else
                {
                    sb.Append(reversed[i]);
                    sb.Append(" ");
                }
            }
            //After the last element of the list, add the final punctuation sign
            else
            {
                sb.Append(reversed[i]);
                sb.Append(reversed[0]);
            }
        }
        Console.WriteLine(sb.ToString());
    }
}

