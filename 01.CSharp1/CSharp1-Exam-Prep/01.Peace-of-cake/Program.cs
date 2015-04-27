using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Peace_of_cake
{
    class Program
    {
        static void Main()
        {
            BigInteger a = int.Parse(Console.ReadLine());
            BigInteger b = int.Parse(Console.ReadLine());
            BigInteger c = int.Parse(Console.ReadLine());
            BigInteger d = int.Parse(Console.ReadLine());
            BigInteger commonDenom = b * d;
            BigInteger aNew = a * (commonDenom / b);
            BigInteger cNew = c * (commonDenom / d);
            BigInteger completeCakes = (aNew + cNew) / commonDenom;
            decimal completeCakesDouble = ((decimal)aNew + (decimal)cNew) / (decimal)commonDenom;

            if (completeCakes > 0)
            {
                Console.WriteLine(completeCakes);
            }
            else 
            {
                Console.WriteLine("{0:0.0000000000000000000000}", completeCakesDouble);
            }
            Console.WriteLine("{0}/{1}",(aNew+cNew), commonDenom);
        }
    }
}
