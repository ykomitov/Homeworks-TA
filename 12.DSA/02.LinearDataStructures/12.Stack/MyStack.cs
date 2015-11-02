namespace _12.Stack
{
    using System.Linq;

    public class MyStack<T>
    {
        private T[] data;
        private int capacity;
        private int currentIndex;

        public MyStack()
        {
            this.data = new T[4];
            this.currentIndex = 0;
            this.capacity = this.data.Length;
        }

        public void Push(T item)
        {
            if (this.currentIndex >= this.capacity)
            {
                this.AutoGrowStack();
            }

            this.data[this.currentIndex] = item;
            this.currentIndex++;
        }

        public T Pop()
        {
            T returnItem = this.data[this.currentIndex - 1];
            this.data[this.currentIndex - 1] = default(T);
            this.currentIndex--;
            return returnItem;
        }

        public T Peek()
        {
            T returnItem = this.data[this.currentIndex - 1];
            return returnItem;
        }

        public int Count()
        {
            return this.currentIndex;
        }

        public void Clear()
        {
            this.data = new T[4];
            this.capacity = this.data.Length;
            this.currentIndex = 0;
        }

        public bool Contains(T element)
        {
            var result = this.data.Contains(element);
            return result;
        }

        public T[] ToArray()
        {
            var array = new T[this.currentIndex];

            for (int i = 0; i < this.currentIndex; i++)
            {
                array[i] = this.data[i];
            }

            return array;
        }

        public void TrimExcess()
        {
            var newArray = new T[this.currentIndex];

            for (int i = 0; i < this.currentIndex; i++)
            {
                newArray[i] = this.data[i];
            }

            this.data = newArray;
            this.capacity = newArray.Length;
        }

        private void AutoGrowStack()
        {
            var newArray = new T[this.capacity * 2];

            for (int i = 0; i < this.data.Length; i++)
            {
                newArray[i] = this.data[i];
            }

            this.data = newArray;
            this.capacity = newArray.Length;
        }
    }
}
