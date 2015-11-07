using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _04.OnlineStore
{
    class Product
    {
        public Product(string name, decimal price, string producer)
        {
            this.Name = name;
            this.Price = price;
            this.Producer = producer;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Producer { get; set; }

        public override string ToString()
        {
            return string.Format("{{{0};{1};{2}}}", this.Name, this.Price, this.Producer);
        }
    }

    class OnlineStore
    {
        static Bag<Product> allProducts = new Bag<Product>();
        const string noProducts
             = "No products found";

        static void Main()
        {
            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine();
                var indexOfFirstWhitespace = command.IndexOf(' ');
                var commandName = command.Substring(0, indexOfFirstWhitespace);
                var commandParams = command.Substring(indexOfFirstWhitespace + 1).Split(';');

                if (commandName == "AddProduct")
                {
                    var productToAdd = new Product(commandParams[0], decimal.Parse(commandParams[1]), commandParams[2]);
                    allProducts.Add(productToAdd);

                    Console.WriteLine("Product added.");
                }
                else if (commandName == "DeleteProduct")
                {
                    if (commandParams.Length == 1)
                    {
                        var productToDelete = allProducts.Where(p => p.Name == commandParams[0]);

                        if (productToDelete.Any())
                        {
                            foreach (var item in productToDelete)
                            {
                                allProducts.Remove(item);
                            }

                            Console.WriteLine(productToDelete.Count() + "products deleted");
                        }
                        else
                        {
                            Console.WriteLine(noProducts);
                        }
                    }
                    else
                    {
                        var productToDelete = allProducts.Where(p => p.Name == commandParams[0] && p.Producer == commandParams[1]);

                        if (productToDelete.Any())
                        {
                            foreach (var item in productToDelete)
                            {
                                allProducts.Remove(item);
                            }

                            Console.WriteLine(productToDelete.Count() + "products deleted");
                        }
                        else
                        {
                            Console.WriteLine(noProducts);
                        }
                    }
                }
                else if (commandName == "FindProductsByName")
                {
                    var products = allProducts.Where(p => p.Name == commandParams[0]);

                    PrintProducts(products);
                }
                else if (commandName == "FindProductsByPriceRange")
                {
                    var startPrice = decimal.Parse(commandParams[0]);
                    var endPrice = decimal.Parse(commandParams[1]);
                    var products = allProducts
                        .Where(x => x.Price >= startPrice && x.Price <= endPrice);
                        //.OrderBy(x => x.ToString()); // can be in the print method!

                }
                else if (commandName == "FindProductsByProducer")
                {

                }

            }
        }

        private static void PrintProducts(IEnumerable<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}
