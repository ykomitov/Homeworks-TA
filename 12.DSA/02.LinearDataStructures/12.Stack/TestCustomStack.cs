/*Implement the ADT stack as auto-resizable array.

    Resize the capacity on demand (when no space is available to add / insert a new element).
*/

namespace _12.Stack
{
    using System;

    public class TestCustomStack
    {
        public static void Main()
        {
            var stack = new MyStack<double>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count());
            Console.WriteLine(stack.Contains(2));
            Console.WriteLine(stack.Contains(12312412));
            var test = stack.ToArray();
            stack.TrimExcess();
            stack.Push(666);
        }
    }
}
