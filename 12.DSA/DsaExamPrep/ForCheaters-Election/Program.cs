namespace ForCheaters_Election
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long[] seats = new long[n];

            for (int i = 0; i < n; i++)
            {
                seats[i] = long.Parse(Console.ReadLine());
            }


            BigInteger[] sums = new BigInteger[seats.Sum() + 1];
            sums[0] = 1;

            for (int i = 0; i < n; i++)
            {
                long currentNumber = seats[i];

                for (int j = sums.Length - 1; j >= 0; j--)
                {
                    if (sums[j] != 0)
                    {
                        sums[j + currentNumber] += sums[j];
                    }
                }
            }

            BigInteger answer = 0;
            for (int i = k; i < sums.Length; i++)
            {
                if (sums[i] > 0)
                {
                    answer += sums[i];
                }
            }

            Console.WriteLine(answer);
        }
    }
}

//public static IEnumerable<T[]> Subsets<T>(T[] source)
//{
//    int max = 1 << source.Length;
//    for (int i = 0; i < max; i++)
//    {
//        T[] combination = new T[source.Length];

//        for (int j = 0; j < source.Length; j++)
//        {
//            int tailIndex = source.Length - j - 1;
//            combination[tailIndex] =
//                ((i & (1 << j)) != 0) ? source[tailIndex] : default(T);
//        }

//yield return combination;
//    }
//}

//public static IEnumerable<IEnumerable<int>> Subsets(IEnumerable<int> source)
//{
//    List<int> list = source.ToList();
//    int length = list.Count;
//    int max = (int)Math.Pow(2, list.Count);

//    for (int count = 0; count < max; count++)
//    {
//        List<int> subset = new List<int>();
//        uint rs = 0;
//        while (rs < length)
//        {
//            if ((count & (1u << (int)rs)) > 0)
//            {
//                subset.Add(list[(int)rs]);
//            }
//            rs++;
//        }
//        yield return subset;
//    }
//}

//public static IEnumerable<int[]> Permute(int[] data)
//{
//    return Permute(data, 0);
//}

//public static IEnumerable<int[]> Permute(int[] data, int level)
//{
//    // reached the edge yet? backtrack one step if so.
//    if (level >= data.Length) yield break;

//    // yield the first #level elements
//    yield return data.Take(level + 1).ToArray();

//    // permute the remaining elements
//    for (int i = level + 1; i < data.Length; i++)
//    {
//        var temp = data[level];
//        data[level] = data[i];
//        data[i] = temp;

//        foreach (var item in Permute(data, level + 1))
//        {
//            yield return item;
//        }

//        temp = data[i];
//        data[i] = data[level];
//        data[level] = temp;
//    }

//}
