using System;


    class PrintSequence
    {
        static void Main(string[] args)
        {
            {
                int a = 2;
                int b = -3;

                for (int i = 0; i < 500; i++)
                {
                    Console.Write(a + " " + b + " ");
                    a = a + 2;
                    b = b - 2;
                }
            }
        }
    }

