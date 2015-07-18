using System;

public class Abc
{
    public static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        long maxAbc = Math.Max(Math.Max(a, b), c);
        long minAbc = Math.Min(Math.Min(a, b), c);
        decimal mean = (a + b + c) / 3M;

        Console.WriteLine(maxAbc);
        Console.WriteLine(minAbc);
        Console.WriteLine("{0:F3}", mean);
    }
}
