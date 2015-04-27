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

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(actor, commandWords[2]);
                    break;

                case "craft":
                    HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;

                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleCraftInteraction(Person actor, string itemType, string itemName)
        {
            switch (itemType)
            {
                case "weapon":
                    if (actor.ListInventory().Any(i => i.ItemType == ItemType.Wood) && actor.ListInventory().Any(i => i.ItemType == ItemType.Iron))
                    {
                        this.AddToPerson(actor, new Weapon(itemName));
                    }
                    break;
                case "armor":
                    if (actor.ListInventory().Any(i => i.ItemType == ItemType.Iron))
                    {
                        this.AddToPerson(actor, new Armor(itemName));
                    }
                    break;
                default:
                    break;
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            {
                case "merchant":
                    return new Merchant(personNameString, personLocation);

                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }

        private void HandleGatherInteraction(Person actor, string itemName)
        {
            if (actor.Location.LocationType == LocationType.Mine || actor.Location.LocationType == LocationType.Forest)
            {
                var gatheringLocation = actor.Location as IGatheringLocation;

                if (actor.ListInventory().Any(i => i.ItemType == gatheringLocation.RequiredItem))
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(itemName));
                }
            }

            //if (actor.Location.LocationType == LocationType.Forest && actor.ListInventory().Any(i => i.ItemType == ItemType.Weapon))
            //{
            //    this.AddToPerson(actor, new Wood(itemName));
            //}

            //if (actor.Location.LocationType == LocationType.Mine && actor.ListInventory().Any(i => i.ItemType == ItemType.Armor))
            //{
            //    this.AddToPerson(actor, new Iron(itemName));
            //}
        }
    }
}
