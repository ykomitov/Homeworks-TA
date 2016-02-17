namespace ForumSystem.Web.Areas.Administration.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using ForumSystem.Data.Common.Repository;
    using ForumSystem.Data.Models;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Microsoft.AspNet.Identity;
    using Models;
    [Authorize]
    public class PostsController : Controller
    {
        private IDeletableEntityRepository<Post> posts;

        public PostsController(IDeletableEntityRepository<Post> posts)
        {
            this.posts = posts;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Posts_Read([DataSourceRequest]DataSourceRequest request)
        {
            DataSourceResult result = this.posts
                .All()
                .Project().To<PostViewModel>()
                .ToDataSourceResult(request);

            return this.Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Posts_Create([DataSourceRequest]DataSourceRequest request, PostInputModel post)
        {
            int newPostId = 0;
            if (ModelState.IsValid)
            {
                var entity = new Post
                {
                    Title = post.Title,
                    Content = post.Content,
                    AuthorId = this.User.Identity.GetUserId()
                };

                this.posts.Add(entity);
                this.posts.SaveChanges();
                newPostId = entity.Id;
            }

            var postToDisplay = this.posts.All()
                .Project().To<PostViewModel>()
                .FirstOrDefault(x => x.Id == newPostId);

            return this.Json(new[] { postToDisplay }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Posts_Update([DataSourceRequest]DataSourceRequest request, PostInputModel post)
        {
            if (ModelState.IsValid)
            {
                var entity = this.posts.GetById(post.Id);
                entity.Title = post.Title;
                entity.Content = post.Content;

                this.posts.SaveChanges();
            }

            var postToDisplay = this.posts.All()
                .Project().To<PostViewModel>()
                .FirstOrDefault(x => x.Id == post.Id);

            return this.Json(new[] { postToDisplay }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Posts_Destroy([DataSourceRequest]DataSourceRequest request, Post post)
        {
            this.posts.Delete(post.Id);
            this.posts.SaveChanges();

            return this.Json(new[] { post }.ToDataSourceResult(request, this.ModelState));
        }

        [HttpPost]
        public ActionResult Excel_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return this.File(fileContents, contentType, fileName);
        }

        protected override void Dispose(bool disposing)
        {
            this.posts.Dispose();
            base.Dispose(disposing);
        }
    }
}
