namespace MvcExam.Web.Areas.Administration.Views
{
    using System.Linq;
    using System.Web.Mvc;
    using Data;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using MvcExam.Data.Models;

    public class CommentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Comments_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Comment> comments = this.db.Comments;
            DataSourceResult result = comments.ToDataSourceResult(
                request,
                comment => new
                {
                    Id = comment.Id,
                    Content = comment.Content,
                    Email = comment.Email,
                    AuthorIp = comment.AuthorIp,
                    CreatedOn = comment.CreatedOn,
                    ModifiedOn = comment.ModifiedOn,
                    IsDeleted = comment.IsDeleted,
                    DeletedOn = comment.DeletedOn
                });

            return this.Json(result);
        }

        protected override void Dispose(bool disposing)
        {
            this.db.Dispose();
            base.Dispose(disposing);
        }
    }
}
