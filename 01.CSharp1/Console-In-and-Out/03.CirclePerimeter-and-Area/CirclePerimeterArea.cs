using System;

/**	Write a program that reads the radius `r` of a circle and prints its perimeter and area formatted with `2` digits after the decimal point.

_Examples:_

|          r          |          perimeter         |  area |
|:-------------------:|:--------------------------:|:-----:|
| 2                   | 12.57                      | 12.57 |
| 3.5                 | 21.99                      | 38.48 |*/

class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("Please input the radius r of a circle: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;
        Console.WriteLine("The perimeter of the circle with radius r = {0} is {1:0.00}. The area of the circle is {2:0.00}", r, perimeter, area);
    }
}