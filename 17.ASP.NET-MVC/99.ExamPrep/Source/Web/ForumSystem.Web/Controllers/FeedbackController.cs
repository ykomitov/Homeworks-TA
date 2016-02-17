namespace ForumSystem.Web.Controllers
{
    using System.Web.Mvc;
    using ForumSystem.Data.Common.Repository;
    using ForumSystem.Data.Models;
    using InputModels.Feedback;
    using Microsoft.AspNet.Identity;

    public class FeedbackController : Controller
    {
        private IDeletableEntityRepository<Feedback> feedback;

        public FeedbackController(IDeletableEntityRepository<Feedback> feedback)
        {
            this.feedback = feedback;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FeedbackInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var feedback = new Feedback()
            {
                Content = model.Content,
                Title = model.Title
            };

            if (this.User.Identity.IsAuthenticated)
            {
                feedback.AuthorId = this.User.Identity.GetUserId();
            }

            this.feedback.Add(feedback);
            this.feedback.SaveChanges();

            this.TempData["Notification"] = "Thank you for your feedback!";
            return this.Redirect("/");
        }
    }
}