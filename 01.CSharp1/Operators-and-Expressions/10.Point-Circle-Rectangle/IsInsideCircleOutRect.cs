using System;

/*Write an expression that checks for given point (x, y) if it is within the circle `K({1, 1}, 1.5)` and out of the rectangle `R(top=1, left=-1, width=6, height=2)`.

_Examples:_

|   x  |   y  | inside K & outside of R |
|:----:|:----:|:-----------------------:|
| 1    | 2    | yes                     |
| 2.5  | 2    | no                      |
| 0    | 1    | no                      |
| 2.5  | 1    | no                      |
| 2    | 0    | no                      |
| 4    | 0    | no                      |
| 2.5  | 1.5  | no                      |
| 2    | 1.5  | yes                     |
| 1    | 2.5  | yes                     |
| -100 | -100 | no                      |*/

class IsInsideCircleOutRect
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        //Circle
        double circleX = 1;
        double circleY = 1;
        double circleR = 1.5;

        bool insideCircle = (x - circleX) * (x - circleX) + (y - circleY) * (y - circleY) <= circleR * circleR;
        Console.WriteLine(insideCircle);

        //Rectangle
        double x1 = -1;
        double x2 = 5;
        double y1 = 1;
        double y2 = -1;

        bool outsideRectangle = (x  < x1 || x > x2 || y > y1 || y < y2);
        Console.WriteLine(outsideRectangle);
        bool test = insideCircle && outsideRectangle;
        Console.WriteLine("The given point (x, y) is within the circle K and out of the rectangle R: "+test);
    }
}