namespace EntityFrameworkHomework
{
    using System;
    using System.Linq;
    using EntityFrameworkIntro;

    public class Start
    {
        public static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                TestProblemsOneToFive();

                //Console.WriteLine("=== Test problem 6===");
                //CreateCopyOrNorthwind();
                //Console.WriteLine("===================================================\r\n");

            }
        }

        public static void TestProblemsOneToFive()
        {
            using (var db = new NorthwindEntities())
            {
                var customerToBeAdded = new Customer()
                    {
                        CustomerID = "FUSKU",
                        CompanyName = "Home Ltd.",
                        ContactName = "Apostol Bakalov",
                        ContactTitle = "CFO",
                        Address = "It is dinner time, N2",
                        City = "Doha",
                        Region = "Earth",
                        PostalCode = "666",
                        Country = "GF",
                        Phone = "00FU.COM",
                        Fax = "Does anybody still use?"
                    };

                Console.WriteLine("=== Test problems 2, 3 & 4 ===");

                // Add the customer -> will throw if customer exists!
                DaoStaticClass.InsertCustomer(customerToBeAdded);

                // Modify the customer
                customerToBeAdded.ContactName = "Kara Ibrahim";
                DaoStaticClass.ModifyCustomer(customerToBeAdded);

                // Delete the customer
                DaoStaticClass.DeleteCustomer("FUSKU");

                /* Problem 3. 
                Write a method that finds all customers who have orders made in 1997 and shipped to Canada.*/
                var ordersDtoLinqQuery = db.Orders
                    .Select(t => new CustomerInfoDTO
                    {
                        DateOfOrder = t.OrderDate,
                        CompanyName = t.Customer.CompanyName,
                        ShipToCountry = t.ShipCountry
                    })
                    .Where(s => s.ShipToCountry == "Canada" && s.DateOfOrder.Value.Year == 1997)
                    .ToList();

                /* Problem 4. 
                Implement previous by using native SQL query and executing it through the DbContext.*/
                var ordersNativeSql = db.Database.SqlQuery<CustomerInfoDTO>("SELECT o.OrderDate, c.CompanyName, o.ShipCountry FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID WHERE o.ShipCountry = 'Canada' AND o.OrderDate BETWEEN '1997-01-01' AND '1997-12-31'").ToList();

                Console.WriteLine("\r\nNumber of orders matching the first query: {0}", ordersDtoLinqQuery.Count);
                Console.WriteLine("\r\nNumber of orders matching the second query: {0}", ordersNativeSql.Count);

                Console.WriteLine("===================================================\r\n");

                Console.WriteLine("=== Test problem 5 ===");
                var expectedValue = db.Database.SqlQuery<double>("SELECT SUM(od.Quantity * (od.UnitPrice - od.Discount)) FROM [Order Details] od JOIN Orders o ON od.OrderID = o.OrderID WHERE o.ShipRegion = 'RJ' AND o.OrderDate BETWEEN '1997-01-01' AND '1997-12-31'").FirstOrDefault();

                var actualValue = SumSalesByRegionAndPeriod("RJ", new DateTime(1997, 1, 1), new DateTime(1997, 12, 31));

                bool areEqual = (expectedValue - actualValue) < 0.001;

                Console.WriteLine("\r\n{0} == {1}", expectedValue, actualValue);
                Console.WriteLine("Are ~ equal: {0}", areEqual);
                Console.WriteLine("===================================================\r\n");
            }
        }

        public static float SumSalesByRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            using (var db = new NorthwindEntities())
            {
                var totalSalesByOrder = db.Orders
                      .Where(o => o.ShipRegion == region && o.OrderDate >= startDate && o.OrderDate <= endDate)
                      .GroupBy(i => i.OrderID)
                      .Select(o => new
                      {
                          OrderId = o.Key,
                          TotalSum = o.Sum(m => m.Order_Details.Sum(p => p.Quantity * ((float)p.UnitPrice - p.Discount)))
                      })
                      .ToList();

                return totalSalesByOrder.Sum(l => l.TotalSum);
            }
        }

        public static void CreateCopyOrNorthwind()
        {
            // To create a copy of the database structure change the connection string in app.config file to "initial catalog=NorthwindTwin" and comment TestProblemsOneToFive method;

            using (var db = new NorthwindEntities())
            {
                var result = db.Database.CreateIfNotExists();

                Console.WriteLine("Database NorthWindTwin is created: {0}", result ? "YES!" : "NO!");
            }
        }
    }
}
