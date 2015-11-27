namespace TeleimotBg.Services.Data.Contracts
{
    using System.Linq;
    using TeleimotBg.Data.Models;

    public interface IUsersService
    {
        IQueryable<User> GetUserDetails(string username);

        int GetRealEstatesPerUser(string username);

        int GetCommentsPerUser(string username);

        double GetAvgUserRating(string username);
    }
}
