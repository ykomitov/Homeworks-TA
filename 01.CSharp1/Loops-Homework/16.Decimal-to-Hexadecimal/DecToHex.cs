using System;
using System.Linq;

/*	Using loops write a program that converts an integer number to its hexadecimal representation.
*	The input is entered as long. The output should be a variable of type string.
*	Do not use the built-in .NET functionality.

_Examples:_

| decimal      | hexadecimal |
|--------------|-------------|
| 254          | FE          |
| 6883         | 1AE3        |
| 338583669684 | 4ED528CBB4  |*/

class DecToHex
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        long n = long.Parse(Console.ReadLine());
        long nOriginal = n;
        int numSystemBase = 16; //<--------------------------- Can be changed in order to use the code for other numerical systems

        string input = "";
        long remainder = 0;

        //Convert "n" to a string in reversed order in the selected numerical system
        do
        {
            remainder = n % numSystemBase;
            n = n / numSystemBase;
            string remString = remainder.ToString();
            switch (remString)
            {
                case "10": remString = "A"; break;
                case "11": remString = "B"; break;
                case "12": remString = "C"; break;
                case "13": remString = "D"; break;
                case "14": remString = "E"; break;
                case "15": remString = "F"; break;
                default:                    break;
            }
            input = input + remString;
        }
        while (n > 0);

        //Reverse the string "input" to get a correct binary representation of "n"
        string nHex = new string(input.ToCharArray().Reverse().ToArray());
        Console.WriteLine("The decimal number {0} is {1} in hexadecimal.", nOriginal, nHex);
    }
}
