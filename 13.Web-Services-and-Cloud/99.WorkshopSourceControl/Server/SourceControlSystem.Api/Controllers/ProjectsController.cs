namespace SourceControlSystem.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using AutoMapper.QueryableExtensions;
    using Common.Constants;
    using Models.Projects;
    using Services.Data.Contracts;

    public class ProjectsController : ApiController
    {
        private readonly IProjectsService projects;

        public ProjectsController(IProjectsService projectsService)
        {
            this.projects = projectsService;
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get()
        {
            //// ObjectFactory.Get<IProjectsService>();

            var result = this.projects
                .All(page: 1)
                .ProjectTo<SoftwareProjectDetailsResponseModel>()
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
                .ProjectTo<SoftwareProjectDetailsResponseModel>()
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
                .All(page, pageSize)
                .ProjectTo<SoftwareProjectDetailsResponseModel>()
                .ToList();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Post(SaveProjectRequestModel model)
        {
            //// var dbModel = Mapper.Map<SofwareProject>(model);

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var createdProjectId = this.projects.Add(model.Name, model.Description, this.User.Identity.Name, model.Private);

            return this.Ok(createdProjectId);
        }
    }
}
