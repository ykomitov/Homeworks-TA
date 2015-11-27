namespace TeleimotBg.Web.Api.Models.Comments
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mappings;

    public class CommentsResponseModel : IMapFrom<Comment>, IHaveCustomMappings
    {
        public string Content { get; set; }

        public string UserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentsResponseModel>()
             .ForMember(c => c.UserName, opts => opts.MapFrom(c => c.User.Email.Substring(0, c.User.Email.IndexOf("@"))));
        }
    }
}