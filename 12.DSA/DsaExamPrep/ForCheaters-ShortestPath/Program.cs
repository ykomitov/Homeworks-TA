namespace ForCheaters_ShortestPath
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static List<string> combinations;
        const int n = 3;
        static int k;
        static char[] objects = new char[n]
        {
        'R', 'L', 'S'
        };
        static int[] arr;
        static string input;
        static char [] inputAsArr;

        public static void Main()
        {
            combinations = new List<string>();

            input = Console.ReadLine();

            inputAsArr = input.ToCharArray();

            k = 0;

            for (int i = 0; i < inputAsArr.Length; i++)
            {
                if (inputAsArr[i] == '*')
                {
                    k++;
                }
            }

            arr = new int[k];

            Console.WriteLine(Math.Pow(3.0, k));

            GenerateVariationsWithRepetitions(0);

            var output = combinations.ToArray();

                Array.Sort(output);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        static void GenerateVariationsWithRepetitions(int index)
        {
            if (index >= k)
            {
                var str = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    str += objects[arr[i]];

                    for (int j = 0; j < inputAsArr.Length; j++)
                    {
                        if (inputAsArr[j] == '*')
                        {
                            inputAsArr[j] = objects[arr[i]];
                            break;
                        }
                    }
                }

                combinations.Add(new string(inputAsArr));
                inputAsArr = input.ToCharArray();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    arr[index] = i;
                    GenerateVariationsWithRepetitions(index + 1);
                }
            }
        }
    }
}
