/*Implement the data structure linked list.

    Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
    Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
*/

namespace _11.LinkedList
{
    using System;

    public class TestCustomLinkedList
    {
        public static void Main()
        {
            var linkedListTest = new MyLinkedList<decimal>();
            linkedListTest.AddLast(100);
            linkedListTest.AddLast(101);
            linkedListTest.AddLast(106);
            linkedListTest.AddLast(100);
            linkedListTest.AddLast(106);
            ////linkedListTest.AddFirst(666);
            ////linkedListTest.AddBefore(166, 888);
            ////linkedListTest.RemoveFirst(111);
            linkedListTest.RemoveFirst(106);
            Console.WriteLine(linkedListTest);
        }
    }
}
