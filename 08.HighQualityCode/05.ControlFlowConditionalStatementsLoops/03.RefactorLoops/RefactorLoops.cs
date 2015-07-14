namespace _03.RefactorLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RefactorLoops
    {
        static void Main(string[] args)
        {
            //Refactor the following loop
            int i = 0;
            for (i = 0; i < 100; )
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        i = 666;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine(array[i]);
                    i++;
                }
            }
            // More code here
            if (i == 666)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
