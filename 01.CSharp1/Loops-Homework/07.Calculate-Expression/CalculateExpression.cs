using System;
using System.Numerics;

/*	In combinatorics, the number of ways to choose `k` different members out of a group of `n` different elements (also known as the number of combinations) is calculated by the following formula:
![formula](https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png)
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
*	Your task is to write a program that calculates `n! / (k! * (n-k)!)` for given `n` and `k` (1 < k < n < 100). Try to use only two loops.

_Examples:_

| n           | k | n! / (k! * (n-k)!) |
|-------------|---|--------------------|
| 3           | 2 | 3                  |
| 4           | 2 | 6                  |
| 10          | 6 | 210                |
| 52          | 5 | 2598960            |*/

class CalculateExpression
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNminK = 1;

        //The task can be achieved with one loop only ;)

        for (int i = 1, j = k, l = 1; i <= n; i++, j--, l++)
        {
            factorialN *= i;
            if (j > 0)
            {
                factorialK *= j;
            }
            if (l <= (n - k))
            {
                factorialNminK *= l;
            }
        }
        Console.WriteLine(factorialN / (factorialK * factorialNminK));
    }
}
