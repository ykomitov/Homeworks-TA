using System;

/*	Write a program that, for a given two integer numbers `n` and `x`, calculates the sum `S = 1 + 1!/x + 2!/x^2 + ... + n!/x^n`.
*	Use only one loop. Print the result with `5` digits after the decimal point.

_Examples:_

| n           | x          | S       |
|-------------|------------|---------|
| 3           | 2          | 2.75000 |
| 4           | 3          | 2.07407 |
| 5           | -4         | 0.75781 |*/

class CalculateFactorialExpression
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        decimal numerator = 1.00M;
        decimal denominator = 1.00M;
        decimal sum = 1.00M;

        for (int i = 1; i <= n; i++)
        {
            numerator *= i;
            denominator *= x;
            sum += numerator / denominator;
        }
        Console.WriteLine("{0:0.00000}", sum);
    }

}
