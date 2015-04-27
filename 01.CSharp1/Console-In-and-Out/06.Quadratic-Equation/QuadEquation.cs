using System;

/*  Write a program that reads the coefficients `a`, `b` and `c` of a quadratic equation ax<sup>2</sup> + bx + c = 0 and solves it (prints its real roots).

_Examples:_

|   a  |  b  |  c  |     roots     |
|:----:|:---:|:---:|---------------|
| 2    | 5   | -3  | x1=-3; x2=0.5 |
| -1   | 3   | 0   | x1=3; x2=0    |
| -0.5 | 4   | -8  | x1=x2=4       |
| 5    | 2   | 8   | no real roots |*/

class QuadEquation
{
    static void Main()
    {
        double a;

        do
        {
            Console.Write("Please input coefficient a: ");
            a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("\r\nCoefficient a must not be equal to 0!\r\n");
            }
        }
        while (a == 0);

        Console.Write("Please input coefficient b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Please input coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        double d = (b * b) - (4 * a * c);

        if (d < 0) Console.WriteLine("Equasion doesn't have any real roots!");
        if (d == 0) Console.WriteLine("Equasion has one real root x = " + (-b / (2 * a)));
        if (d > 0) Console.WriteLine("Equasion has two real roots x1 = " + (-b - Math.Sqrt(d)) / (2 * a) + " and x2 = " + ((-b + Math.Sqrt(d)) / (2 * a)));
    }
}
