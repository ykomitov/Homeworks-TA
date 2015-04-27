/* Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start… end].
    o	If an invalid number or non-number text is entered, the method should throw an exception.
  •	Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 
 * 1 < a1 < … < a10 < 100*/

using System;

class EnterNumbers
{
    static void Main()
    {
        Console.Write("Please enter a starting integer number [start... end]: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Please enter the final integer number [start... end]: ");
        int final = int.Parse(Console.ReadLine());

        int[] nums = new int[9];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Please enter number a{0}/10 such as 1 < a1 < ... < a10 < 100: ", i + 1);
            nums[i] = ReadNumber(start, final);
            if (i > 0)
            {
                if (nums[i - 1] >= nums[i])
                {
                    Exception e = new Exception("The integer should be bigger than previous integers!");
                    throw e;
                }
            }
        }
    }
    static int ReadNumber(int start, int final)
    {
        try
        {
            int newNum = int.Parse(Console.ReadLine());
            if (newNum <= start || newNum >= final)
            {
                throw new System.ArgumentOutOfRangeException("Number not in the given range [start < NUMBER < end]!");
            }
            return newNum;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid integer number!");
            return 0;
        }
    }
}
