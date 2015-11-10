namespace ConsumeWebServices
{
    public class BookVolume
    {
        public string Kind { get; set; }

        public int TotalItems { get; set; }

        public Book[] Items { get; set; }
    }
}
