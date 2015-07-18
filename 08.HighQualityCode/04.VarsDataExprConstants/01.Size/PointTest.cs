namespace Problem1
{
    using System;

    public class SizeTest
    {
        public static void Main()
        {
            Point somePoint = new Point(3.14, 5.67);
            Point rotatedPoint = Point.GetRotatedCoordinates(somePoint, 10);

            Console.WriteLine(somePoint);
            Console.WriteLine(rotatedPoint);
        }
    }
}
