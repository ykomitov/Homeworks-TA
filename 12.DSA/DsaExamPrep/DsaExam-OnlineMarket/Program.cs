namespace DsaExam_OnlineMarket
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Program
    {
        static void MockInput()
        {
            string input = @"add Milk 1.90 dairy
add Yogurt 1.90 dairy
add Notebook 1111.90 technology
add Orbit 0.90 food
add Rakia 11.90 drinks
add Dress 121.90 clothes
add Jacket 49.90 clothes
add Milk 1.90 dairy
add Socks 2.90 clothes
filter by type dairy
filter by price from 1.00 to 2.00
filter by price from 1.50
filter by price to 2.00
filter by type clothes
end";
            string input2 = @"add Milk 1.90 dairy
add Yogurt 1.90 dairy
add Notebook 1111.90 technology
add Orbit 0.90 food
add Rakia 11.90 drinks
add Dress 121.90 clothes
add Jacket 49.90 clothes
add Milk 1.90 dairy
add Eggs 2.34 food
add Cheese 5.55 dairy
filter by type clothes
filter by price from 1.00 to 2.00
add CappyOrange 1.99 juice 
add Nestey 2.7 juice 
filter by price from 1200
add Socks 2.90 clothes
filter by type fruits
add MacBookPro 1700.1234 technology
filter by price from 1200
filter by price from 1.50
filter by price to 2.00
filter by type clothes
end";

            Console.SetIn(new StringReader(input2));
        }

        public static void Main()
        {
            //MockInput();
            var market = new Market();

            string command = "";

            while (command != "end")
            {
                command = Console.ReadLine();
                market.ParseCommand(command);
            }
        }
    }

    public class Product
    {
        public Product(string name, double price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }
    }

    public class Market
    {
        private const string AddProductSuccess = "Ok: Product {0} added successfully";
        private const string AddProductError = "Error: Product {0} already exists";
        private const string FilterByTypeError = "Error: Type {0} does not exists";

        private List<Product> products;
        private HashSet<string> productNames;
        private Bag<Product> productsByPrice;
        private Dictionary<string, List<Product>> productsByType;

        public Market()
        {
            this.products = new List<Product>();
            this.productNames = new HashSet<string>();
            this.productsByPrice = new Bag<Product>();
            this.productsByType = new Dictionary<string, List<Product>>();
        }

        public void ParseCommand(string command)
        {
            var commandArr = command.Split(' ');

            switch (commandArr[0])
            {
                case ("add"):

                    var productName = commandArr[1];
                    var productPrice = double.Parse(commandArr[2], CultureInfo.InvariantCulture);
                    var productType = commandArr[3];

                    if (this.productNames.Contains(productName))
                    {
                        Console.WriteLine(AddProductError, productName);
                        break;
                    }
                    else
                    {
                        var currentProduct = new Product(productName, productPrice, productType);

                        this.productNames.Add(productName);
                        this.products.Add(currentProduct);

                        this.productsByPrice.Add(currentProduct);


                        if (this.productsByType.ContainsKey(productType))
                        {
                            this.productsByType[productType].Add(currentProduct);
                        }
                        else
                        {
                            this.productsByType[productType] = new List<Product>();
                            this.productsByType[productType].Add(currentProduct);
                        }

                        Console.WriteLine(AddProductSuccess, productName);
                    }

                    break;
                case ("filter"):
                    var subCommand = commandArr[2];

                    switch (subCommand)
                    {
                        case ("type"):
                            var typeFilter = commandArr[3];

                            if (!this.productsByType.ContainsKey(typeFilter))
                            {
                                Console.WriteLine(FilterByTypeError, typeFilter);
                                break;
                            }

                            var filteredProducts = this.productsByType[typeFilter]
                                .OrderBy(p => p.Price)
                                .ThenBy(p => p.Name)
                                .ThenBy(p => p.Type)
                                .Take(10)
                                .ToList();

                            PrintProducts(filteredProducts);

                            break;

                        case ("price"):
                            var priceFilterType = commandArr[3];

                            switch (priceFilterType)
                            {
                                case ("from"):
                                    var commandArrLength = commandArr.Length;

                                    if (commandArrLength == 5) // from MIN_PRICE
                                    {
                                        var filterPrice = double.Parse(commandArr[4], CultureInfo.InvariantCulture);
                                        var filteredProductsByMinPrice = this.productsByPrice
                                            .Where(p => p.Price >= filterPrice)
                                            .OrderBy(p => p.Price)
                                            .ThenBy(p => p.Name)
                                            .ThenBy(p => p.Type)
                                            .Take(10)
                                            .ToList();

                                        PrintProducts(filteredProductsByMinPrice);
                                    }
                                    else if (commandArrLength == 7) // from MIN_PRICE to MAX_PRICE 
                                    {
                                        var filterMinPrice = double.Parse(commandArr[4], CultureInfo.InvariantCulture);
                                        var filterMaxPrice = double.Parse(commandArr[6], CultureInfo.InvariantCulture);

                                        var filteredProductsByPriceRange = this.productsByPrice
                                           .Where(p => p.Price >= filterMinPrice && p.Price <= filterMaxPrice)
                                           .OrderBy(p => p.Price)
                                           .ThenBy(p => p.Name)
                                           .ThenBy(p => p.Type)
                                           .Take(10)
                                           .ToList();

                                        PrintProducts(filteredProductsByPriceRange);
                                    }

                                    break;
                                case ("to"):
                                    var filterPriceMax = double.Parse(commandArr[4], CultureInfo.InvariantCulture);

                                    var filteredProductsByMaxPrice = this.productsByPrice
                                      .Where(p => p.Price <= filterPriceMax)
                                      .OrderBy(p => p.Price)
                                      .ThenBy(p => p.Name)
                                      .ThenBy(p => p.Type)
                                      .Take(10)
                                      .ToList();

                                    PrintProducts(filteredProductsByMaxPrice);

                                    break;
                                default: break;
                            }

                            break;

                        default:
                            break;
                    }

                    break;
                default:
                    break;
            }
        }

        private void PrintProducts(List<Product> filteredProducts)
        {
            if (filteredProducts.Count == 0)
            {
                Console.WriteLine("Ok: ");
            }
            else
            {
                var sb = new StringBuilder();

                for (int i = 0; i < filteredProducts.Count; i++)
                {
                    sb.Append(filteredProducts[i].Name);
                    sb.Append("(");
                    sb.Append(filteredProducts[i].Price);
                    sb.Append(")");

                    if (i < filteredProducts.Count - 1)
                    {
                        sb.Append(", ");
                    }
                }

                Console.WriteLine("Ok: {0}", sb.ToString());
            }
        }
    }
}
