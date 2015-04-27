/*Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
    *  sum
    *  product
    *  min & max
    *  average.*/

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> enumeration) where T : IConvertible, IComparable
        {
            dynamic sum = default(T);
            foreach (var item in enumeration)
            {
                sum += item;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> enumeration) where T : IConvertible, IComparable
        {
            dynamic product = 1;
            foreach (var item in enumeration)
            {
                product *= item;
            }
            return product;
        }
        public static T Min<T>(this IEnumerable<T> enumeration) where T : IConvertible, IComparable
        {
            dynamic min = enumeration.First();
            foreach (var item in enumeration)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> enumeration) where T : IConvertible, IComparable
        {
            dynamic max = enumeration.First();
            foreach (var item in enumeration)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T Average<T>(this IEnumerable<T> enumeration) where T : IConvertible, IComparable
        {
            int count = 0;
            dynamic sum = default(T);
            foreach (var item in enumeration)
            {
                sum += item;
                count++;
            }
            return sum/count;
        }
        
        static void Main()
        {
            var testArr1 = new int[5];
            for (int i = 0; i < testArr1.Length; i++)
            {
                testArr1[i] = 10;
            }
            var sumTest = testArr1.Sum();
            Console.WriteLine(sumTest);

            var testArr2 = new double[5];
            for (int i = 0; i < testArr2.Length; i++)
            {
                testArr2[i] = 10;
            }
            var productTest = testArr2.Product();
            Console.WriteLine(productTest);

            var testArr3 = new decimal[5];
            for (int i = 0; i < testArr3.Length; i++)
            {
                testArr3[i] = i;
            }
            testArr3[2] = -3.14M;
            testArr3[1] = 1000M;

            var minTest = testArr3.Min();
            var maxTest = testArr3.Max();
            var avrTest = testArr3.Average();
            Console.WriteLine(minTest);
            Console.WriteLine(maxTest);
            Console.WriteLine(avrTest);
        }
    }
}
