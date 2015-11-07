using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fibonacci
{
    class Program
    {
        static int[] memo = new int[200000];

        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }

        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            if (memo[n] != 0)
            {
                return memo[n];
            }

            int number = Fibonacci(n - 1) + Fibonacci(n - 2);
            number %= 1000000007;
            memo[n] = number;

            return number;
        }
    }
}
