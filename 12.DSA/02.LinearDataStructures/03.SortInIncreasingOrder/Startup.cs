/* Write a program that reads a sequence of integers(List<int>) ending with an empty line and sorts them in an increasing order.
*/

namespace _03.SortInIncreasingOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        public static void Main()
        {
            ////var inputNumbers = new List<int>();
            ////var continueLoop = true;

            ////while (continueLoop)
            ////{
            ////    Console.Write("Please input a positive number: ");
            ////    var input = Console.ReadLine();
            ////    int currentNumber;
            ////    continueLoop = int.TryParse(input, out currentNumber);

            ////    if (continueLoop)
            ////    {
            ////        inputNumbers.Add(currentNumber);
            ////    }
            ////}

            var inputNumbers = new List<int> { 1, -1, 2, 3, 0, -2, -3 };

            var result = SortAlgorithms.MergeSort(inputNumbers);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
