namespace MvcExam.Services.Data
{
    using System.Linq;

    using MvcExam.Data.Models;

    public interface ICommentsService
    {
        IQueryable<Comment> GetAll();
    }
}
