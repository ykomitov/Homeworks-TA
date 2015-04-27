using System;

/*	Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

_Examples:_

| a    | b   | result  |
|------|-----|---------|
| 5    | 2   | 2 5     |
| 3    | 4   | 3 4     |
| 5.5  | 4.5 | 4.5 5.5 |*/

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        double swap;

        if (a > b)
        {
            swap = a;
            a = b;
            b = swap;
            Console.WriteLine("\r\n{0} {1}\r\n", a, b);
        }
        else
        {
            Console.WriteLine("\r\n{0} {1}\r\n", a, b);
        } 
    }
}