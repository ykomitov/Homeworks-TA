namespace CohesionAndCoupling
{
    using System;

    internal class Calculations2D : Shape
    {
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static double CalcDiagonalXY(Shape shape)
        {
            double distance = CalcDistance2D(0, 0, shape.Width, shape.Height);
            return distance;
        }

        public static double CalcDiagonalXZ(Shape shape)
        {
            double distance = CalcDistance2D(0, 0, shape.Width, shape.Depth);
            return distance;
        }

        public static double CalcDiagonalYZ(Shape shape)
        {
            double distance = CalcDistance2D(0, 0, shape.Height, shape.Depth);
            return distance;
        }
    }
}
