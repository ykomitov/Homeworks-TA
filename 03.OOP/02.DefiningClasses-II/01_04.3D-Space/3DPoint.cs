namespace Space3D
{
    using System;

    public struct Point3D
    {
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        /*Problem 2. Static read-only field

        Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        Add a static property to return the point O.*/

        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }
        //==> Problem 2 ends

        public override string ToString()
        {
            string point = string.Format("Point: {{X={0}, Y={1}, Z={2}}}", this.X, this.Y, this.Z);
            return point;
        }
    }
}
