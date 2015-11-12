namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            int foundIndex = -1;

            for (int i = 0; i < this.items.Count - 1; i++)
            {
                if (this.items[i].Equals(item))
                {
                    foundIndex = i;
                }
            }

            if (foundIndex >= 0)
            {
                return true;
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            // To ensure the list is sorted!
            var sortedCollection = this.items.ToList();
            sortedCollection.Sort();

            int fromIndex = 0;
            int toIndex = sortedCollection.Count - 1;

            while (fromIndex <= toIndex)
            {
                int middle = (fromIndex + toIndex) / 2;
                var compareToResult = this.items[middle].CompareTo(item);
                if (compareToResult == 0)
                {
                    return true;
                }
                else if (compareToResult < 0)
                {
                    fromIndex = middle + 1;
                }
                else
                {
                    toIndex = middle - 1;
                }
            }
            return false;
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
