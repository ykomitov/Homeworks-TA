// 	Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

using System;
using System.Linq;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        string input = "-a3094b23b35c0c9AB9B9cAB.BA2A5B";
        //Get all distinct characters into a string
        string distinctChars = new String(input.Distinct().ToArray());

        //Get all distinct characters into a char array
        char[] distinctCharArray = distinctChars.ToCharArray();

        //Itterate through the array to test each char
        foreach (var character in distinctCharArray)
        {
            if (Char.IsLetter(character))                                       //test if current char is a letter
            {
                int count = input.Count(x => x == character);                   //count occurences of each letter
                Console.WriteLine("{0} repeated {1} times", character, count);  //print result on the console
            }
        }
        Console.WriteLine();
    }
}

