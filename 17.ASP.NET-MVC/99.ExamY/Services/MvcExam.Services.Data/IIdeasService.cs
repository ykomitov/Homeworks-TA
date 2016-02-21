namespace MvcExam.Services.Data
{
    using System.Linq;

    using MvcExam.Data.Models;

    public interface IIdeasService
    {
        Idea GetById(int id);

        void Add(Idea idea);

        IQueryable<Idea> All();
    }
}
