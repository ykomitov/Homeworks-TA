namespace StudentSystem.Server.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;

    public class TestsController : ApiController
    {
        private IStudentSystemData db;

        public TestsController()
        {
            this.db = new StudentsSystemData();
        }

        public IHttpActionResult Get()
        {
            var result = this.db
                .Tests
                .All()
                .Select(s => new TestDto
                {
                    CourseId = s.CourseId
                })
                .ToList();

            return this.Ok(result);
        }
    }
}