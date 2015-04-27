namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;

    public class Shampoo : Product, IProduct, IShampoo
    {
        private uint milliliters;
        private UsageType usage;


        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
            this.Price = price * milliliters;
        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Shampoo milliliters should be > 0!");
                }
                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get
            {
                return this.usage;
            }
            private set
            {
                this.usage = value;
            }
        }

        public override string ToString()
        {
            string shampooString = String.Format(@"
- {0} – {1}:
  * Price: ${2}
  * For gender: {3}
  * Quantity: {4} ml
  * Usage: {5}"
                , this.Brand, this.Name
                , this.Price
                , this.Gender
                , this.Milliliters
                , this.Usage);

            return shampooString.TrimEnd();
        }
    }
}
