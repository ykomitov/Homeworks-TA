/* Implement a class PriorityQueue<T> based on the data structure "binary heap".
*/
namespace _01.PriorityQueue
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            ////var maxPriorityQueue = new Heap<int>(HeapType.MaxHeap);

            ////var random = new Random();

            ////for (int i = 0; i < 10; i++)
            ////{
            ////    int numberToBeAdded = random.Next(0, 100);
            ////    Console.WriteLine("Adding {0} to priority queue...\r\n", numberToBeAdded);
            ////    maxPriorityQueue.Add(numberToBeAdded);
            ////    Console.WriteLine(maxPriorityQueue);
            ////}

            var minPriorityQueue = new Heap<int>(HeapType.MinHeap);

            var random = new Random();

            for (int i = 0; i < 7; i++)
            {
                int numberToBeAdded = random.Next(0, 100);
                Console.WriteLine("Adding {0} to priority queue...", numberToBeAdded);
                minPriorityQueue.Add(numberToBeAdded);

                if (i > 4)
                {
                    Console.WriteLine("Removing {0} from priority queue...", minPriorityQueue.Root);
                    minPriorityQueue.Remove();
                }

                Console.WriteLine(minPriorityQueue);
            }
        }
    }
}
