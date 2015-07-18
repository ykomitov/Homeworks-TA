namespace _002
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Problem2
    {
        internal static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            var arrayOfSequences = new string[t];

            for (int i = 0; i < t; i++)
            {
                arrayOfSequences[i] = Console.ReadLine();
            }

            foreach (var sequence in arrayOfSequences)
            {
                var currentSequence = sequence.Split(' ').Select(long.Parse).ToList();
                var sequenceOfAbsDiff = new List<long>();

                for (int i = 0; i < currentSequence.Count - 1; i++)
                {
                    sequenceOfAbsDiff.Add(AbsDiff(currentSequence[i], currentSequence[i + 1]));
                }

                bool isIncreasing = IsIncreasingSequence(sequenceOfAbsDiff);

                Console.WriteLine(isIncreasing);
            }
        }

        internal static long AbsDiff(long a, long b)
        {
            long largerAB = Math.Max(a, b);
            long smallerAB = Math.Min(a, b);
            long absDiff = largerAB - smallerAB;

            return absDiff;
        }

        internal static bool IsIncreasingSequence(List<long> inputList)
        {
            bool isIncreasing = true;

            for (int j = 1; j < inputList.Count; j++)
            {
                if (!(AbsDiff(inputList[j - 1], inputList[j]) == 1 || AbsDiff(inputList[j - 1], inputList[j]) == 0))
                {
                    isIncreasing = false;
                    break;
                }

                if (inputList[j] < inputList[j - 1])
                {
                    isIncreasing = false;
                    break;
                }
            }

            return isIncreasing;
        }
    }
}