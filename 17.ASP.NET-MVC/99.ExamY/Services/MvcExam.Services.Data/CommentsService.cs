namespace MvcExam.Services.Data
{
    using System.Linq;

    using MvcExam.Data.Common;
    using MvcExam.Data.Models;

    public class CommentsService : ICommentsService
    {
        private readonly IDbRepository<Comment> comments;

        public CommentsService(IDbRepository<Comment> comments)
        {
            this.comments = comments;
        }

        public IQueryable<Comment> GetAll()
        {
            return this.comments.All().OrderBy(x => x.Id);
        }
    }
}
