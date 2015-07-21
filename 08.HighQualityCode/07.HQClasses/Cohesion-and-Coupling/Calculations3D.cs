namespace CohesionAndCoupling
{
    using System;

    internal class Calculations3D : Shape
    {
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
            return distance;
        }

        public static double CalcDiagonalXYZ(Shape shape)
        {
            double distance = Calculations3D.CalcDistance3D(0, 0, 0, shape.Width, shape.Height, shape.Depth);
            return distance;
        }

        public static double CalcVolume(Shape shape)
        {
            double volume = shape.Width * shape.Height * shape.Depth;
            return volume;
        }
    }
}
