namespace _03.BiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class BiDictionary<K1, K2, T>
        where K1 : IComparable<K1>
        where K2 : IComparable<K2>
    {
        private OrderedMultiDictionary<K1, T> collectionOrderedByKey1;
        private OrderedMultiDictionary<K2, T> collectionOrderedByKey2;

        public BiDictionary()
        {
            this.collectionOrderedByKey1 = new OrderedMultiDictionary<K1, T>(false);
            this.collectionOrderedByKey2 = new OrderedMultiDictionary<K2, T>(false);
        }

        public void Add(K1 key1, K2 key2, T value)
        {
            this.collectionOrderedByKey1.Add(key1, value);
            this.collectionOrderedByKey2.Add(key2, value);
        }

        public void Remove(K1 key1, K2 key2, T value)
        {
            bool isFoundKey1 = this.collectionOrderedByKey1.ContainsKey(key1);
            bool isFoundKey2 = this.collectionOrderedByKey2.ContainsKey(key2);

            if (isFoundKey1 && isFoundKey2)
            {
                this.collectionOrderedByKey1.Remove(key1, value);
                this.collectionOrderedByKey2.Remove(key2, value);
            }
            else
            {
                throw new InvalidOperationException("Cannot remove from BiDictionary, since the key1 & key2 combination is not found!");
            }
        }

        public ICollection<T> Find(K1 key1)
        {
            if (this.collectionOrderedByKey1.ContainsKey(key1))
            {
                return this.collectionOrderedByKey1[key1];
            }

            return null;
        }

        public ICollection<T> Find(K2 key2)
        {
            if (this.collectionOrderedByKey2.ContainsKey(key2))
            {
                return this.collectionOrderedByKey2[key2];
            }

            return null;
        }

        public IEnumerable<T> Find(K1 key1, K2 key2)
        {
            if (this.collectionOrderedByKey1.ContainsKey(key1) && this.collectionOrderedByKey2.ContainsKey(key2))
            {
                return this.collectionOrderedByKey1[key1].Intersect(this.collectionOrderedByKey2[key2]);
            }

            return null;
        }
    }
}
