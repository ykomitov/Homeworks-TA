namespace _01.Staircases
{
    using System;

    public class Startup
    {
        static long[,] count;
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            count = new long[n + 1, n + 1];

            count[0, 0] = 1;
            count[1, 1] = 1;
            count[2, 2] = 1;

            for (int i = 3; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    for (int k = 0; k < j && i - j >= k; k++)
                    {
                        count[i, j] += count[i - j, k];
                    }
                }
            }

            long answer = 0;
            for (int i = 1; i < n; i++)
            {
                answer += count[n, i];
            }

            Console.WriteLine(answer);
        }
    }
}


//namespace _01.Staircases //34, can use long instead of int
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text;
//    using System.Threading.Tasks;

//    public class Startup
//    {
//        static int[,] count;
//        public static void Main()
//        {
//            int n = int.Parse(Console.ReadLine());
//            count = new int[n + 1, n + 1];

//            int answer = 0;
//            for (int i = 1; i < n; i++)
//            {
//                answer += Stairs(n, i);
//            }

//            Console.WriteLine(answer);
//        }

//        static int Stairs(int n, int k)
//        {
//            if (n < 3 && n == k)
//            {
//                return 1;
//            }

//            if (count[n, k] > 0)
//            {
//                return count[n, k];
//            }

//            for (int i = 0; i < k; i++)
//            {
//                if (n - k < i)
//                {
//                    break;
//                }

//                count[n, k] += Stairs(n - k, i);
//            }

//            return count[n, k];
//        }
//    }
//}
