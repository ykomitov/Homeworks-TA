namespace MvcExam.Web.ViewModels.Home
{
    using System.Collections.Generic;

    public class PagedIdeasViewModel
    {
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public IEnumerable<IdeasViewModel> Ideas { get; set; }
    }
}