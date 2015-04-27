using System;

/*	Write a program that calculates `n! / k!` for given `n` and `k` (1 < k < n < 100).
*	Use only one loop.

_Examples:_

| n           | k          | n! / k! |
|-------------|------------|---------|
| 5           | 2          | 60      |
| 6           | 5          | 6       |
| 8           | 3          | 6720    |*/

class FactorialDivision
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        decimal factorialN = 1.00M;
        decimal factorialK = 1.00M;

        for (int i = 1, j = k; i <= n; i++, j--)
        {
            factorialN *= i;
            if (j > 0)
            {
                factorialK *= j;
            }
        }
        Console.WriteLine(factorialN / factorialK);
    }
}
