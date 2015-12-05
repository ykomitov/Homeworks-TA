namespace DsaExam_Sorting
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void MockInput()
        {
            string input1 = @"3
1 2 3
3";
            string input2 = @"3
3 2 1
3";
            string input3 = @"5
5 4 3 2 1
2";
            string input4 = @"5
3 2 4 1 5
4";
            string input5 = @"8
7 2 1 6 8 4 3 5
4";
            Console.SetIn(new StringReader(input3));
        }

        public static void Main()
        {
            //MockInput();

            var n = int.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = int.Parse(Console.ReadLine());

            bool isSorted = IsSorted(list);

            if (list.Length == 1 || isSorted)
            {
                Console.WriteLine(0);
            }
            else if (list.Length == k)
            {
                Array.Reverse(list);

                isSorted = IsSorted(list);

                if (isSorted)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
            else
            {
                var result = Solve(list, k);

                Console.WriteLine(result);
            }
        }

        private static int Solve(int[] nums, int k)
        {
            // key => permutation hashcode
            // val => min path to key
            var visited = new Dictionary<int, int>();

            var queue = new Queue<int[]>();
            queue.Enqueue(nums);
            visited.Add(GetHashCode(nums), 0);

            while (queue.Count > 0)
            {
                var currPerm = queue.Dequeue();
                var currPath = visited[GetHashCode(currPerm)];

                if (IsSorted(currPerm))
                {
                    return currPath;
                }

                for (int i = 0; i <= nums.Length - k; i++)
                {
                    var desc = currPerm.Clone() as int[];
                    
                    Array.Reverse(desc, i, k);

                    if (!visited.ContainsKey(GetHashCode(desc)))
                    {
                        visited.Add(GetHashCode(desc), currPath + 1);
                        queue.Enqueue(desc);
                    }                   
                }
            }

            return -1;
        }

        private static bool IsSorted(int[] perm)
        {
            for (int i = 1; i < perm.Length; i++)
            {
                if (perm[i] < perm[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static int GetHashCode(int[] values)
        {
            int hash = 0;
            foreach (var val in values)
            {
                hash *= 8;
                hash += val;
            }

            return hash;
        }
    }
}
