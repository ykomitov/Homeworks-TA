using System;
using System.Numerics;

/*	In combinatorics, the Catalan numbers are calculated by the following formula:
![catalan-formula](https://cloud.githubusercontent.com/assets/3619393/5626137/d7ec8bc2-958f-11e4-9787-f6c386847c81.png)
*	Write a program to calculate the `nth` Catalan number by given `n` (1 <= n <= 100). 

_Examples:_

| n           | Catalan(n) |
|-------------|------------|
| 0           | 1          |
| 5           | 42         |
| 10          | 16796      |
| 15          | 9694845    |*/

class CalculateCatalan
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        BigInteger twoNfactorial = 1;
        BigInteger nPlusOneFactorial = 1;
        BigInteger nFactorial = 1;

        //calculate input for the catalan formula
        for (int i = 1; i <= 2 * n; i++)
        {
            twoNfactorial *= i;
        }

        for (int j = 1; j <= n + 1; j++)
        {
            nPlusOneFactorial *= j;
        }

        for (int k = 1; k <= n; k++)
        {
            nFactorial *= k;
        }

        //Calculate nth catalan number & print result on the console
        Console.WriteLine(twoNfactorial / (nPlusOneFactorial * nFactorial));
    }
}
