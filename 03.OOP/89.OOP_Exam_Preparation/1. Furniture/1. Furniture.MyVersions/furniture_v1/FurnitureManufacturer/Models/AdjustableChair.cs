namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FurnitureManufacturer.Interfaces;

    class AdjustableChair : Chair, IChair, IAdjustableChair
    {
        public AdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs) : base(model, materialType, price, height, numberOfLegs)
        {
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
