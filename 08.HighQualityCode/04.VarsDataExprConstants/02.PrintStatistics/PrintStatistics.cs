// Refactor the following code to apply variable usage and naming best practices:

namespace _02.PrintStatistics
{
    using System;

    public class PrintStatistics
    {
        public static void Main()
        {
            var sampleArr = new double[] { 6, 4, 5, 5 };

            PrintMax(sampleArr);
            PrintMin(sampleArr);
            PrintAvg(sampleArr);
        }

        public static void PrintMax(double[] arr)
        {
            double max = double.MinValue;
            int count = arr.Length;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);
        }

        public static void PrintMin(double[] arr)
        {
            double min = double.MaxValue;
            int count = arr.Length;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine(min);
        }

        public static void PrintAvg(double[] arr)
        {
            double sum = 0;
            int count = arr.Length;
            double average;

            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            average = sum / count;
            Console.WriteLine(average);
        }
    }
}
