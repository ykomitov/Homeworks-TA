namespace BankAccounts.Models
{
    using System;
    using System.Linq;

    public abstract class Customer
    {
        private string firstName;
        private string lastName;
        private string companyName;

        public Customer(string companyName)
        {
            this.CompanyName = companyName;
        }

        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Customer()
        { }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            protected set
            {
                string test = value;
                bool isValidName = true;

                for (int i = 0; i < test.Length; i++)
                {
                    if (char.IsLetter(test[i]) || test[i] == 32)
                    {
                        continue;
                    }
                    else
                    {
                        isValidName = false;
                        break;
                    }
                }

                if (!isValidName)
                {
                    throw new ArgumentException("Invalid person name. Person name can only contain letters & spaces!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            protected set
            {
                string test = value;
                bool isValidName = true;

                for (int i = 0; i < test.Length; i++)
                {
                    if (char.IsLetter(test[i]) || test[i] == 32)
                    {
                        continue;
                    }
                    else
                    {
                        isValidName = false;
                        break;
                    }
                }

                if (!isValidName)
                {
                    throw new ArgumentException("Invalid person name. Person name can only contain letters & spaces!");
                }
                this.lastName = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            protected set
            {
                this.companyName = value;
            }
        }

        public static void AddCustomerToList()
        {
            Console.WriteLine("test");
        }
    }
}
