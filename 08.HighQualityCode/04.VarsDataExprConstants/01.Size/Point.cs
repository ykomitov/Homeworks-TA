// Refactor the following code to use proper variable naming and simplified expressions:
namespace Problem1
{
    using System;

    public class Point
    {
        private double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point GetRotatedCoordinates(Point pointBeforeRotation, double angleOfRotation)
        {
            double xRotated = (pointBeforeRotation.x * Math.Cos(angleOfRotation)) - (pointBeforeRotation.y * Math.Sin(angleOfRotation));
            double yRotated = (pointBeforeRotation.y * Math.Cos(angleOfRotation)) + (pointBeforeRotation.x * Math.Sin(angleOfRotation));

            return new Point(xRotated, yRotated);
        }

        public override string ToString()
        {
            return string.Format("{0} ({1:0.00}; {2:0.00})", this.GetType().Name, this.x, this.y);
        }
    }
}