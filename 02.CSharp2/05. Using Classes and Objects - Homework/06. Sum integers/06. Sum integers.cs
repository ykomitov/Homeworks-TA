//•	You are given a sequence of positive integer values written into a string, separated by spaces.
//•	Write a function that reads these values from given string and calculates their sum.

using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter a sequence of positive integers, separated by spaces.");
        string input = Console.ReadLine();

        Console.WriteLine("Sum is {0}", SumInts(input));
    }

    static int SumInts(string input)
    {
        //Split the string into an integer array
        int[] inputArray = input.Replace("  ", " ").Split(' ').Select(substring => int.Parse(substring)).ToArray();
        
        //Sum the array
        int sum = inputArray.Sum();
        return sum;
    }
}

