/*	Write a program that creates an array containing all letters from the alphabet (`A-Z`).
*	Read a word from the console and print the index of each of its letters in the array.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = {
' ','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
    'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
                          };
        Console.Write("Please enter a text string to convert: ");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (input[i] == alphabet[j])
                {
                    Console.Write("{0} ", j);
                }
            }
        }
        Console.WriteLine();
    }
}
