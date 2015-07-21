namespace Abstraction
{
    using System;

    internal abstract class Figure
    {
        public Figure()
        {
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        public void ValidateFigureInput(double input)
        {
            if (input <= 0)
            {
                throw new ArgumentException("Figure properties must be >= 0!");
            }
        }
    }
}
