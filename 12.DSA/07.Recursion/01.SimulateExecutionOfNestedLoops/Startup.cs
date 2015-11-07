// Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.
namespace _01.SimulateExecutionOfNestedLoops
{
    using System;

    public class Startup
    {
        private static int loopsCounter = 1;

        public static void Main()
        {
            var n = 15;
            Console.WriteLine("Number of nested loops: {0}", n);
            NestedLoopsWithRecursion(n, n);
        }

        private static void NestedLoopsWithRecursion(int numberOfNestedLoops, int loopUntil)
        {
            if (numberOfNestedLoops == 0)
            {
                return;
            }

            Console.Write("Loop {0}: ", loopsCounter);

            for (int i = 0; i < loopUntil; i++)
            {
                if (i == loopUntil - 1)
                {
                    Console.WriteLine("{0}", i + 1);
                }
                else
                {
                    Console.Write("{0}, ", i + 1);
                }
            }

            numberOfNestedLoops--;
            loopsCounter++;
            NestedLoopsWithRecursion(numberOfNestedLoops, loopUntil);
        }
    }
}
