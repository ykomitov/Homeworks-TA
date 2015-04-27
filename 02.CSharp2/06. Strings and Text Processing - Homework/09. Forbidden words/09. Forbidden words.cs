/*We are given a string containing a list of forbidden words and a text containing some of these words.
  Write a program that replaces the forbidden words with asterisks.*/

using System;
using System.Text.RegularExpressions;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string input = "Someone, please put me out of my misery. Wordmatch! Second sentence. I hate wordmatch, you know. Fourth sentence containing wordmatch? Another one; You're a smart guy, you'll figure it out. An at last - the last wordmatch, end of my misery!";

        Console.WriteLine(input);

        string[] forbiddenWords = { "please", "wordmatch", "guy" };
        string s = String.Empty;
       
        
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            //Add (?i) to be case insensitive
            string pat1 = "(?i)" + string.Format(@"(\b{0}\b)", forbiddenWords[i]); //itterate through the array of forbidden words
            string pat2 =  new String('*', forbiddenWords[i].Length); //replace each forbiden word with asterisks = word lenght 
            
            if (i == 0)
            {
                s = Regex.Replace(input, @pat1, @pat2);
            }
            else
            {
                s = Regex.Replace(s, @pat1, @pat2);
            }
        }
        Console.WriteLine(s);
    }
}

