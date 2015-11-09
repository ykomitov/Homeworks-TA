namespace _01.PriorityQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Heap<T> where T : IComparable<T>
    {
        private List<T> items;

        public Heap(HeapType type)
        {
            this.items = new List<T>();
            this.HeapType = type;
        }

        public HeapType HeapType { get; private set; }

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        public T Root
        {
            get { return this.items[0]; }
        }

        public void Add(T item)
        {
            this.items.Add(item);

            int i = this.items.Count - 1;

            bool flag = true;
            if (HeapType == HeapType.MaxHeap)
            {
                flag = false;
            }

            while (i > 0)
            {
                if ((this.items[i].CompareTo(this.items[(i - 1) / 2]) > 0) ^ flag)
                {
                    T temp = this.items[i];
                    this.items[i] = this.items[(i - 1) / 2];
                    this.items[(i - 1) / 2] = temp;
                    i = (i - 1) / 2;
                }
                else
                {
                    break;
                }
            }
        }

        public T Remove()
        {
            T result = this.items[0];

            this.DeleteRoot();

            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("Priority queue contains {0} elements: ", this.Count));
            var contents = string.Join(", ", this.items);
            sb.AppendLine(contents);
            return sb.ToString();
        }

        private void DeleteRoot()
        {
            int i = this.items.Count - 1;

            this.items[0] = this.items[i];
            this.items.RemoveAt(i);

            i = 0;

            bool flag = true;
            if (HeapType == HeapType.MaxHeap)
            {
                flag = false;
            }

            while (true)
            {
                int leftInd = (2 * i) + 1;
                int rightInd = (2 * i) + 2;
                int largest = i;

                if (leftInd < this.items.Count)
                {
                    if ((this.items[leftInd].CompareTo(this.items[largest]) > 0) ^ flag)
                    {
                        largest = leftInd;
                    }
                }

                if (rightInd < this.items.Count)
                {
                    if ((this.items[rightInd].CompareTo(this.items[largest]) > 0) ^ flag)
                    {
                        largest = rightInd;
                    }
                }

                if (largest != i)
                {
                    T temp = this.items[largest];
                    this.items[largest] = this.items[i];
                    this.items[i] = temp;
                    i = largest;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
