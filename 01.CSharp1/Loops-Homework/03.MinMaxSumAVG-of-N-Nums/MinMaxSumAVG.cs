using System;

/*	Write a program that reads from the console a sequence of `n` integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
*	The input starts by the number `n` (alone in a line) followed by `n` lines, each holding an integer number.
*	The output is like in the examples below.

_Example 1:_

| input | output     |
|-------|------------|
| 3     | min = 1    |
| 2     | max = 5    |
| 5     | sum = 8    |
| 1     | avg = 2.67 |

_Example 2:_

| input | output     |
|-------|------------|
| 2     | min = -1   |
| -1    | max = 4    |
| 4     | sum = 3    |
|       | avg = 1.50 |*/

class MinMaxSumAVG
{
    static void Main()
    {
        //read n from console
        Console.Write("Please enter a positive integer n: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("Please enter " + n + " more numbers");

        //declare all needed variables
        int sum = 0;
        double avg = 0D;
        int min = 0;
        int max = 0;

        //run a loop to get n more numbers from the console
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Please enter an integer: ");
            int input = int.Parse(Console.ReadLine());

            //calculate sum and average on each iteration
            sum = sum + input;
            avg = ((double)sum / n);

            //check if newly entered value is different than 0 and assign in to min
            if (min == 0 && max == 0)
            {
                min = input;
                max = input;
            }
            //after that check if each next value is lower than min - change min; if higher than max = change max.
            else
            {
                if (input <= min)
                {
                    min = input;
                }
                if (input >= max)
                {
                    max = input;
                }
            }
        }
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", avg);
    }
}