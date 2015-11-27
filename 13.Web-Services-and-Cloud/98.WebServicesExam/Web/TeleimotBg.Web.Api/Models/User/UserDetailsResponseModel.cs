namespace TeleimotBg.Web.Api.Models.User
{
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mappings;

    public class UserDetailsResponseModel : IMapFrom<User>, IHaveCustomMappings
    {
        public string UserName { get; set; }

        public int RealEstates { get; set; }

        public int Comments { get; set; }

        public double Rating { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<User, UserDetailsResponseModel>()
               .ForMember(u => u.UserName, opts => opts.MapFrom(u => u.Email.Substring(0, u.Email.IndexOf('@'))));
        }
    }
}