namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Category : ICategory
    {
        private string categoryName;
        private List<IProduct> listOfProducts;

        public Category(string name)
        {
            this.Name = name;
            this.listOfProducts = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.categoryName;
            }
            private set
            {
                int minLength = 2;
                int maxLength = 15;

                if (value.Length < minLength || maxLength < value.Length)
                {
                    throw new IndexOutOfRangeException(String.Format("Category name must be between {0} and {1} symbols long!", minLength, maxLength));
                }

                this.categoryName = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.listOfProducts.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!listOfProducts.Any(p => p.Name == cosmetics.Name))
            {
                throw new Exception(String.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }

            this.listOfProducts.Remove(cosmetics);
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            var sortedProducts = listOfProducts.OrderBy(x => x.Brand).ThenByDescending(x => x.Price);

            sb.Append(String.Format("{0} category – {1} {2} in total", this.Name, this.listOfProducts.Count(), this.listOfProducts.Count() != 1 ? "products" : "product"));

            foreach (var product in sortedProducts)
            {
                sb.Append(product.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
