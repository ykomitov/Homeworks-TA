namespace MvcExam.Web.ViewModels.Home
{
    using System.Linq;
    using AutoMapper;
    using MvcExam.Data.Models;
    using MvcExam.Web.Infrastructure.Mapping;

    public class IdeasViewModel : IMapFrom<Idea>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int? Comments { get; set; }

        public int? Votes { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Idea, IdeasViewModel>()
            .ForMember(
                x => x.Comments,
                opt => opt.MapFrom(x => x.Comments.Where(c => c.IdeaId == x.Id).Count()));

            configuration.CreateMap<Idea, IdeasViewModel>()
            .ForMember(
                x => x.Votes,
                opt => opt.MapFrom(x => x.Votes.Where(c => c.IdeaId == x.Id).Sum(v => v.VotePoints)));
        }
    }
}