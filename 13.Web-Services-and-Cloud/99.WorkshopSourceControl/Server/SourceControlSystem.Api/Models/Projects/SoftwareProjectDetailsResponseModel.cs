namespace SourceControlSystem.Api.Models.Projects
{
    using System;
    using System.Linq.Expressions;
    using SourceControlSystem.Models;

    public class SoftwareProjectDetailsResponseModel
    {
        // To avoid code duplication
        public static Expression<Func<SoftwareProject, SoftwareProjectDetailsResponseModel>> FromModel
        {
            get
            {
                return pr => new SoftwareProjectDetailsResponseModel
                {
                    Id = pr.Id,
                    Name = pr.Name,
                    CreatedOn = pr.CreatedOn,
                    TotalUsers = pr.Users.Count
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public int TotalUsers { get; set; }
    }
}