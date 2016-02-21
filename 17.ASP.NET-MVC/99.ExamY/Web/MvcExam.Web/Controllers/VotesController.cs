namespace MvcExam.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Data.Models;
    using Services.Data;

    public class VotesController : BaseController
    {
        private readonly IVotesService votes;
        private readonly IIdeasService ideas;

        public VotesController(IVotesService votes, IIdeasService ideas)
        {
            this.votes = votes;
            this.ideas = ideas;
        }

        [HttpPost]
        public ActionResult Vote(int ideaId, int vote)
        {
            string userIpAddress = this.Request.UserHostAddress;

            var newVote = new Vote()
            {
                IdeaId = ideaId,
                VotePoints = vote,
                CreatedOn = DateTime.UtcNow,
                AuthorIp = userIpAddress
            };

            this.votes.Add(newVote);

            var newVotesSum = this.ideas.GetById(ideaId).Votes.Sum(v => v.VotePoints);

            return this.Json(new { NewVotesSum = newVotesSum });
        }
    }
}