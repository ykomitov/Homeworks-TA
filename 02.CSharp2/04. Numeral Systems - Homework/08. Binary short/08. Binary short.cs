//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Please enter a \"short\" number (from -32,768 to 32,767): ");
        short a = short.Parse(Console.ReadLine());

        string binaryStringA = "";

        binaryStringA = Convert.ToString(a, 2).PadLeft(16, '0');

        Console.WriteLine("\r\n short: {0}\r\nbinary: {1}\r\n", a, binaryStringA);

    }
}
