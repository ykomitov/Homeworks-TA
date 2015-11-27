namespace TeleimotBg.Services.Data
{
    using System;
    using System.Linq;
    using Common.Constants;
    using Contracts;
    using TeleimotBg.Data.Models;
    using TeleimotBg.Data.Repositories;

    public class RealEstatesService : IRealEstatesService
    {
        private IRepository<RealEstate> realEstates;

        public RealEstatesService(IRepository<RealEstate> estates)
        {
            this.realEstates = estates;
        }

        public RealEstate CreateRealEstate(
            string title,
            string description,
            string address,
            string contact,
            string constructionYear,
            string userId,
            int type,
            double? sellingPrice = null,
            double? rentingPrice = null)
        {
            var newRealEstate = new RealEstate
            {
                RealEstateTitle = title,
                RealEstateDescription = description,
                Address = address,
                Contact = contact,
                ConstructionYear = new DateTime(int.Parse(constructionYear), 1, 1),
                UserId = userId,
                SellingPrice = sellingPrice,
                RentingPrice = rentingPrice,
                DateCreated = DateTime.UtcNow,
                RealEstateType = (RealEstateType)type
            };

            if (newRealEstate.SellingPrice == null && newRealEstate.RentingPrice == null)
            {
                return null;
            }

            this.realEstates.Add(newRealEstate);
            this.realEstates.SaveChanges();

            return newRealEstate;
        }

        public IQueryable<RealEstate> GetPublicRealEstates(
            int skip = RealEstateConstants.DefaultSkip,
            int take = RealEstateConstants.DefaultTake)
        {
            return this.realEstates
               .All()
               .OrderByDescending(r => r.DateCreated)
               .Skip(skip * take)
               .Take(take <= RealEstateConstants.MaxTake ? take : RealEstateConstants.MaxTake);
        }

        public IQueryable<RealEstate> GetRealEstateDetails(int id)
        {
            return this.realEstates
              .All()
              .Where(r => r.Id == id);
        }
    }
}
