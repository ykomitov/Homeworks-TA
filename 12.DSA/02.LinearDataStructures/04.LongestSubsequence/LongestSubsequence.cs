/*Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.

    Write a program to test whether the method works correctly.
*/

namespace _04.LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    public class LongestSubsequence
    {
        public static void Main()
        {
            ////var inputList = new List<int> { 1, 1, 1, 2, 2, 2, 0, 0, 0, 0 };
            var inputList = new List<double> { 1, -11, -1, 2, -0.01, 3, -0.01 };

            var longestSubsequenceOfEqualNumbers = FindLongestSubsequence(inputList);

            Console.WriteLine(string.Join(", ", longestSubsequenceOfEqualNumbers));
        }

        // The method uses generics, so it can work with all value types
        public static List<T> FindLongestSubsequence<T>(List<T> inputList)
        {
            int lengthOfLongestSubsequence = 0;
            T repeatedElement = default(T);

            var tempCounter = 0;
            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i].Equals(inputList[i + 1]))
                {
                    tempCounter++;
                }
                else
                {
                    tempCounter = 0;
                }

                if (tempCounter > lengthOfLongestSubsequence)
                {
                    lengthOfLongestSubsequence = tempCounter;
                    repeatedElement = inputList[i];
                }
            }

            var result = new List<T>();
            if (lengthOfLongestSubsequence == 0)
            {
                Console.WriteLine("No repeating numbers in the input list were found!");
            }
            else
            {
                for (int i = 0; i <= lengthOfLongestSubsequence; i++)
                {
                    result.Add(repeatedElement);
                }
            }

            return result;
        }
    }
}
