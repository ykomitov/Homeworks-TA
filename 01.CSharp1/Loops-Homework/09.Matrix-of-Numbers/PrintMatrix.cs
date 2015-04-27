using System;

/*	Write a program that reads from the console a positive integer number `n` (1 <= n <= 20) and prints a matrix like in the examples below. Use two nested loops.

_Examples:_

	n = 2	matrix		n = 3	matrix		n = 4	matrix
			1 2					1 2 3				1 2 3 4
			2 3					2 3 4				2 3 4 5
								3 4 5				3 4 5 6
													4 5 6 7*/

class PrintMatrix
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < i + n; j++)
            {
                //padleft with 2 for the martix to be printed correctly when n >= 10
                Console.Write("{0} ", Convert.ToString(j).PadLeft(2));
            }
            Console.WriteLine("");
        }
    }
}