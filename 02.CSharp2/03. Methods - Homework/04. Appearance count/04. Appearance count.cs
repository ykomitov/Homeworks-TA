//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;


namespace AppearanceCount
{
    public class AppearanceCount
    {
        static void Main()
        {
            int[] input = { 1, 2, 3, 4, 5, 3, 55, 3, 3, 32, 3, 2, 3, 5, 3, 3, 7, 4, -6, -4, -3 };
            int wantedNum = -6;
            ArrayPrint(input);
            Console.WriteLine("\r\nNumber {0} is repeated {1} times in the array.", wantedNum, CountRepetitions(input, wantedNum));
        }

        public static int CountRepetitions(int[] inputArray, int searchedNum)
        {
            int counter = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (searchedNum == inputArray[i])
                {
                    counter++;
                }
            }
            return counter;
        }

        public static void ArrayPrint(int[] input)
        {
            string printArray = string.Join(", ", input);
            Console.WriteLine(printArray);
        }
    }
}