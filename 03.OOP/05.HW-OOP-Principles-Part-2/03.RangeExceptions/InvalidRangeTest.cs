/*Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].*/

namespace RangeExceptions
{
    using System;
    using System.Linq;

    class InvalidRangeTest
    {
        static void Main()
        {
            try
            {
                for (int i = 99; i < 10000; i++)
                {
                    CheckInt(i);
                    Console.WriteLine("Int {0} - OK", i);
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                CheckDate(DateTime.Now);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void CheckInt(int input)
        {
            if (input <1 || input >100)
            {
                throw new InvalidRangeException<int>(1, 100, "Number should be in the range [1..100]!");
            }
        }

        static void CheckDate(DateTime input)
        {
            if (input < new DateTime(1980, 1, 1) || input > new DateTime(2013, 12, 31))
            {
                throw new InvalidRangeException<int>(1, 100, "DateTime should be in the range [1.1.1980 … 31.12.2013]!");
            }
        }
    }
}
