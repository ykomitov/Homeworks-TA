//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Numerics;

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
        Console.WriteLine("\r\nThe binary number {0} is {1} in decimal.", binNum, decimalNum);
    }
}



