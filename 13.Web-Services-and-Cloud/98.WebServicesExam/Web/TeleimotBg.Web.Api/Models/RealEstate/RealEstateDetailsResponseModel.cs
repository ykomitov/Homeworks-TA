namespace TeleimotBg.Web.Api.Models.RealEstate
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mappings;

    public class RealEstateDetailsResponseModel : CreatedRealEstateResponseModel, IMapFrom<RealEstate>, IHaveCustomMappings
    {
        public DateTime CreatedOn { get; set; }

        public string ConstructionYear { get; set; }

        public string Address { get; set; }

        public string RealEstateType { get; set; }

        public string Description { get; set; }

        public new void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<RealEstate, RealEstateDetailsResponseModel>()
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