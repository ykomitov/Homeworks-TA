namespace SourceControlSystem.Services.Data
{
    using System;
    using System.Linq;
    using Common.Constants;
    using Contracts;
    using Models;
    using SourceControlSystem.Data;

    public class ProjectsService : IProjectsService
    {
        private readonly IRepository<SoftwareProject> projects;
        private readonly IRepository<User> users;

        public ProjectsService()
        {
            var db = new SourceControlSystemDbContext();
            this.projects = new EfGenericRepository<SoftwareProject>(db);
            this.users = new EfGenericRepository<User>(db);
        }

        public int Add(string name, string description, string creator, bool isPrivate = false)
        {
            var currentUser = this.users
                .All()
                .FirstOrDefault(u => u.UserName == creator);

            var newProject = new SoftwareProject
            {
                Name = name,
                Description = description,
                Private = isPrivate,
                CreatedOn = DateTime.Now
            };

            newProject.Users.Add(currentUser);

            this.projects.Add(newProject);
            this.projects.SaveChanges();

            return newProject.Id;
        }

        public IQueryable<SoftwareProject> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize)
        {
            return this.projects
                 .All()
                 .OrderByDescending(p => p.CreatedOn)
                 .Skip((page - 1) * pageSize)
                 .Take(pageSize);
        }
    }
}
