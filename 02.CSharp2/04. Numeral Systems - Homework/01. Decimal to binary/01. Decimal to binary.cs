//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Linq;

class DecToBin
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        long n = long.Parse(Console.ReadLine());
        long nOriginal = n;
        int numSystemBase = 2; //<--------------------------- Can be changed in order to use the code for other numerical systems

        string input = "";
        long remainder = 0;

        //Convert "n" to a string in reversed order in the selected numerical system
        do
        {
            remainder = n % numSystemBase;
            n = n / numSystemBase;
            input = input + remainder;
        }
        while (n > 0);

        //Reverse the string "input" to get a correct binary representation of "n"
        string nBinary = new string(input.ToCharArray().Reverse().ToArray());
        Console.WriteLine("\r\nThe decimal number {0} is {1} in binary.", nOriginal, nBinary);
    }
}
