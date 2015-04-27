using System;

/*	Write a program that finds the biggest of three numbers.

_Examples:_

| a    | b    | c    | biggest |
|------|------|------|:-------:|
| 5    | 2    | 2    | 5       |
| -2   | -2   | 1    | 1       |
| -2   | 4    | 3    | 4       |
| 0    | -2.5 | 5    | 5       |
| -0.1 | -0.5 | -1.1 | -0.1    |*/

class FindBiggest
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("\r\nBiggest: {0}", Math.Max(Math.Max(a, b), c));
    }
}
