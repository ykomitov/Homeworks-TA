namespace _13.Queue
{
    public class MyLinkedListItem<T>
    {
        public MyLinkedListItem(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public MyLinkedListItem<T> NextItem { get; set; }
    }
}
