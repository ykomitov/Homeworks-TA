//	Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Text.RegularExpressions;
using System.Linq;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Please enter a list of words, seperated by spaces: ");
        string input = Console.ReadLine();

        //Split the string into array & sort it
        string[] inputSplit = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(inputSplit);

        string result = string.Join(" ", inputSplit);

        Console.WriteLine("\r\nThe list in alphabetical order is: \r\n{0}\r\n", result);
    }
}
