namespace ForumSystem.Web.ViewModels.PagableFeedbackList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class FeedbackListViewModel
    {
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public IEnumerable<FeedbackViewModel> Feedbacks { get; set; }
    }
}