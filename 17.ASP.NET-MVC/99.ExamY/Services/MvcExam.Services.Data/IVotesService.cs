namespace MvcExam.Services.Data
{
    using System.Linq;

    using MvcExam.Data.Models;

    public interface IVotesService
    {
        IQueryable<Vote> GetAll();

        void Add(Vote vote);
    }
}
