namespace TeleimotBg.Services.Data.Contracts
{
    using System.Linq;
    using Common.Constants;
    using TeleimotBg.Data.Models;

    public interface IRealEstatesService
    {
        RealEstate CreateRealEstate(
            string title,
            string description,
            string address,
            string contact,
            string constructionYear,
            string userId,
            int type,
            double? sellingPrice = null,
            double? rentingPrice = null);

        IQueryable<RealEstate> GetRealEstateDetails(int id);

        IQueryable<RealEstate> GetPublicRealEstates(
            int skip = RealEstateConstants.DefaultSkip,
            int take = RealEstateConstants.DefaultTake);
    }
}
