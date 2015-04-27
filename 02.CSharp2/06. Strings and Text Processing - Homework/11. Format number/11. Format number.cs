/*•	Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.*/

using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Please input a number: ");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("\r\n   Decimal: {0,15:D}", input);
        Console.WriteLine("       HEX: {0,15:X}", input);
        Console.WriteLine("Percentage: {0,15:P}", input/100.0);
        Console.WriteLine("Scientigic: {0,15:E}\r\n", input);
    }
}

