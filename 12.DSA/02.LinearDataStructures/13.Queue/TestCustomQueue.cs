/*Implement the ADT queue as dynamic linked list.

    Use generics (LinkedQueue<T>) to allow storing different data types in the queue.
*/

namespace _13.Queue
{
    using System;

    public class TestCustomQueue
    {
        public static void Main()
        {
            var testQueue = new MyQueue<string>();
            testQueue.Enqueue("One");
            testQueue.Enqueue("Two");
            testQueue.Enqueue("Four");
            Console.WriteLine(testQueue);
            Console.WriteLine("Removing: {0}", testQueue.Dequeue());
            ////Console.WriteLine("Removing: {0}", testQueue.Dequeue());
            Console.WriteLine(testQueue.Peek());

            Console.WriteLine(testQueue);
        }
    }
}
