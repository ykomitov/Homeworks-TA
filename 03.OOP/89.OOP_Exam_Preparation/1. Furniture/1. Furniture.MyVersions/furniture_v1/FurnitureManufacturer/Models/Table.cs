namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FurnitureManufacturer.Interfaces;

    class Table : Furniture, IFurniture, ITable
    {
        private decimal length;
        private decimal width;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.length * this.width;
            }
        }
    }
}
