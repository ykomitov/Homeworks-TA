//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

using System;

namespace IntegerCalculations
{
    public class IntegerCalculations
    {
        static void Main()
        {
            Console.WriteLine(Sum(3, -5, 3, 6, 7));     //14
            Console.WriteLine(Product(3, -5, 3, 6, 7)); //-1890
            Console.WriteLine(Average(3, -5, 3, 6, 7)); //2.8
            Console.WriteLine(Min(3, -5, 3, 6, 7));     //-5
            Console.WriteLine(Max(3, -5, 3, 6, 7));     //7
        }

        public static decimal Sum(params int[] elements)
        {
            decimal sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return sum;
        }

        public static decimal Product(params int[] elements)
        {
            decimal product = 1;
            foreach (int element in elements)
            {
                if (element == 0)
                {
                    continue;
                }
                else
                {
                    product *= element;
                }
            }
            return product;
        }

        public static decimal Average(params object[] elements)
        {
            decimal sum = 0;
            decimal counter = 0;
            foreach (int element in elements)
            {
                sum += element;
                counter++;
            }
            return (sum / counter);
        }

        public static decimal AverageArr(int[] elements)
        {
            decimal sum = 0;
            decimal counter = 0;
            foreach (int element in elements)
            {
                sum += element;
                counter++;
            }
            return (sum / counter);
        }
        public static decimal Min(params int[] elements)
        {
            decimal minimum = decimal.MaxValue;
            foreach (decimal element in elements)
            {
                if (element < minimum)
                {
                    minimum = element;
                }
            }
            return minimum;
        }

        public static decimal Max(params int[] elements)
        {
            decimal maximum = decimal.MinValue;
            foreach (decimal element in elements)
            {
                if (element > maximum)
                {
                    maximum = element;
                }
            }
            return maximum;
        }
    }
}