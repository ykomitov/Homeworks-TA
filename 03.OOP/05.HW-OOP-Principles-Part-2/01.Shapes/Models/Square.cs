namespace Shapes.Models
{
    using System;

    class Square : Shape
    {
        public Square(double side)
            : base(side)
        {
        }

        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width;
            return surface;
        }
    }
}
