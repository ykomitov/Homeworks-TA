namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cosmetics.Contracts;
    using Cosmetics.Products;

    public class ShoppingCart : IShoppingCart
    {
        private List<IProduct> shoppingCartItems;

        public void AddProduct(IProduct product)
        {
            shoppingCartItems.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            shoppingCartItems.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            bool containsProduct = shoppingCartItems.Any(p => p.Name == product.Name);
            return containsProduct;
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var item in shoppingCartItems)
            {
                totalPrice += item.Price;
            }

            return totalPrice;
        }
    }
}
