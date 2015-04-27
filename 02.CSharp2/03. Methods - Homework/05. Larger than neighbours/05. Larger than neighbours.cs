//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using AppearanceCount;

namespace LargerThanNeighbours
{
    public class LargerThanNeighbours
    {
        static void Main()
        {
            int[] input = { 1, 2, 3, 4, 5, 3, 55, 3, 3, 32, 3, 2, 3, 5, 3, 3, 7, 4, -6, -4, -3 };

            ////Some other arrays for testing:
            //int[] input = { 536, 921, 906, 115, 680, 292, 509, 742, 220, 761, 437, 368, 211, 372, 546, 549, 318, 798, 687, 783, 405, 407, 723, 871, 676, 521, 273, 275, 704, 568, 502, 728, 598, 446, 384, 954, 663, 431, 489, 733, 405, 298, 38, 84, 882, 787 };
            //int[] input = { 138, 8, 682, 233, 646, 570, 60, 841, 871, 416, 49, 730, 989, 139, 405, 297, 861, 407, 95 };

            //Print the input array using the method from AppearanceCount (Problem 4)
            AppearanceCount.AppearanceCount.ArrayPrint(input);

            int checkedIndex = 0;

            while (true)
            {
                Console.Write("\r\nEnter a valid position between [0; {0}] in the array to be checked: ", (input.Length - 1));
                checkedIndex = int.Parse(Console.ReadLine());

                //Run the CheckNeighbours method if input is valid
                if (checkedIndex >= 0 && checkedIndex <= input.Length - 1)
                {
                    CheckNeighbours(input, checkedIndex);
                }
                else
                {
                    Console.WriteLine("Invalid index. Please try again!");
                }
            }
        }

        public static bool CheckNeighbours(int[] input, int index)
        {
            bool isLarger = false;
            if (index - 1 < 0)
            {
                if (input[index] > input[1])
                {
                    Console.WriteLine("The element {0} is the first in the array and it is larger than the next element {1}.", input[index], input[index + 1]);
                    return isLarger;
                }
                else
                {
                    Console.WriteLine("The element {0} is the first in the array and it is NOT larger than the next element {1}.", input[index], input[index + 1]);
                    return isLarger;
                }
            }
            if (index + 1 > input.Length - 1)
            {
                if (input[index] > input[input.Length - 2])
                {
                    Console.WriteLine("The element {0} is the last in the array and it is larger than the previous element.", input[index]);
                    return isLarger;
                }
                else
                {
                    Console.WriteLine("The element {0} is the last in the array and it is NOT larger than the previous element.", input[index]);
                    return isLarger;
                }
            }
            if (input[index] > input[index + 1] && input[index] > input[index - 1])
            {
                isLarger = true;
                Console.WriteLine("The element {0} is larger than its two neighbours[{1}; {2}]", input[index], input[index - 1], input[index + 1]);
                return isLarger;
            }
            else
            {
                Console.WriteLine("The element {0} is NOT larger than its two neighbours [{1}; {2}]", input[index], input[index - 1], input[index + 1]);
                return isLarger;
            }
        }
    }

}