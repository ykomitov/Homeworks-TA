namespace Shapes.Models
{
    using System;

    public class ShapesMain
    {
        static void Main()
        {
            Shape[] arrOfShapes = new Shape[] { new Triangle(3, 5.0),
                                                new Rectangle(3.5, 2),
                                                new Square(5)};
            int position = 0;
            foreach (var shape in arrOfShapes)
            {
                Console.WriteLine("The {0} at index {1} in the array of shapes has an area of {2}."
                    , shape.ToString()
                    , position
                    , shape.CalculateSurface());
                position++;
            }
        }
    }
}