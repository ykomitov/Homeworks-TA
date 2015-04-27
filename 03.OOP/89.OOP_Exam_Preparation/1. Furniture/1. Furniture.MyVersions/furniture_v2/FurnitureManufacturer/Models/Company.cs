namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FurnitureManufacturer.Interfaces;

    class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("Name cannot be empty, null or with less than 5 symbols");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            private set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("Registration number must be exactly 10");
                }

                foreach (var ch in value)
                {
                    if (Char.IsDigit(ch) == false)
                    {
                        throw new ArgumentException("Registration number must contain only digits");
                    }
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            foreach (var furniture in this.Furnitures)
            {
                if (furniture.Model.ToLower() == model.ToLower())
                {
                    return furniture;
                }
            }
            return null;
        }

        public string Catalog()
        {
            return this.Furnitures.ToString();
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} {3}",
                                this.Name,
                                this.RegistrationNumber,
                                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                                this.Furnitures.Count != 1 ? "furnitures" : "furniture");
        }
    }
}
