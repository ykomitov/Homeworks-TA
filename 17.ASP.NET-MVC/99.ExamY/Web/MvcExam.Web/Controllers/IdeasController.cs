namespace MvcExam.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Services.Data;

    public class IdeasController : BaseController
    {
        private readonly IIdeasService ideas;
        private readonly ICommentsService comments;

        public IdeasController(IIdeasService ideas, ICommentsService comments)
        {
            this.ideas = ideas;
            this.comments = comments;
        }

        public ActionResult Index()
        {
            return this.View();
        }
    }
}
