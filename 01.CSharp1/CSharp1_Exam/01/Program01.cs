using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Program01
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        long biggerAb = Math.Max(a, b);
        long biggerAc = Math.Max(biggerAb, c);

        long smallerAb = Math.Min(a, b);
        long smallerAc = Math.Min(smallerAb, c);

        decimal mean = (a + b + c) / 3M;


        Console.WriteLine(biggerAc);
        Console.WriteLine(smallerAc);
        Console.WriteLine("{0:F3}", mean);
    }
}
