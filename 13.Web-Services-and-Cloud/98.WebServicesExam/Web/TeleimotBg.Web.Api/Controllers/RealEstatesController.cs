namespace TeleimotBg.Web.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Common.Constants;
    using Infrastructure.Validation;
    using Microsoft.AspNet.Identity;
    using Models.RealEstate;
    using Services.Data.Contracts;

    public class RealEstatesController : ApiController
    {
        private IRealEstatesService realEstates;

        public RealEstatesController(IRealEstatesService estates)
        {
            this.realEstates = estates;
        }

        public IHttpActionResult Get(
            int skip = RealEstateConstants.DefaultSkip,
            int take = RealEstateConstants.DefaultTake)
        {
            var result = this.realEstates
                .GetPublicRealEstates(skip, take)
                .ProjectTo<CreatedRealEstateResponseModel>()
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                var result = this.realEstates
                .GetRealEstateDetails(id)
                .ProjectTo<RealEstateDetailsResponseModel>()
                .FirstOrDefault();

                if (result == null)
                {
                    return this.NotFound();
                }

                return this.Ok(result);
            }
            else
            {
                var result = this.realEstates
                .GetRealEstateDetails(id)
                .ProjectTo<RealEstateAuthorizedDetailsResponseModel>()
                .FirstOrDefault();

                if (result == null)
                {
                    return this.NotFound();
                }

                return this.Ok(result);
            }
        }

        [Authorize]
        [ValidateModel]
        public IHttpActionResult Post(CreateRealEstateRequestModel model)
        {
            var userId = this.User.Identity.GetUserId();

            var newRealEstate = this.realEstates.CreateRealEstate(
                model.Title,
                model.Description,
                model.Address,
                model.Contact,
                model.ConstructionYear,
                this.User.Identity.GetUserId(),
                model.Type,
                model.SellingPrice,
                model.RentingPrice);

            if (newRealEstate == null)
            {
                return this.BadRequest("Each estate must have selling price, renting price or both!");
            }

            var resultingRealEstate = this.realEstates.GetRealEstateDetails(newRealEstate.Id)
                .ProjectTo<CreatedRealEstateResponseModel>()
                .FirstOrDefault();

            return this.Created(string.Empty, resultingRealEstate);
        }
    }
}