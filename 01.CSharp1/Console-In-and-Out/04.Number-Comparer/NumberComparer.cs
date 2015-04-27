using System;

/*	Write a program that gets two numbers from the console and prints the greater of them.
	Try to implement this without if statements.

_Examples:_

|  a  |  b  | greater |
|:---:|:---:|:-------:|
| 5   | 6   | 6       |
| 10  | 5   | 10      |
| 0   | 0   | 0       |
| -5  | -2  | -2      |
| 1.5 | 1.6 | 1.6     |*/

class NumberComparer
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        double b = double.Parse(Console.ReadLine());
        bool aB = a > b;
        bool bA = b > a;
        bool equal = a == b;
        Console.WriteLine(equal ? "Numbers are equal." : aB ? "a = {0} > b" : bA ? "b = {1} > a" : "Unknown error!", a, b);
    }
}
