using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Task1
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

        //BigInteger biggerAb;
        //BigInteger biggest;
        //BigInteger meanSum = (a + b + c);
        //double mean = meanSum / 3d;

        //if (a > b)
        //{
        //    biggerAb = a;
        //}
        //else
        //{
        //    biggerAb = b;
        //}

        //if (c > biggerAb)
        //{
        //    biggest = c;
        //}
        //else
        //{
        //    biggest = biggerAb;
        //}

        Console.WriteLine(biggerAc);
        Console.WriteLine(smallerAc);
        Console.WriteLine("{0:F3}", mean);
    }
}
