namespace StudentSystem.Server.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;

    public class StudentsController : ApiController
    {
        private IStudentSystemData db;

        public StudentsController()
        {
            this.db = new StudentsSystemData();
        }

        public IHttpActionResult Get()
        {
            var result = this.db
                .Students
                .All()
                .Select(s => new StudentDto
                {
                    FirstName = s.FirstName,
                    LastName = s.LastName
                })
                .ToList();

            return this.Ok(result);
        }
    }
}