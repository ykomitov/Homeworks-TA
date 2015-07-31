// Write a program to compare the performance of:
// square root, natural logarithm, sinus for:
// float, double and decimal
namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    internal class CompareAdvancedMaths
    {
        internal static void Main()
        {
            int numberOfItterations = 10000000;

            // SQRT 
            Stopwatch stopwatchSqrtFloat = new Stopwatch();

            Console.WriteLine("Square root, Float, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchSqrtFloat.Restart();
                float sqrt;

                for (int j = 0; j < numberOfItterations; j++)
                {
                    sqrt = (float)Math.Sqrt(j);
                }

                stopwatchSqrtFloat.Stop();
                Console.WriteLine(stopwatchSqrtFloat.Elapsed);
            }

            Stopwatch stopwatchSqrtDouble = new Stopwatch();

            Console.WriteLine("Square root, Double, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchSqrtDouble.Restart();
                double sqrt;

                for (int j = 0; j < numberOfItterations; j++)
                {
                    sqrt = Math.Sqrt(j);
                }

                stopwatchSqrtDouble.Stop();
                Console.WriteLine(stopwatchSqrtDouble.Elapsed);
            }

            Stopwatch stopwatchSqrtDecimal = new Stopwatch();

            Console.WriteLine("Square root, Decimal, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchSqrtDecimal.Restart();
                decimal sqrt;

                for (int j = 1; j < numberOfItterations; j++)
                {
                    sqrt = (decimal)Math.Sqrt(j);
                }

                stopwatchSqrtDecimal.Stop();
                Console.WriteLine(stopwatchSqrtDecimal.Elapsed);
            }

            // LOG 
            Stopwatch stopwatchLogFloat = new Stopwatch();

            Console.WriteLine("Natural Logarithm, Float, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchLogFloat.Restart();
                float log;

                for (int j = 0; j < numberOfItterations; j++)
                {
                    log = (float)Math.Log(j);
                }

                stopwatchLogFloat.Stop();
                Console.WriteLine(stopwatchLogFloat.Elapsed);
            }

            Stopwatch stopwatchLogDouble = new Stopwatch();

            Console.WriteLine("Natural Logarithm, Double, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchLogDouble.Restart();
                double log;

                for (int j = 0; j < numberOfItterations; j++)
                {
                    log = Math.Log(j);
                }

                stopwatchLogDouble.Stop();
                Console.WriteLine(stopwatchLogDouble.Elapsed);
            }

            Stopwatch stopwatchLogDecimal = new Stopwatch();

            Console.WriteLine("Natural Logarithm, Decimal, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchLogDecimal.Restart();
                decimal log;

                for (int j = 1; j < numberOfItterations; j++)
                {
                    log = (decimal)Math.Log(j);
                }

                stopwatchLogDecimal.Stop();
                Console.WriteLine(stopwatchLogDecimal.Elapsed);
            }

            // SIN 
            Stopwatch stopwatchSinFloat = new Stopwatch();

            Console.WriteLine("Sinus, Float, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchSinFloat.Restart();
                float sin;

                for (double j = 0; j < numberOfItterations; j++)
                {
                    sin = (float)Math.Sin(j);
                }

                stopwatchSinFloat.Stop();
                Console.WriteLine(stopwatchSinFloat.Elapsed);
            }

            Stopwatch stopwatchSinDouble = new Stopwatch();

            Console.WriteLine("Sinus, Double, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchSinDouble.Restart();
                double sin;

                for (int j = 0; j < numberOfItterations; j++)
                {
                    sin = Math.Sin(j);
                }

                stopwatchSinDouble.Stop();
                Console.WriteLine(stopwatchSinDouble.Elapsed);
            }

            Stopwatch stopwatchSinDecimal = new Stopwatch();

            Console.WriteLine("Sinus, Decimal, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchSinDecimal.Restart();
                decimal sin;

                for (int j = 1; j < numberOfItterations; j++)
                {
                    sin = (decimal)Math.Sin(j);
                }

                stopwatchSinDecimal.Stop();
                Console.WriteLine(stopwatchSinDecimal.Elapsed);
            }
        }
    }
}
