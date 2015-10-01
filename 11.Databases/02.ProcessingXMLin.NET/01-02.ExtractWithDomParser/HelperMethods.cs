namespace Processing.Xml
{
    using System;
    using System.Collections;

    public static class HelperMethods
    {
        public static void PrintHashTable(Hashtable hashTable)
        {
            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine("{0}: {1} albums", item.Key, item.Value);
            }
        }
    }
}
