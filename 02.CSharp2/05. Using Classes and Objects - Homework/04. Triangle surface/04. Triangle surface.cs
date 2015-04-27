/*•	Write methods that calculate the surface of a triangle by given:
    o	Side and an altitude to it;
    o	Three sides;
    o	Two sides and an angle between them;
  •	Use System.Math.*/

using System;

class TriangleSurface
{
    static void Main()
    {
        while (true)
        {
            int choise = 0;
            do
            {
                Console.WriteLine("Calculate the surface of a triangle by:");
                Console.WriteLine("1. Side and an altitude to it");
                Console.WriteLine("2. Three sides");
                Console.WriteLine("3. Two sides and an angle between them");
                Console.Write("\r\nPlease choose by entering 1, 2 or 3: ");

                choise = int.Parse(Console.ReadLine());

                if (choise == 1)
                {
                    Console.Write("\r\nPlease enter the side of the triangle: ");
                    decimal side = decimal.Parse(Console.ReadLine());

                    Console.Write("Please enter the altitude to the side: ");
                    decimal altitude = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\r\nThe surface of the triangle is {0:0.00}\r\n", CalculateTriangleSurface(side, altitude));
                }
                else if (choise == 2)
                {
                    Console.Write("\r\nPlease enter side a of the triangle: ");
                    double sideA = double.Parse(Console.ReadLine());

                    Console.Write("Please enter side b of the triangle: ");
                    double sideB = double.Parse(Console.ReadLine());

                    Console.Write("Please enter side c of the triangle: ");
                    double sideC = double.Parse(Console.ReadLine());

                    Console.WriteLine("\r\nThe surface of the triangle is {0:0.00}\r\n", CalculateTriangleSurface(sideA, sideB, sideC));
                }
                else if (choise == 3)
                {
                    Console.Write("\r\nPlease enter side a of the triangle: ");
                    decimal sideA = decimal.Parse(Console.ReadLine());

                    Console.Write("Please enter side b of the triangle: ");
                    decimal sideB = decimal.Parse(Console.ReadLine());

                    Console.Write("Please enter the angle between a & b: ");
                    double angle = double.Parse(Console.ReadLine());

                    Console.WriteLine("\r\nThe surface of the triangle is {0:0.00}\r\n", CalculateTriangleSurface(sideA, sideB, angle));
                }
                else
                {
                    Console.WriteLine("\r\nInvalid input! Please try again.\r\n");
                }
            }
            while (choise != 1 && choise != 2 && choise != 3);
        }
    }

    static decimal CalculateTriangleSurface(decimal side, decimal altitude)
    {
        decimal surface = Math.BigMul((int)Math.Round(altitude), (int)Math.Round(side)) / 2;
        return surface;
    }

    static double CalculateTriangleSurface(double sideA, double sideB, double sideC)
    {
        double s = (sideA + sideB + sideC) / 2;
        double surface = Math.Sqrt((s * (s - sideA) * (s - sideB) * (s - sideC)));
        return surface;
    }

    static double CalculateTriangleSurface(decimal sideA, decimal sideB, double angle)
    {
        double surface = ((double)sideA * (double)sideB / 2) * (Math.Sin(angle * (Math.PI / 180)));
        return surface;
    }
}

