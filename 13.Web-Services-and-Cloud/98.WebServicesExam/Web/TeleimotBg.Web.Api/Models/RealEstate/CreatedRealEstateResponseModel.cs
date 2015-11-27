namespace TeleimotBg.Web.Api.Models.RealEstate
{
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mappings;

    public class CreatedRealEstateResponseModel : IMapFrom<RealEstate>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double? SellingPrice { get; set; }

        public double? RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }

        public virtual void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<RealEstate, CreatedRealEstateResponseModel>()
                .ForMember(r => r.Title, opts => opts.MapFrom(re => re.RealEstateTitle))
                .ForMember(r => r.CanBeSold, opts => opts.MapFrom(re => re.SellingPrice != null ? true : false))
                .ForMember(r => r.CanBeRented, opts => opts.MapFrom(re => re.RentingPrice != null ? true : false));
        }
    }
}