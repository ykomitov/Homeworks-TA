namespace MvcExam.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Data.Models;
    using Infrastructure.Mapping;
    using InputModels;
    using Services.Data;
    using ViewModels.Home;

    public class HomeController : BaseController
    {
        private const int ItemsPerPage = 3;
        private readonly IIdeasService ideas;
        private readonly ICommentsService comments;

        public HomeController(IIdeasService ideas, ICommentsService comments)
        {
            this.ideas = ideas;
            this.comments = comments;
        }

        [HttpGet]
        public ActionResult Index(int id = 1)
        {
            int page = id;
            var allItemsCount = this.ideas.All().Count();
            var totalPages = (int)Math.Ceiling(allItemsCount / (decimal)ItemsPerPage);
            var ideas = this.ideas
                .All()
                .OrderByDescending(x => x.Votes.Sum(v => v.VotePoints))
                .ThenBy(x => x.CreatedOn)
                .Skip((page - 1) * ItemsPerPage)
                .Take(ItemsPerPage)
                .To<IdeasViewModel>()
                .ToList();

            var pagedIdeas = new PagedIdeasViewModel()
            {
                CurrentPage = page,
                TotalPages = totalPages,
                Ideas = ideas
            };

            this.ViewBag.PagedIdeas = pagedIdeas;
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(IdeaInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            string userIpAddress = this.Request.UserHostAddress;

            var newIdea = new Idea()
            {
                AuthorIp = userIpAddress,
                Title = model.Title,
                Description = model.Description,
                CreatedOn = DateTime.UtcNow
            };

            this.ideas.Add(newIdea);

            this.TempData["Notification"] = "Thank you for your idea!";
            return this.Redirect("~/");
        }
    }
}
