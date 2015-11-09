namespace _02.FastRetrivalByOrderedMutiDictionary
{
    public class Article
    {
        public Article(string barcode, string vendor, string articleName, decimal price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Name = articleName;
            this.Price = price;
        }

        public string Barcode { get; set; }

        public string Vendor { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
