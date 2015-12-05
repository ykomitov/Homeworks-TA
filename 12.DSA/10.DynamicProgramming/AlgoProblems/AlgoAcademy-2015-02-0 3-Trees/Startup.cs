namespace AlgoAcademy_2015_02_0_3_Trees
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        ////public static Dictionary<string, long> answers;
        public static long[,,,,] memo;

        public static void Main()
        {
            ////answers = new Dictionary<string, long>();

            memo = new long[11, 11, 11, 11, 5];
            memo[0, 0, 0, 0, 0] = 1;
            memo[0, 0, 0, 0, 1] = 1;
            memo[0, 0, 0, 0, 2] = 1;
            memo[0, 0, 0, 0, 3] = 1;

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            ////int a, b, c, d;

            ////for (a = 0; a <= 9; a++)
            ////{
            ////    for (b = 0; b <= 9; b++)
            ////    {
            ////        for (c = 0; c <= 9; c++)
            ////        {
            ////            for (d = 0; d <= 9; d++)
            ////            {
            ////                answers.Add((a + " " + b + " " + c + " " + d), PlaceTrees(a, b, c, d, -1));
            ////            }
            ////        }
            ////    }
            ////}

            var result = PlaceTrees(a, b, c, d, 4); // Call the function with invalid tree type the first time

            //using (StreamWriter sw = new StreamWriter("test.txt"))
            //{
            //    foreach (var entry in answers)
            //    {
            //        sw.WriteLine("[{0} {1}]", entry.Key, entry.Value);
            //    }
            //}

            Console.WriteLine(result);
        }

        public static long PlaceTrees(int a, int b, int c, int d, int lastType)
        {
            // Bottom - base case with no trees - only one way to put them (in most dynamic programming tasks usually the base case is 1, although it seem it is 0
            if (a + b + c + d == 0)
            {
                return 1;
            }

            if (memo[a, b, c, d, lastType] > 0)
            {
                return memo[a, b, c, d, lastType];
            }

            long count = 0;

            if (a > 0 && lastType != 0)
            {
                count += PlaceTrees(a - 1, b, c, d, 0);
            }


            if (b > 0 && lastType != 1)
            {
                count += PlaceTrees(a, b - 1, c, d, 1);
            }


            if (c > 0 && lastType != 2)
            {
                count += PlaceTrees(a, b, c - 1, d, 2);
            }


            if (d > 0 && lastType != 3)
            {
                count += PlaceTrees(a, b, c, d - 1, 3);
            }

            memo[a, b, c, d, lastType] = count;
            return count;
        }
    }
}
