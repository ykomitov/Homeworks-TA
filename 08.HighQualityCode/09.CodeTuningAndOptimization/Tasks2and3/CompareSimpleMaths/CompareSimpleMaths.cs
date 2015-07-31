// Write a program to compare the performance of:
// add, subtract, increment, multiply, divide for:
// int, long, float, double and decimal
namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;
    using System.Numerics;

    internal class CompareSimpleMaths
    {
        internal static void Main()
        {
            int numberOfItterations = 10000;

            // INTEGER 
            Stopwatch stopwatchIntAdd = new Stopwatch();

            Console.WriteLine("Add, int, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchIntAdd.Restart();
                int sum = 0;

                for (int j = 0; j < numberOfItterations; j++)
                {
                    sum += j;
                }

                stopwatchIntAdd.Stop();
                Console.WriteLine(stopwatchIntAdd.Elapsed);
            }

            Stopwatch stopwatchIntSubstract = new Stopwatch();

            Console.WriteLine("\r\nSubstract, int, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchIntSubstract.Restart();
                int sum = int.MaxValue;

                for (int j = numberOfItterations; j >= 0; j--)
                {
                    sum -= j;
                }

                stopwatchIntSubstract.Stop();
                Console.WriteLine(stopwatchIntSubstract.Elapsed);
            }

            Stopwatch stopwatchIntIncrement = new Stopwatch();

            Console.WriteLine("\r\nIncrement, int, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchIntIncrement.Restart();
                int number = 1;

                for (int k = 0; k < numberOfItterations; k++)
                {
                    number++;
                }

                stopwatchIntIncrement.Stop();
                Console.WriteLine(stopwatchIntIncrement.Elapsed);
            }

            Stopwatch stopwatchIntMultiply = new Stopwatch();

            Console.WriteLine("\r\nMultiply, int, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchIntMultiply.Restart();
                int product = 1;

                for (int l = 1; l < numberOfItterations + 1; l++)
                {
                    product *= l;
                }

                stopwatchIntMultiply.Stop();
                Console.WriteLine(stopwatchIntMultiply.Elapsed);
            }

            Stopwatch stopwatchIntDivide = new Stopwatch();

            Console.WriteLine("\r\nDivide, int, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchIntDivide.Restart();
                int num = int.MaxValue;

                for (int m = numberOfItterations + 1; m > 0; m--)
                {
                    num /= m;
                }

                stopwatchIntDivide.Stop();
                Console.WriteLine(stopwatchIntDivide.Elapsed);
            }

            // LONG 
            Stopwatch stopwatchLongAdd = new Stopwatch();

            Console.WriteLine("\r\nAdd, Long, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchLongAdd.Restart();
                long sum = 0;

                for (int j = 0; j < numberOfItterations; j++)
                {
                    sum += j;
                }

                stopwatchLongAdd.Stop();
                Console.WriteLine(stopwatchLongAdd.Elapsed);
            }

            Stopwatch stopwatchLongSubstract = new Stopwatch();

            Console.WriteLine("\r\nAdd, Substract, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchLongSubstract.Restart();
                long sum = long.MaxValue;

                for (int j = numberOfItterations; j >= 0; j--)
                {
                    sum -= j;
                }

                stopwatchLongSubstract.Stop();
                Console.WriteLine(stopwatchLongSubstract.Elapsed);
            }

            Stopwatch stopwatchLongIncrement = new Stopwatch();

            Console.WriteLine("\r\nIncrement, Long, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchLongIncrement.Restart();
                long number = 1;

                for (int k = 0; k < numberOfItterations; k++)
                {
                    number++;
                }

                stopwatchLongIncrement.Stop();
                Console.WriteLine(stopwatchLongIncrement.Elapsed);
            }

            Stopwatch stopwatchLongMultiply = new Stopwatch();

            Console.WriteLine("\r\nMultiply, Long, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchLongMultiply.Restart();
                long product = 1;

                for (int l = 1; l < numberOfItterations + 1; l++)
                {
                    product *= l;
                }

                stopwatchLongMultiply.Stop();
                Console.WriteLine(stopwatchLongMultiply.Elapsed);
            }

            Stopwatch stopwatchLongDivide = new Stopwatch();

            Console.WriteLine("\r\nDivide, Long, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchLongDivide.Restart();
                long num = long.MaxValue;

                for (int m = numberOfItterations + 1; m > 0; m--)
                {
                    num /= m;
                }

                stopwatchLongDivide.Stop();
                Console.WriteLine(stopwatchLongDivide.Elapsed);
            }

            // FLOAT 
            Stopwatch stopwatchFloatAdd = new Stopwatch();

            Console.WriteLine("\r\nAdd, Float, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchFloatAdd.Restart();
                float sum = 0f;

                for (int j = 0; j < numberOfItterations; j++)
                {
                    sum += j;
                }

                stopwatchFloatAdd.Stop();
                Console.WriteLine(stopwatchFloatAdd.Elapsed);
            }

            Stopwatch stopwatchFloatSubstract = new Stopwatch();

            Console.WriteLine("\r\nSubstract, Float, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchFloatSubstract.Restart();
                float sum = float.MaxValue;

                for (int j = numberOfItterations; j >= 0; j--)
                {
                    sum -= j;
                }

                stopwatchFloatSubstract.Stop();
                Console.WriteLine(stopwatchFloatSubstract.Elapsed);
            }

            Stopwatch stopwatchFloatIncrement = new Stopwatch();

            Console.WriteLine("\r\nIncrement, Float, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchFloatIncrement.Restart();
                float number = 1;

                for (int k = 0; k < numberOfItterations; k++)
                {
                    number++;
                }

                stopwatchFloatIncrement.Stop();
                Console.WriteLine(stopwatchFloatIncrement.Elapsed);
            }

            Stopwatch stopwatchFloatMultiply = new Stopwatch();

            Console.WriteLine("\r\nMultiply, Float, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchFloatMultiply.Restart();
                float product = 1;

                for (int l = 1; l < numberOfItterations + 1; l++)
                {
                    product *= l;
                }

                stopwatchFloatMultiply.Stop();
                Console.WriteLine(stopwatchFloatMultiply.Elapsed);
            }

            Stopwatch stopwatchFloatDivide = new Stopwatch();

            Console.WriteLine("\r\nDivide, Float, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchFloatDivide.Restart();
                float num = float.MaxValue;

                for (int m = numberOfItterations + 1; m > 0; m--)
                {
                    num /= m;
                }

                stopwatchFloatDivide.Stop();
                Console.WriteLine(stopwatchFloatDivide.Elapsed);
            }

            // DOUBLE 
            Stopwatch stopwatchDoubleAdd = new Stopwatch();

            Console.WriteLine("\r\nAdd, Double, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchDoubleAdd.Restart();
                double sum = 0d;

                for (int j = 0; j < numberOfItterations; j++)
                {
                    sum += j;
                }

                stopwatchDoubleAdd.Stop();
                Console.WriteLine(stopwatchDoubleAdd.Elapsed);
            }

            Stopwatch stopwatchDoubleSubstract = new Stopwatch();

            Console.WriteLine("\r\nSubstract, Double, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchDoubleSubstract.Restart();
                double sum = double.MaxValue;

                for (int j = numberOfItterations; j >= 0; j--)
                {
                    sum -= j;
                }

                stopwatchDoubleSubstract.Stop();
                Console.WriteLine(stopwatchDoubleSubstract.Elapsed);
            }

            Stopwatch stopwatchDoubleIncrement = new Stopwatch();

            Console.WriteLine("\r\nIncrement, Double, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchDoubleIncrement.Restart();
                double number = 1;

                for (int k = 0; k < numberOfItterations; k++)
                {
                    number++;
                }

                stopwatchDoubleIncrement.Stop();
                Console.WriteLine(stopwatchDoubleIncrement.Elapsed);
            }

            Stopwatch stopwatchDoubleMultiply = new Stopwatch();

            Console.WriteLine("\r\nMultiply, Double, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchDoubleMultiply.Restart();
                double product = 1;

                for (int l = 1; l < numberOfItterations + 1; l++)
                {
                    product *= l;
                }

                stopwatchDoubleMultiply.Stop();
                Console.WriteLine(stopwatchDoubleMultiply.Elapsed);
            }

            Stopwatch stopwatchDoubleDivide = new Stopwatch();

            Console.WriteLine("\r\nDivide, Double, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchDoubleDivide.Restart();
                double num = double.MaxValue;

                for (int m = numberOfItterations + 1; m > 0; m--)
                {
                    num /= m;
                }

                stopwatchDoubleDivide.Stop();
                Console.WriteLine(stopwatchDoubleDivide.Elapsed);
            }

            // DECIMAL 
            Stopwatch stopwatchDecimalAdd = new Stopwatch();

            Console.WriteLine("\r\nAdd, Decimal, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchDecimalAdd.Restart();
                decimal sum = 0m;

                for (int j = 0; j < numberOfItterations; j++)
                {
                    sum += j;
                }

                stopwatchDecimalAdd.Stop();
                Console.WriteLine(stopwatchDecimalAdd.Elapsed);
            }

            Stopwatch stopwatchDecimalSubstract = new Stopwatch();

            Console.WriteLine("\r\nSubstract, Decimal, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchDecimalSubstract.Restart();
                decimal sum = decimal.MaxValue;

                for (int j = numberOfItterations; j >= 0; j--)
                {
                    sum -= j;
                }

                stopwatchDecimalSubstract.Stop();
                Console.WriteLine(stopwatchDecimalSubstract.Elapsed);
            }

            Stopwatch stopwatchDecimalIncrement = new Stopwatch();

            Console.WriteLine("\r\nIncrement, Decimal, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchDecimalIncrement.Restart();
                decimal number = 1;

                for (int k = 0; k < numberOfItterations; k++)
                {
                    number++;
                }

                stopwatchDecimalIncrement.Stop();
                Console.WriteLine(stopwatchDecimalIncrement.Elapsed);
            }

            Stopwatch stopwatchDecimalMultiply = new Stopwatch();

            Console.WriteLine("\r\nMultiply, Decimal, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchDecimalMultiply.Restart();
                BigInteger product = 1;

                for (int l = 1; l < numberOfItterations + 1; l++)
                {
                    product *= 2;
                }

                stopwatchDecimalMultiply.Stop();
                Console.WriteLine(stopwatchDecimalMultiply.Elapsed);
            }

            Stopwatch stopwatchDecimalDivide = new Stopwatch();

            Console.WriteLine("\r\nDivide, Decimal, {0} times:", numberOfItterations);

            for (int i = 0; i < 5; i++)
            {
                stopwatchDecimalDivide.Restart();
                decimal num = decimal.MaxValue;

                for (int m = numberOfItterations + 1; m > 0; m--)
                {
                    num /= 2;
                }

                stopwatchDecimalDivide.Stop();
                Console.WriteLine(stopwatchDecimalDivide.Elapsed);
            }
        }
    }
}