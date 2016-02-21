namespace MvcExam.Web.Areas.Administration.Views.Comments
{
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;
    using Data;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using MvcExam.Data.Models;

    public class IdeasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Ideas_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Idea> ideas = this.db.Ideas;
            DataSourceResult result = ideas.ToDataSourceResult(
                request,
                idea => new
                {
                    Id = idea.Id,
                    Title = idea.Title,
                    Description = idea.Description,
                    AuthorIp = idea.AuthorIp,
                    CreatedOn = idea.CreatedOn,
                    ModifiedOn = idea.ModifiedOn,
                    IsDeleted = idea.IsDeleted,
                    DeletedOn = idea.DeletedOn
                });

            return this.Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ideas_Create([DataSourceRequest]DataSourceRequest request, Idea idea)
        {
            if (this.ModelState.IsValid)
            {
                var entity = new Idea
                {
                    Title = idea.Title,
                    Description = idea.Description,
                    AuthorIp = idea.AuthorIp,
                    CreatedOn = idea.CreatedOn,
                    ModifiedOn = idea.ModifiedOn,
                    IsDeleted = idea.IsDeleted,
                    DeletedOn = idea.DeletedOn
                };

                this.db.Ideas.Add(entity);
                this.db.SaveChanges();
                idea.Id = entity.Id;
            }

            return this.Json(new[] { idea }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ideas_Update([DataSourceRequest]DataSourceRequest request, Idea idea)
        {
            if (this.ModelState.IsValid)
            {
                var entity = new Idea
                {
                    Id = idea.Id,
                    Title = idea.Title,
                    Description = idea.Description,
                    AuthorIp = idea.AuthorIp,
                    CreatedOn = idea.CreatedOn,
                    ModifiedOn = idea.ModifiedOn,
                    IsDeleted = idea.IsDeleted,
                    DeletedOn = idea.DeletedOn
                };

                this.db.Ideas.Attach(entity);
                this.db.Entry(entity).State = EntityState.Modified;
                this.db.SaveChanges();
            }

            return this.Json(new[] { idea }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ideas_Destroy([DataSourceRequest]DataSourceRequest request, Idea idea)
        {
            idea.IsDeleted = true;
            this.db.SaveChanges();
            return this.Json(new[] { idea }.ToDataSourceResult(request, this.ModelState));
        }

        protected override void Dispose(bool disposing)
        {
            this.db.Dispose();
            base.Dispose(disposing);
        }
    }
}
