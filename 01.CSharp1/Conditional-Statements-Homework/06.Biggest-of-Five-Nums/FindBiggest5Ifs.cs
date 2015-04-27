using System;

/*	Write a program that finds the biggest of five numbers by using only five if statements.

_Examples:_

| a    | b    | c    |  d |   e  | biggest |
|------|------|------|:--:|:----:|---------|
| 5    | 2    | 2    | 4  | 1    | 5       |
| -2   | -22  | 1    | 0  | 0    | 1       |
| -2   | 4    | 3    | 2  | 0    | 4       |
| 0    | -2.5 | 0    | 5  | 5    | 5       |
| -3   | -0.5 | -1.1 | -2 | -0.1 | -0.1    |*/

class FindBiggest5Ifs
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());

        if ((a > b && a > c && a > d && a > e) || (a == b && a > c && a > d && a > e) || (a > b && a == c && a > d && a > e) || (a > b && a > c && a == d && a > e) || (a > b && a > c && a > d && a == e))
        {
            Console.WriteLine("\r\nBiggest: {0}", a);
        }
        else if ((b > a && b > c && b > d && b > e) || (b == a && b > c && b > d && b > e) || (b > a && b == c && b > d && b > e) || (b > a && b > c && b == d && b > e) || (b > a && b > c && b > d && b == e))
        {
            Console.WriteLine("\r\nBiggest: {0}", b);
        }
        else if ((c > a && c > b && c > d && c > e) || (c == a && c > b && c > d && c > e) || (c > a && c == b && c > d && c > e) || (c > a && c > b && c == d && c > e) || (c > a && c > b && c > d && c == e))
        {
            Console.WriteLine("\r\nBiggest: {0}", c);
        }
        else if ((d > a && d > b && d > c && d > e) || (d == a && d > b && d > c && d > e) || (d > a && d == b && d > c && d > e) || (d > a && d > b && d == c && d > e) || (d > a && d > b && d > c && d == e))
        {
            Console.WriteLine("\r\nBiggest: {0}", d);
        }
        else
        {
            Console.WriteLine("\r\nBiggest: {0}", e);
        }
    }
}
