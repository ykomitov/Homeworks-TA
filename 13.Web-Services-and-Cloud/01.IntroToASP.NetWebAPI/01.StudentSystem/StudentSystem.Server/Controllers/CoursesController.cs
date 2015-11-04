namespace StudentSystem.Server.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;

    public class CoursesController : ApiController
    {
        private IStudentSystemData db;

        public CoursesController()
        {
            this.db = new StudentsSystemData();
        }

        public IHttpActionResult Get()
        {
            var result = this.db
                .Courses
                .All()
                .Select(s => new CourseDto
                {
                    CourseName = s.Name,
                    Description = s.Description
                })
                .ToList();

            return this.Ok(result);
        }
    }
}