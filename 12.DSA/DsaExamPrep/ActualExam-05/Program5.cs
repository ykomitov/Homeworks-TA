namespace ActualExam_05
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program5
    {
        public static void Main()
        {
            //var n = int.Parse(Console.ReadLine());
            //var relations = Console.ReadLine();
            //int k = int.Parse(Console.ReadLine());

            var n = 9;
            var relations = "<<<<<<<<<";
            var k = 2;

            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var combinations = new List<string>();

            if (relations[0] == '>')
            {
                for (int i = 0; i < nums.Length - n + 1; i++)
                {
                    var currentComb = "";
                    var counter = 0;
                    for (int j = i; counter < n; j++)
                    {
                        currentComb += nums[j];
                        counter++;
                    }
                    combinations.Add(currentComb);
                }

                combinations.Sort();
            }
            else
            {
                //for (int i = nums.Length - 1; i > 0; i--)
                //{
                //    if (i - n - 1 < 0)
                //    {
                //        break;
                //    }

                //    var currentComb = "";
                //    var counter = n;
                //    for (int j = i; counter > 0; j--)
                //    {
                //        currentComb += nums[j];
                //        counter--;
                //    }
                //    combinations.Add(currentComb);
                //}

                //combinations.Sort();
            }


            Console.WriteLine(combinations[k - 1]);
        }
    }
}
