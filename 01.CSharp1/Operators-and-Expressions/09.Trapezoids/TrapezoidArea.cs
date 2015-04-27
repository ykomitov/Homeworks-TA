﻿using System;

/*Write an expression that calculates trapezoid's area by given sides `a` and `b` and height `h`.
_Examples:_

|   a   |   b   |   h   |    area   |
|:-----:|:-----:|:-----:|:---------:|
| 5     | 7     | 12    | 72        |
| 2     | 1     | 33    | 49.5      |
| 8.5   | 4.3   | 2.7   | 17.28     |
| 100   | 200   | 300   | 45000     |
| 0.222 | 0.333 | 0.555 | 0.1540125 |*/

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Please enter the lenght of side a of trapezoid: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the lenght of side b of trapezoid: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the height h of trapezoid: ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("The trapezoid's area is: "+((a+b)/2)*h);
    }
}
