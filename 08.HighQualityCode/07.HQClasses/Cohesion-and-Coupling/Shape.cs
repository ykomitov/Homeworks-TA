namespace CohesionAndCoupling
{
    using System;

    internal class Shape
    {
        private double width;
        private double height;
        private double depth;

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
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
                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                this.depth = value;
            }
        }
    }
}
