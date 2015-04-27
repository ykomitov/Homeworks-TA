/*•	Write a program that reads an integer number and calculates and prints its square root.
    o	If the number is invalid or negative, print Invalid number.
    o	In all cases finally print Good bye.
  •	Use try-catch-finally block.*/

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        try
        {
            uint input = uint.Parse(Console.ReadLine());
            double sqRoot = Math.Sqrt(input);
            Console.WriteLine("Square root: {0}", sqRoot);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

