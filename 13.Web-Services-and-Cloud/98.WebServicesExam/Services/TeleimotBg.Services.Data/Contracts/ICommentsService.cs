namespace TeleimotBg.Services.Data.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Constants;
    using TeleimotBg.Data.Models;

    public interface ICommentsService
    {
        IQueryable<Comment> GetPrivateComments(
            int id,
            int skip = CommentConstants.DefaultSkip,
            int take = CommentConstants.DefaultTake);

        Comment CreateComment(int realEstateId, string comment, string userId);

        IQueryable<Comment> GetCommentById(int id);

        IQueryable<Comment> GetCommentForUserName(
            string userName,
            int skip = CommentConstants.DefaultSkip,
            int take = CommentConstants.DefaultTake);
    }
}
