namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;

    public abstract class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;


        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                int minLength = 3;
                int maxLength = 10;

                //Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, this.Name.GetType().Name));
                //Validator.CheckIfStringLengthIsValid(value, maxLength, minLength, String.Format(GlobalErrorMessages.InvalidStringLength, this.Name.GetType().Name, minLength, maxLength));

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                int minLength = 2;
                int maxLength = 10;

                //Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, this.Brand.GetType().Name));
                //Validator.CheckIfStringLengthIsValid(value, maxLength, minLength, String.Format(GlobalErrorMessages.InvalidStringLength, this.Brand.GetType().Name, minLength, maxLength));

                this.brand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new Exception("Product price should be > 0!");
                }
                this.price = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                this.gender = value;
            }
        }

        public string Print()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
