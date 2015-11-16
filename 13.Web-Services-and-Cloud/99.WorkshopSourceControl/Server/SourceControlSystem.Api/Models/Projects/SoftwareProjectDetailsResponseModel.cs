namespace SourceControlSystem.Api.Models.Projects
{
    using System;
    using System.Linq;
    using AutoMapper;
    using Infrastructure.Mappings;
    using SourceControlSystem.Models;

    public class SoftwareProjectDetailsResponseModel : IMapFrom<SoftwareProject>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public int TotalUsers { get; set; }

        public void CreateMappings(IConfiguration config)
        {
            config.CreateMap<SoftwareProject, SoftwareProjectDetailsResponseModel>()
                .ForMember(s => s.TotalUsers, opts => opts.MapFrom(s => s.Users.Count()));
        }
    }
}