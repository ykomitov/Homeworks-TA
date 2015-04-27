//Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Last digit is {0}.", DigitToString(a));
    }

    static string DigitToString(int inputNumber)
    {
        int inputDigit = inputNumber % 10;
        switch (inputDigit)
        {
            case 0: return "zero"; break;
            case 1: return "one"; break;
            case 2: return "two"; break;
            case 3: return "three"; break;
            case 4: return "four"; break;
            case 5: return "five"; break;
            case 6: return "six"; break;
            case 7: return "seven"; break;
            case 8: return "eight"; break;
            case 9: return "nine"; break;
            default: return "Error!"; break;
        }
    }
}

