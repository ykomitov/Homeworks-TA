/*Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/

namespace DivisibleBy7_3
{
    using System;
    using System.Linq;

    class DivisableBy7_3
    {
        static void Main()
        {
            int[] intArr = new int[100];
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = i + 1;
            }

            //with lambda expressions
            var lambdaSelect = intArr
                .Where(x => ((x % 7) == 0) && ((x % 3) == 0))
                .ToArray();

            //with linq query
            var linqSelect = (from num in intArr
                             where (num % 3 == 0) && (num % 7 ==0)
                             select num)
                             .ToArray();

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(",", intArr));
            Console.WriteLine("\r\nSelected numbers:");
            Console.WriteLine(string.Join(",", lambdaSelect));
            Console.WriteLine(string.Join(",", linqSelect));
        }
    }
}
