using System;

//Write an expression that checks if given integer is odd or even.

class CheckOddEven
{
    static void Main()
    {
        Console.Write("Please intup an integer: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(input % 2 == 0 ? "Integer is even" : "Integer is odd");
    }
}
