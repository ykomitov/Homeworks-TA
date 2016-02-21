namespace MvcExam.Services.Data
{
    using System;
    using System.Linq;

    using MvcExam.Data.Common;
    using MvcExam.Data.Models;
    using MvcExam.Services.Web;

    public class IdeasService : IIdeasService
    {
        private readonly IDbRepository<Idea> ideas;

        public IdeasService(IDbRepository<Idea> ideas)
        {
            this.ideas = ideas;
        }

        public void Add(Idea idea)
        {
            this.ideas.Add(idea);
            this.ideas.Save();
        }

        public IQueryable<Idea> All()
        {
            return this.ideas.All();
        }

        public Idea GetById(int id)
        {
            return this.ideas.GetById(id);
        }
    }
}
