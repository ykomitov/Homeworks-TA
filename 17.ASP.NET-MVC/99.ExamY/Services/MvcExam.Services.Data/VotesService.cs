namespace MvcExam.Services.Data
{
    using System;
    using System.Linq;

    using MvcExam.Data.Common;
    using MvcExam.Data.Models;

    public class VotesService : IVotesService
    {
        private readonly IDbRepository<Vote> votes;

        public VotesService(IDbRepository<Vote> votes)
        {
            this.votes = votes;
        }

        public void Add(Vote vote)
        {
            this.votes.Add(vote);
            this.votes.Save();
        }

        public IQueryable<Vote> GetAll()
        {
            return this.votes.All().OrderBy(x => x.Id);
        }
    }
}
