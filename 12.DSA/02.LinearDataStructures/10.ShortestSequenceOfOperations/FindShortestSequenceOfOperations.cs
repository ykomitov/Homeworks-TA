/*We are given numbers N and M and the following operations:

    N = N+1
    N = N+2

    N = N*2

    Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
    Hint: use a queue.
    Example: N = 5, M = 16
    Sequence: 5 → 7 → 8 → 16
*/

namespace _10.ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindShortestSequenceOfOperations
    {
        public static void Main()
        {
            var n = -11;
            var m = 7;

            var result = ShortestSequenceOfOperations(n, m);

            Console.WriteLine(string.Join(", ", result));
        }

        public static IEnumerable<int> ShortestSequenceOfOperations(int start, int end)
        {
            var queue = new Queue<int>();
            var negativeQueue = new Queue<int>();
            bool endAddedToPositiveQueue = false;
            bool startAddedToNegativeQueue = false;

            while (start != end)
            {
                // If the starting number is negative, then increase the starting number until it is >= 0 or equal to the end
                while (start < 0 && start != end)
                {
                    // The "negative" sequence is stored in a separate queue
                    if (!startAddedToNegativeQueue)
                    {
                        negativeQueue.Enqueue(start);
                        startAddedToNegativeQueue = true;
                    }

                    if (start + 2 <= end)
                    {
                        negativeQueue.Enqueue(start + 2);
                        start = start + 2;
                    }
                    else
                    {
                        negativeQueue.Enqueue(start + 1);
                        start = start + 1;
                    }
                }

                if (start == end)
                {
                    break;
                }

                // When the starting number has become positive, add it to the "positive" queue. The isAdded flag ensures this is done only once. 
                if (start >= 0 && !endAddedToPositiveQueue)
                {
                    queue.Enqueue(end);
                    endAddedToPositiveQueue = true;
                }

                // Special case - if the distance between start and end is exactly 4, then substract 2. Useful when we end up at 5 and we are targeting 1. Otherwise the original algorithm will first deduce 1, then divide by 2, then once again deduce 1, which is inefficient.
                if (end - 4 == start)
                {
                    queue.Enqueue(end - 2);
                    end = end - 2;
                }

                if (end - 2 == start)
                {
                    queue.Enqueue(end - 2);
                    end = end - 2;
                    break;
                }

                if (end > 0 && start < end)
                {
                    if (end % 2 == 0 && end / 2 >= start)
                    {
                        queue.Enqueue(end / 2);
                        end = end / 2;
                    }
                    else if (end % 2 == 0 && end / 2 < start)
                    {
                            queue.Enqueue(end - 1);
                            end = end - 1;
                    }
                    else
                    {
                        queue.Enqueue(end - 1);
                        end = end - 1;
                    }
                }
                else
                {
                    Console.WriteLine("N must be smaller than M!");
                    queue.Dequeue();
                    break;
                }
            }

            var reversedQueue = queue.Reverse();

            return negativeQueue.Union(reversedQueue);
        }
    }
}
