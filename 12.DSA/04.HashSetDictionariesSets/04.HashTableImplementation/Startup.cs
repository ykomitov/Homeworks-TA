/*Implement the data structure hash table in a class HashTable<K,T>. Keep the data in array of lists of key-value pairs (LinkedList<KeyValuePair<K,T>>[]) with initial capacity of 16. When the hash table load runs over 75%, perform resizing to 2 times larger capacity. Implement the following methods and properties:

    Add(key, value)
    Find(key)->value
    Remove(key)
    Count
    Clear()
    this[]
    Keys

Try to make the hash table to support iterating over its elements with foreach.

Write unit tests for your class.*/

namespace _04.HashTableImplementation
{
    using System;
    using System.Threading;

    public class Startup
    {
        public static void Main()
        {
            var myHashTable = new MyHashTable<string, string>();
            var random = new Random();

            for (int i = 0; i < 50; i++)
            {
                myHashTable.Add(HelperMethods.GetRandomString(), HelperMethods.GetRandomString());
                Thread.Sleep(11);
            }

            myHashTable.Add("Hasan", "Seche");

            Console.WriteLine(myHashTable.Count);
            Console.WriteLine(myHashTable.Find("Hasan"));
            Console.WriteLine(myHashTable.Count);
            myHashTable.Remove("Hasan");
           //// Console.WriteLine(myHashTable.Find("Hasan"));
            myHashTable.Clear();
            Console.WriteLine(myHashTable.Count);
        }
    }
}
