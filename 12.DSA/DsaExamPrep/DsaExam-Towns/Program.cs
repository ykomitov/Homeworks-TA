namespace DsaExam_Towns
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            //MockInput();

            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var citizens = int.Parse(line[0]);
                arr[i] = citizens;
            }

            var longestAscending = CalculateSubsequences(arr);

            Array.Reverse(arr);

            var longestDescending = CalculateSubsequences(arr);
            Array.Reverse(longestDescending);

            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int tempMax = longestAscending[i] + longestDescending[i];
                if (tempMax > max)
                {
                    max = tempMax;
                }
            }

            Console.WriteLine(max - 1);
        }

        public static int[] CalculateSubsequences(int[] inputArr)
        {
            var outputArr = new int[inputArr.Length];
            outputArr[0] = 1;

            for (int i = 1; i < inputArr.Length; i++)
            {
                int tempMax = 1;
                for (int j = 0; j < i; j++)
                {
                    var temp = 1;
                    if (inputArr[i] > inputArr[j])
                    {
                        temp = outputArr[j] + 1;
                        if (temp > tempMax)
                        {
                            tempMax = temp;
                        }
                    }
                }

                outputArr[i] = tempMax;
            }

            return outputArr;
        }

        public static void MockInput()
        {
            string input1 = @"8
108214 Pleven
339077 Plovdiv
200612 Burgas
334688 Varna
1241396 Sofia
92162 Sliven
151951 Ruse
137907 StaraZagora";

            Console.SetIn(new StringReader(input1));
        }
    }
}
