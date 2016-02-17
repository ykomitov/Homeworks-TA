namespace ForumSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Caching;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Data.Common.Repository;
    using Data.Models;
    using ViewModels.PagableFeedbackList;

    [Authorize]
    public class PageableFeedbackListController : Controller
    {
        const int ItemsPerPage = 4;

        private readonly IDeletableEntityRepository<Feedback> feedbacks;

        public PageableFeedbackListController(IDeletableEntityRepository<Feedback> feedbacks)
        {
            this.feedbacks = feedbacks;
        }

        [HttpGet]
        public ActionResult Index(int id = 1)
        {
            FeedbackListViewModel viewModel;
            if (this.HttpContext.Cache["Feedback_page_" + id] != null)
            {
                viewModel = (FeedbackListViewModel)this.HttpContext.Cache["Feedback_page_" + id];
            }
            else
            {
                var page = id;
                var allItemsCount = this.feedbacks.All().Count();
                var totalPages = (int)Math.Ceiling(allItemsCount / (decimal)ItemsPerPage);
                var feedbacks = this.feedbacks
                    .All()
                    .OrderBy(x => x.CreatedOn)
                    .ThenBy(x => x.Id)
                    .Skip((page - 1) * ItemsPerPage)
                    .Take(ItemsPerPage)
                    .Project().To<FeedbackViewModel>()
                    .ToList();

                viewModel = new FeedbackListViewModel()
                {
                    CurrentPage = page,
                    TotalPages = totalPages,
                    Feedbacks = feedbacks
                };

                var cacheAbsoluteExpiration = DateTime.Now.AddMinutes(1);
                this.HttpContext.Cache.Add(("Feedback_page_" + id), viewModel, null, cacheAbsoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
            }
 
            return this.View(viewModel);
        }
    }
}