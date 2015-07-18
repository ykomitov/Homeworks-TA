namespace Methods
{
    using System;

    internal class Methods
    {
        // Calculated through Heron's formula: https://en.wikipedia.org/wiki/Heron%27s_formula
        internal static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive!");
            }

            double semiperimeter = (a + b + c) / 2;
            double triangleArea = Math.Sqrt(
                semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
            return triangleArea;
        }

        internal static string DigitToText(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentOutOfRangeException("Invalid digit. Input should be a digit: 0-9");
            }
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Input array is null or empty!");
            }

            int max = int.MinValue;
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        internal static void PrintFormattedNumber(double number, string formatModifier)
        {
            if (formatModifier == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (formatModifier == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (formatModifier == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new Exception("Invalid format modifier!");
            }
        }

        internal static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        internal static bool IsHorizontal(double x1, double y1, double x2, double y2)
        {
            bool isHorizontal = y1 == y2;
            return isHorizontal;
        }

        internal static bool IsVertical(double x1, double y1, double x2, double y2)
        {
            bool isVertical = x1 == x2;
            return isVertical;
        }
    }
}
