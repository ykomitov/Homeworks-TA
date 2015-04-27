namespace Cosmetics.Engine
{
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Products;
    using System;

    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            return new Category(name);
        }

        public IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            return new Shampoo(name, brand, price, gender, milliliters, usage);
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                int minLength = 4;
                int maxLength = 12;

                if (ingredient.Length < minLength || maxLength < ingredient.Length)
                {
                    throw new IndexOutOfRangeException(String.Format("Each ingredient must be between {0} and {1} symbols long!", minLength, maxLength));
                }
            }
            return new Toothpaste(name, brand, price, gender, ingredients);
        }

        public IShoppingCart ShoppingCart()
        {
            return new ShoppingCart();
        }
    }
}
