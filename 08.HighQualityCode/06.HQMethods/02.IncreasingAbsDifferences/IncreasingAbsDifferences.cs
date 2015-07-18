using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class Problem2
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            var list = new string[t];

            for (int i = 0; i < t; i++)
            {
                list[i] = Console.ReadLine();
            }

            foreach (var seq in list)
            {
                var sequence = seq.Split(' ').Select(Int64.Parse).ToList();
                var sequenceOfAbsDiff = new List<long>();
                var sequenceOfAbsDiff2 = new List<long>();

                bool isIncreasing = true;

                for (int i = 0; i < sequence.Count - 1; i++)
                {
                    sequenceOfAbsDiff.Add(AbsDiff(sequence[i], sequence[i + 1]));
                }

                for (int j = 0; j < sequenceOfAbsDiff.Count - 1; j++)
                {
                    if (j == 0)
                    {
                        if (AbsDiff(sequenceOfAbsDiff[j], sequenceOfAbsDiff[j + 1]) == 1 || AbsDiff(sequenceOfAbsDiff[j], sequenceOfAbsDiff[j + 1]) == 0)
                        {
                            //continue;
                        }
                        else
                        {
                            isIncreasing = false;
                            break;
                        }
                    }
                    //else
                    //{
                    //    bool test2 = sequenceOfAbsDiff[j] >= sequenceOfAbsDiff[j - 1];


                    //    if (test2)
                    //    {
                    //        //continue;
                    //    }
                    //    else
                    //    {
                    //        isIncreasing = false;
                    //        break;
                    //    }
                    //}
                }

                for (int i = 1; i < sequence.Count - 1; i++)
                {
                    if (sequenceOfAbsDiff[i] >= sequenceOfAbsDiff[i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        isIncreasing = false;
                        break;
                    }
                }

                for (int i = 0; i < sequenceOfAbsDiff.Count - 2; i++)
                {
                    bool test = AbsDiff(AbsDiff(sequenceOfAbsDiff[i], sequenceOfAbsDiff[i + 1]), AbsDiff(sequenceOfAbsDiff[i + 1], sequenceOfAbsDiff[i + 2])) <= 1;

                    if (test)
                    {
                        //continue;
                    }
                    else
                    {
                        isIncreasing = false;
                        break;
                    }
                }
                Console.WriteLine(isIncreasing);
            }
        }

        static long AbsDiff(long a, long b)
        {
            long largerAB = Math.Max(a, b);
            long smallerAB = Math.Min(a, b);
            long abbsDiff = largerAB - smallerAB;
            return abbsDiff;
        }
    }
}