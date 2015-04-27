using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class InteractionManagerExtended : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "iron":
                    return new Iron(itemNameString, itemLocation);

                case "weapon":
                    return new Weapon(itemNameString, itemLocation);

                case "wood":
                    return new Wood(itemNameString, itemLocation);

            }
            return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "mine":
                    return new Mine(locationName);

                case "forest":
                    return new Forest(locationName);
            }
            return base.CreateLocation(locationTypeString, locationName);
        }
    }
}
