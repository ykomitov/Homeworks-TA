namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Collections.Generic;

    public class Toothpaste : Product, IProduct, IToothpaste
    {
        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get
            {
                return String.Join(", ", ingredients);
            }
            //TODO: Check if ingredients list contains valid entries!
        }

        public override string ToString()
        {
            string toothpasteString = String.Format(@"
- {0} – {1}:
  * Price: ${2}
  * For gender: {3}
  * Ingredients: {4}"
                , this.Brand, this.Name
                , this.Price
                , this.Gender
                , this.Ingredients);


            return toothpasteString;
        }
    }
}
