using System;
using System.Linq;

/*	Using loops write a program that converts an integer number to its binary representation.
*	The input is entered as long. The output should be a variable of type string.
*	Do not use the built-in .NET functionality.

_Examples:_

| decimal           | binary                       |
|-------------------|------------------------------|
| 0                 | 0                            |
| 3                 | 11                           |
| 43691             | 1010101010101011             |
| 236476736         | 1110000110000101100101000000 |*/

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
        Console.WriteLine("The decimal number {0} is {1} in binary.", nOriginal, nBinary);
    }
}
