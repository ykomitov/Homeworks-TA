using System;

/*	Write a program that enters from the console a positive integer `n` and prints all the numbers from `1` to `n` not divisible by `3` and `7`, on a single line, separated by a space.

_Examples:_

| n  | output       |
|----|--------------|
| 3  | 1 2          |
| 10 | 1 2 4 5 8 10 |*/

class ChecDivisibility
{
    static void Main()
    {
        Console.Write("Please enter a positive integer n: ");
        uint n = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                continue;
            }
                Console.Write("{0} ", i);
        }
        Console.WriteLine("\r\n");
    }
}
