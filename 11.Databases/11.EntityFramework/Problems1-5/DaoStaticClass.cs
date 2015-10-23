namespace EntityFrameworkHomework
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using EntityFrameworkIntro;

    public static class DaoStaticClass
    {
        private const string AddCustomerSuccessMessage = "Customer successfully inserted!";
        private const string ModifyCustomerSuccessMessage = "Customer successfully modified!";
        private const string DeleteCustomerSuccessMessage = "Customer successfully deleted!";
        private const string CustomerAlreadyExistsMessage = "This customer is already in the database!";
        private const string CustomerNotFoundMessage = "This customer is not in the database!";

        public static void InsertCustomer(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                bool customerAlreadyExists = db.Customers.Any(c => c.CustomerID == customer.CustomerID);

                if (customerAlreadyExists)
                {
                    throw new ArgumentException(CustomerAlreadyExistsMessage);
                }

                db.Customers.Add(customer);
                Console.WriteLine(AddCustomerSuccessMessage);
                db.SaveChanges();
            }
        }

        public static void ModifyCustomer(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                db.Customers.Attach(customer);
                db.Entry(customer).State = EntityState.Modified;
                Console.WriteLine(ModifyCustomerSuccessMessage);
                db.SaveChanges();
            }
        }

        public static void DeleteCustomer(string customerId)
        {
            using (var db = new NorthwindEntities())
            {
                var customerToBeDeleted = db.Customers.Where(c => c.CustomerID == customerId).FirstOrDefault();

                try
                {
                    db.Customers.Remove(customerToBeDeleted);

                    Console.WriteLine(DeleteCustomerSuccessMessage);
                }
                catch
                {
                    throw new ArgumentException(CustomerNotFoundMessage);
                }

                db.SaveChanges();
            }
        }
    }
}
