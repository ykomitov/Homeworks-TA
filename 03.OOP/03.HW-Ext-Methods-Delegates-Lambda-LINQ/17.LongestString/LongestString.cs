/*Problem 17. Longest string

    Write a program to return the string with maximum length from an array of strings.
    Use LINQ.*/

namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class LongestString
    {
        static void Main()
        {
            string[] testArr = new string[] { "1", "gold", "1228", "123" };

            var longestString = from item in testArr
                                where item.Length == testArr.Max(x => x.Length)
                                select item;
            string testArrString = String.Join(" ", testArr);
            Console.WriteLine("Original array: {0}\r\n", testArrString);
            var sb = new StringBuilder();
            foreach (var item in longestString)
            {
                sb.Append(item);
                sb.Append(" ");
            }
            Console.WriteLine("Longest string(s): {0}\r\n", sb.ToString());
        }
    }
}
