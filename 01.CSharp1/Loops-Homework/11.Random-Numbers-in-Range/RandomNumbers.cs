using System;

/*	Write a program that enters `3` integers `n`, `min` and `max` (`min != max`) and prints `n` random numbers in the range `[min...max]`.

_Examples:_

| n                 | min | max     |         random numbers        |
|-------------------|-----|---------|-------------------------------|
| 5                 | 0   | 1       | 1 0 0 1 1                     |
| 10                | 10  | 15      | 12 14 12 15 10 12 14 13 13 11 |*/

class RandomNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        Random random = new Random();

        for (int i = 1; i <= n; i++)

        {
            Console.Write("{0} ", random.Next(min, max));
            if (i == n)
            {
                Console.WriteLine();
            }
        }
    }
}
