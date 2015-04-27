/*A dictionary is stored as a sequence of text lines containing words and their explanations.
  hWrite a program that enters a word and translates it by using the dictionary.*/

//  input 	    output
//  .NET      	platform for applications from Microsoft
//  CLR 	    managed execution environment for .NET
//  namespace 	hierarchical organization of classes

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        //Perform case insensitive search for the key with StringComparer.InvariantCultureIgnoreCase
        Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
        {
          {".NET", "platform for applications from Microsoft"},
          {"CLR", "managed execution environment for .NET"},
          {"namespace", "hierarchical organization of classes"}
        };

        while (true)
        {
            Console.Write("Enter a word to translate: ");
            string input = Console.ReadLine();

            if (dictionary.ContainsKey(input))
            {
                Console.WriteLine("\r\n{0}: {1}\r\n\r\n", input, dictionary[input]);
            }
            else
            {
                Console.WriteLine("\r\nThe word does not exist in this dictionary!\r\n\r\n");
            }
        }
    }
}
