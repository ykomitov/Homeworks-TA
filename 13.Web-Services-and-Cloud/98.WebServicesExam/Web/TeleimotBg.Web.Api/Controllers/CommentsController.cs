namespace TeleimotBg.Web.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Common.Constants;
    using Infrastructure.Validation;
    using Microsoft.AspNet.Identity;
    using Models.Comments;
    using Services.Data.Contracts;

    public class CommentsController : ApiController
    {
        private ICommentsService comments;

        public CommentsController(ICommentsService comments)
        {
            this.comments = comments;
        }

        [Authorize]
        public IHttpActionResult Get(
            int id,
            int skip = CommentConstants.DefaultSkip,
            int take = CommentConstants.DefaultTake)
        {
            var result = this.comments
                .GetPrivateComments(id, skip, take)
                .ProjectTo<CommentsResponseModel>()
                .ToList();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Get(
            [FromUri]string userName,
            int skip = CommentConstants.DefaultSkip,
            int take = CommentConstants.DefaultTake)
        {
            var result = this.comments
                .GetCommentForUserName(userName, skip, take)
                .ProjectTo<CommentsResponseModel>()
                .ToList();

            return this.Ok(result);
        }

        [Authorize]
        [ValidateModel]
        public IHttpActionResult Post(CreateCommentRequestModel model)
        {
            var userId = this.User.Identity.GetUserId();

            var result = this.comments
                .CreateComment(model.RealEstateId, model.Content, userId);

            var resultingComment = this.comments.GetCommentById(result.Id)
              .ProjectTo<CommentsResponseModel>()
              .FirstOrDefault();

            return this.Ok(resultingComment);
        }
    }
}