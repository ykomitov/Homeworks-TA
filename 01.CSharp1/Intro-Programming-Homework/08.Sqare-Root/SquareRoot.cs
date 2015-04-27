using System;

//Create a console application that calculates and prints the square root of the number `12345`.

class SquareRoot
{
    static void Main(string[] args)
    {
        double num = 12345;
        Console.WriteLine("The square root of 12345 is: {0:0.00}", Math.Sqrt(num)); //{0:0.00} - square root with decimal precision of 2 digits
    }
}
