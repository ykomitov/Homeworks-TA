namespace StudentSystem.Server.Controllers
{
    using System;
    using System.Web.Http;
    using Data;
    using StudentSystem.Models;
    using Models;

    public class HomeworksController : ApiController
    {
        private StudentsSystemData db;

        public HomeworksController()
        {
            this.db = new StudentsSystemData();
        }

        public IHttpActionResult Post([FromUri]HomeworkDto hw)
        {
            var homework = new Homework() { StudentIdentification = hw.StudentIdentification, TimeSent = DateTime.Now };
            this.db
                .Homeworks
                .Add(homework);

            this.db.SaveChanges();

            return this.Ok();
        }
    }
}