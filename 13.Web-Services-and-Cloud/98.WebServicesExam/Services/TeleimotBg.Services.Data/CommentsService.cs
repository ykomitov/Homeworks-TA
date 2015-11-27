namespace TeleimotBg.Services.Data
{
    using System;
    using System.Linq;
    using Common.Constants;
    using Contracts;
    using TeleimotBg.Data.Models;
    using TeleimotBg.Data.Repositories;

    public class CommentsService : ICommentsService
    {
        private IRepository<Comment> comments;

        public CommentsService(IRepository<Comment> comments)
        {
            this.comments = comments;
        }

        public Comment CreateComment(int realEstateId, string comment, string userId)
        {
            var newComment = new Comment
            {
                Content = comment,
                CreatedOn = DateTime.UtcNow,
                UserId = userId,
                RealEstateId = realEstateId
            };

            this.comments.Add(newComment);
            this.comments.SaveChanges();

            return newComment;
        }

        public IQueryable<Comment> GetCommentById(int id)
        {
            return this.comments
              .All()
              .Where(c => c.Id == id);
        }

        public IQueryable<Comment> GetCommentForUserName(
            string userName,
            int skip = CommentConstants.DefaultSkip,
            int take = CommentConstants.DefaultTake)
        {
            return this.comments
             .All()
             .Where(c => c.User.UserName == userName)
             .OrderByDescending(c => c.CreatedOn)
             .Skip(skip * take)
             .Take(take <= CommentConstants.MaxTake ? take : CommentConstants.MaxTake);
        }

        public IQueryable<Comment> GetPrivateComments(
            int id,
            int skip = CommentConstants.DefaultSkip,
            int take = CommentConstants.DefaultTake)
        {
            return this.comments
             .All()
             .Where(c => c.Id == id)
             .OrderByDescending(c => c.CreatedOn)
             .Skip(skip * take)
             .Take(take <= CommentConstants.MaxTake ? take : CommentConstants.MaxTake);
        }
    }
}
