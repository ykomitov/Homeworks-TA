using System;

/*	Write a program that reads 3 real numbers from the console and prints their sum.

_Examples:_

|      a      |   b  |   c  |  sum |
|:-----------:|:----:|:----:|:----:|
| 3           | 4    | 11   | 18   |
| -2          | 0    | 3    | 1    |
| 5.5         | 4.5  | 20.1 | 30.1 |*/

class SumNumbers
{
    static void Main()
    {
        Console.Write("Please input double a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please input double b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please input double c: ");
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("\r\nSum of the input numbers is: "+sum);
    }
}