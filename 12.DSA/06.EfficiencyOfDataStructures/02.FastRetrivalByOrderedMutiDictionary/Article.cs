namespace _02.FastRetrivalByOrderedMutiDictionary
{
    using System;

    public class Article : IComparable<Article>
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

        public override string ToString()
        {
            return this.Name + " Barcode: " + this.Barcode + string.Format(" Price: {0:F2}", this.Price);
        }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
