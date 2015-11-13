namespace SourceControlSystem.Api.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using Common.Constants;
    using Data;
    using Models.Projects;
    using Services.Data;
    using Services.Data.Contracts;
    using SourceControlSystem.Models;

    public class ProjectsController : ApiController
    {
        private readonly IProjectsService projects;

        public ProjectsController()
        {
            var db = new SourceControlSystemDbContext();
            this.projects = new ProjectsService();
        }

        public IHttpActionResult Get()
        {
            var result = this.projects
                .All()
                .OrderByDescending(p => p.CreatedOn)
                .Take(GlobalConstants.DefaultPageSize)
                ////.Select(pr => new                         // Using anonymous types is not a good idea. Use DTO instead! 
                ////{
                ////    Id = pr.Id,
                ////    Name = pr.Name,
                ////    CreatedOn = pr.CreatedOn,
                ////    TotalUsers = pr.Users.Count()
                ////})
                .Select(SoftwareProjectDetailsResponseModel.FromModel)
                .ToList();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Get(string projectName)
        {
            if (string.IsNullOrEmpty(projectName))
            {
                return this.BadRequest("Project name cannot be null or empty!");
            }

            var result = this.projects
                .All()
                .Where(pr =>
                            pr.Name == projectName &&
                            (!pr.Private ||
                            // Check if the user is authorised to make requests
                            (pr.Private && pr.Users.Any(u => u.UserName == this.User.Identity.Name))))
                .Select(SoftwareProjectDetailsResponseModel.FromModel)
                .FirstOrDefault();

            // Check if this project exists
            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [Route("api/projects/all")]
        public IHttpActionResult Get(int page, int pageSize = GlobalConstants.DefaultPageSize)
        {
            var result = this.projects
                .All()
                .OrderByDescending(p => p.CreatedOn)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(SoftwareProjectDetailsResponseModel.FromModel) // Avoids code duplication. Select conditions in the model class
                .ToList();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Post(SaveProjectRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var createdProjectId = this.projects.Add(model.Name, model.Description, this.User.Identity.Name, model.Private);

            return this.Ok(createdProjectId);
        }
    }
}
