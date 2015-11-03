namespace _11.LinkedList
{
    using System;
    using System.Text;

    public class MyLinkedList<T>
    {
        public MyLinkedList()
        {
            this.FirstNode = null;
            this.Count = 0;
        }

        public MyLinkedListItem<T> FirstNode { get; set; }

        public int Count { get; set; }

        public void AddLast(T value)
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

        public void AddFirst(T value)
        {
            var item = new MyLinkedListItem<T>(value);
            item.NextItem = this.FirstNode;

            this.FirstNode = item;
            this.Count++;
        }

        public void AddBefore(T value, T valueToAdd)
        {
            var item = new MyLinkedListItem<T>(valueToAdd);

            var previousNode = this.FirstNode;
            var nextNode = previousNode.NextItem;

            if (previousNode.Value.Equals(value))
            {
                this.AddFirst(value);
            }
            else
            {
                while (!nextNode.Value.Equals(value))
                {
                    previousNode = previousNode.NextItem;
                    nextNode = nextNode.NextItem;

                    if (nextNode.NextItem == null)
                    {
                        throw new InvalidOperationException("Cannot add a new item, since the add before value was not found in the linked list!");
                    }
                }

                item.NextItem = nextNode;
                previousNode.NextItem = item;
                this.Count++;
            }
        }

        public void RemoveFirst(T value)
        {
            var previousNode = this.FirstNode;
            var nextNode = previousNode.NextItem;

            if (previousNode.Value.Equals(value))
            {
                this.FirstNode = nextNode;
                this.Count--;
            }
            else
            {
                while (!nextNode.Value.Equals(value))
                {
                    previousNode = previousNode.NextItem;
                    nextNode = nextNode.NextItem;

                    if (nextNode.NextItem == null)
                    {
                        throw new InvalidOperationException("Remove operation failed. The value was not found in the linked list!");
                    }
                }

                previousNode.NextItem = nextNode.NextItem;
                nextNode = null;
                this.Count--;
            }
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