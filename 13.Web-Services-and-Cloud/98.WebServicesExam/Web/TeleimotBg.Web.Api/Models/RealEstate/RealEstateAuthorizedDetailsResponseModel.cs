namespace TeleimotBg.Web.Api.Models.RealEstate
{
    using System.Collections.Generic;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mappings;

    public class RealEstateAuthorizedDetailsResponseModel : RealEstateDetailsResponseModel, IMapFrom<RealEstate>, IHaveCustomMappings
    {
        public string Contact { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public new void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<RealEstate, RealEstateAuthorizedDetailsResponseModel>()
                .ForMember(r => r.Title, opts => opts.MapFrom(re => re.RealEstateTitle))
                .ForMember(r => r.CanBeSold, opts => opts.MapFrom(re => re.SellingPrice != null ? true : false))
                .ForMember(r => r.CanBeRented, opts => opts.MapFrom(re => re.RentingPrice != null ? true : false))
                .ForMember(r => r.CreatedOn, opts => opts.MapFrom(re => re.DateCreated))
                .ForMember(r => r.Description, opts => opts.MapFrom(re => re.RealEstateDescription))
                .ForMember(r => r.RealEstateType, opts => opts.MapFrom(re => re.RealEstateType.ToString()))
                .ForMember(r => r.ConstructionYear, opts => opts.MapFrom(re => re.ConstructionYear.Year.ToString()));
        }
    }
}