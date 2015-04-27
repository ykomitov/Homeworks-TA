using System;

/*Write an expression that calculates rectangle's perimeter and area by given width and height.

_Examples:_

| width | height | perimeter | area |
|:-----:|:------:|:---------:|:----:|
| 3     | 4      | 14        | 12   |
| 2.5   | 3      | 11        | 7.5  |
| 5     | 5      | 20        | 25   |*/

class RectanglePerimeterArea
{
    static void Main()
    {
        Console.Write("Please intup a rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please intup a rectangle's height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Rectangle's perimeter is {0}.", (2 * (width + height)));
        Console.WriteLine("Rectangle's area is {0}.", (width * height));
    }
}
