using System;
using System.Numerics;

/*	Using loops write a program that converts a binary integer number to its decimal form.
*	The input is entered as string. The output should be a variable of type long.
*	Do not use the built-in .NET functionality.

_Examples:_

| binary                       | decimal   |
|------------------------------|-----------|
| 0                            | 0         |
| 11                           | 3         |
| 1010101010101011             | 43691     |
| 1110000110000101100101000000 | 236476736 |*/

class BinToDec
{
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string binNum = Console.ReadLine();
        long decimalNum = 0;
        for (int i = 0; i < binNum.Length; i++)
        {
            if ((binNum[i] - '0') == 1)
            {
                decimalNum += ((binNum[i] - '0') * (long)BigInteger.Pow(2, (binNum.Length - i - 1)));
            }
        }
        Console.WriteLine("The binary number {0} is {1} in decimal.", binNum, decimalNum);
    }
}
