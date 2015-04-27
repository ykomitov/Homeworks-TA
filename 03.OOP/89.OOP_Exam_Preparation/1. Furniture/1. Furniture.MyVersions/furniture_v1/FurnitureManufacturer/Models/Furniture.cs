namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FurnitureManufacturer.Interfaces;
    using FurnitureManufacturer.Engine;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private string materialType;
        private decimal price;
        private decimal height;

        public Furniture(string model, string materialType, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = materialType;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Model cannot be empty, null or with less than 3 symbols");
                }
                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.materialType;
            }
            private set
            {
                this.materialType = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less or equal to $0.00");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less or equal to 0.00 m");
                }
                this.height = value;
            }
        }
    }
}
