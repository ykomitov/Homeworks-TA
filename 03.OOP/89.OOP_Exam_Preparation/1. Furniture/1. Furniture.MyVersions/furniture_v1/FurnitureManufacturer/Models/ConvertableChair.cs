namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FurnitureManufacturer.Interfaces;

    class ConvertableChair : Chair, IFurniture, IChair, IConvertibleChair
    {
        private bool isConverted;

        public ConvertableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
            private set
            {
                this.isConverted = value;
            }
        }

        public void Convert()
        {
            if (this.IsConverted == true)
            {
                this.IsConverted = false;
            }
            else
            {
                this.IsConverted = true;
            }
        }
    }
}
