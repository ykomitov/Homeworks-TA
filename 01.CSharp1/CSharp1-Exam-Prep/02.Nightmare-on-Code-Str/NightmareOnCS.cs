using System;
using System.Numerics;

//This problem is simple. You are given a text with some digits. Your task is to find all digits in every odd position (starting from zero) throughout the text and calculate their sum.

class NightmareOnCS
{
    static void Main()
    {
        string input = Console.ReadLine();
        int inputLenght = input.Length;
        int numberOfDigits = 0;
        BigInteger sumOfDigits = 0;

        for (int i = 1; i < inputLenght; i++)
        {
            if (i % 2 != 0 && Char.IsDigit(input[i]))
            {
                numberOfDigits++;
                sumOfDigits += int.Parse(Convert.ToString(input[i]));
            }
        }
        Console.WriteLine("{0} {1}", numberOfDigits, sumOfDigits);
    }
}
