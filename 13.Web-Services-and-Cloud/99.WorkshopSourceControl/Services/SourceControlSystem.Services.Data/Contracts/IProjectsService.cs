namespace SourceControlSystem.Services.Data.Contracts
{
    using System.Linq;
    using Models;
    using Common.Constants;

    public interface IProjectsService
    {
        IQueryable<SoftwareProject> All(int page = 1, int pageSize = GlobalConstants.DefaultPageSize);

        int Add(string name, string description, string creator, bool isPrivate = false);
    }
}
