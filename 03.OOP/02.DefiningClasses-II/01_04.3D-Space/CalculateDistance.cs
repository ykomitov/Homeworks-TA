namespace Space3D
{
    using System;

    public static class CalculateDistance
    {
        public static double Distance(Point3D a, Point3D b)
        {
            double deltaX = (b.X - a.X);
            double deltaY = (b.Y - a.Y);
            double deltaZ = (b.Z - a.Z);
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            return distance;
        }
    }
}
