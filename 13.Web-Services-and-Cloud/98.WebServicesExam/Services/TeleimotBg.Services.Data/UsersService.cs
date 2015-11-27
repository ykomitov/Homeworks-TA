namespace TeleimotBg.Services.Data
{
    using System.Linq;
    using Contracts;
    using TeleimotBg.Data.Models;
    using TeleimotBg.Data.Repositories;

    public class UsersService : IUsersService
    {
        private IRepository<User> users;
        private IRepository<RealEstate> realEstates;
        private IRepository<Comment> comments;
        private IRepository<UserRating> ratings;

        public UsersService(IRepository<User> users, IRepository<RealEstate> realEstates, IRepository<Comment> comments, IRepository<UserRating> ratings)
        {
            this.users = users;
            this.realEstates = realEstates;
            this.comments = comments;
            this.ratings = ratings;
        }

        public IQueryable<User> GetUserDetails(string username)
        {
            return this.users
                .All()
                .Where(u => u.UserName == username);
        }

        public int GetRealEstatesPerUser(string username)
        {
            var listOfRealEstates = this.realEstates
                .All()
                .Where(e => e.User.UserName == username)
                .ToList();

            return listOfRealEstates.Count;
        }

        public int GetCommentsPerUser(string username)
        {
            var listOfComments = this.comments
                .All()
                .Where(e => e.User.UserName == username)
                .ToList();

            return listOfComments.Count;
        }

        public double GetAvgUserRating(string username)
        {
            var listOfRatings = this.ratings
                .All()
                .Where(e => e.RatedUser.UserName == username)
                .ToList();

            var sumOfRatings = 0;
            var countOfRatings = 0;

            for (int i = 0; i < listOfRatings.Count; i++)
            {
                sumOfRatings += listOfRatings[i].Rating;
                countOfRatings++;
            }

            return (double)sumOfRatings / countOfRatings;
        }
    }
}
