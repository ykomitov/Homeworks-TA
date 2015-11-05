namespace _04.HashTableImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyHashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private const int InitialCapacity = 16;
        private const double MaxLoad = 0.75;

        private LinkedList<KeyValuePair<K, T>>[] dataList;
        private ICollection<K> keys;

        public MyHashTable()
        {
            this.dataList = new LinkedList<KeyValuePair<K, T>>[InitialCapacity];
            this.Count = 0;
            this.keys = new HashSet<K>();
        }

        // Constructor needed when resizing
        public MyHashTable(int capacity)
        {
            this.dataList = new LinkedList<KeyValuePair<K, T>>[capacity];
            this.Count = 0;
            this.keys = new HashSet<K>();
        }

        public int Count { get; set; }

        public ICollection<K> Keys
        {
            get
            {
                return this.keys;
            }
        }

        public void Add(K key, T value)
        {
            this.ResizeDataListIfNeeded();
            this.keys.Add(key);
            var newKeyValuePair = new KeyValuePair<K, T>(key, value);
            var index = this.GetIndex(key);

            if (this.dataList[index] == null)
            {
                this.dataList[index] = new LinkedList<KeyValuePair<K, T>>();
                this.dataList[index].AddFirst(newKeyValuePair);
                this.Count++;
            }
            else
            {
                this.dataList[index].AddLast(newKeyValuePair);
                this.Count++;
            }
        }

        public void Remove(K key)
        {
            if (!this.keys.Contains(key))
            {
                throw new InvalidOperationException("Invalid key - no such key found in the hash table!");
            }

            int index = this.GetIndex(key);

            if (this.dataList[index] != null)
            {
                foreach (var item in this.dataList[index])
                {
                    if (item.Key.Equals(key))
                    {
                        this.dataList[index].Remove(item);
                        this.keys.Remove(key);
                        this.Count--;
                        break;
                    }
                }
            }
        }

        public T Find(K key)
        {
            int index = this.GetIndex(key);

            if (this.dataList[index] != null)
            {
                foreach (var item in this.dataList[index])
                {
                    if (item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }
            }

            throw new KeyNotFoundException("No data corresponding to this key has been found!");
        }

        public int GetIndex(K key)
        {
            return Math.Abs(key.GetHashCode() % this.dataList.Length);
        }

        public void Clear()
        {
            this.dataList = new LinkedList<KeyValuePair<K, T>>[InitialCapacity];
            this.Count = 0;
            this.keys = new HashSet<K>();
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var list in this.dataList)
            {
                if (list != null)
                {
                    foreach (var item in list)
                    {
                        yield return item;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void ResizeDataListIfNeeded()
        {
            if (this.Count > this.dataList.Length * MaxLoad)
            {
                var doubleSizedHashTable = new MyHashTable<K, T>(this.dataList.Length * 2);

                foreach (var position in this.dataList)
                {
                    if (position != null)
                    {
                        foreach (var item in position)
                        {
                            doubleSizedHashTable.Add(item.Key, item.Value);
                        }
                    }
                }

                this.dataList = doubleSizedHashTable.dataList;
            }
        }
    }
}
