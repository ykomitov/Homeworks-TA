namespace _13.Queue
{
    using System;
    using System.Text;

    public class MyQueue<T>
    {
        public MyQueue()
        {
            this.FirstNode = null;
            this.Count = 0;
        }

        public MyLinkedListItem<T> FirstNode { get; set; }

        public int Count { get; set; }

        public void Enqueue(T value)
        {
            var item = new MyLinkedListItem<T>(value);

            if (this.FirstNode == null)
            {
                this.FirstNode = item;
            }
            else
            {
                var node = this.FirstNode;
                while (node.NextItem != null)
                {
                    node = node.NextItem;
                }

                node.NextItem = item;
            }

            this.Count++;
        }

        public T Dequeue()
        {
            var node = this.FirstNode;
            var nextNode = node.NextItem;
            var returnValue = node.Value;

            if (node.NextItem == null)
            {       
                this.FirstNode = null;
            }
            else
            {
                this.FirstNode = nextNode;
            }

            this.Count--;
            return returnValue;
        }

        public T Peek()
        {
            var node = this.FirstNode;

            if (node == null)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            return this.FirstNode.Value;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            var currentItem = this.FirstNode;

            for (int i = 0; i < this.Count; i++)
            {
                sb.Append(currentItem.Value);
                if (!(currentItem.NextItem == null))
                {
                    sb.Append(", ");
                }

                currentItem = currentItem.NextItem;
            }

            return sb.ToString();
        }
    }
}
