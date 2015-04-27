//Using delegates write a class Timer that can execute certain method at each t seconds.
namespace DelegateTest
{

    using System;
    using System.Threading;

    class Timer
    {
        // Delegate
        public delegate void MyDelegate();
        public static int counter = 1;

        // Properties
        public MyDelegate aDelegate { get; set; }
        public int TimeSpan { get; set; }

        // CONSTRUCTORS
        public Timer(int tSeconds, MyDelegate aMethod)
        {
            TimeSpan = tSeconds;
            this.aDelegate = aMethod;
        }

        // Method calling the delegate a set amount of times
        public void Execute(uint callCount)
        {
            //execution counter
            for (int i = 0; i < callCount; i++)
            {
                aDelegate(); // call the delegate
                Thread.Sleep(TimeSpan * 1000); // pause 1 second
            }
        }
    }
    class Test
    {
        private static void MathCalculation()
        {
            Console.WriteLine("1 + {0} = {1}", Timer.counter, 1 + Timer.counter);
            Timer.counter++;
        }

        private static void WritingOnTheConsole()
        {
            Console.WriteLine("I am another method called by the delegate!");
        }

        public static void Main()
        {
            var testTimer1 = new Timer(1, MathCalculation);
            testTimer1.Execute(3);

            var testTimer2 = new Timer(2, WritingOnTheConsole);
            testTimer2.Execute(1);
        }
    }
}