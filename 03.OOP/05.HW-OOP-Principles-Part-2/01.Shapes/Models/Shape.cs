namespace Shapes.Models
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Shape(double side)
        {
            this.Width = side;
            this.Height = side;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be greater than 0!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be greater than 0!");
                }
                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            string shapeType = this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf('.') + 1, this.GetType().ToString().Length - this.GetType().ToString().LastIndexOf('.') - 1);
            return shapeType.ToLower();
        }
    }
}
