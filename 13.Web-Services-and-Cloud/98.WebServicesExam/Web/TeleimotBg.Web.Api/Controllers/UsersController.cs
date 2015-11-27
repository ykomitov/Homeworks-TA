namespace TeleimotBg.Web.Api.Controllers
{
    using System.Web.Http;
    using Models.User;
    using Services.Data.Contracts;

    public class UsersController : ApiController
    {
        private IUsersService users;

        public UsersController(IUsersService users)
        {
            this.users = users;
        }

        [Route("api/Users/{userName}")]
        public IHttpActionResult Get([FromUri]string userName)
        {
            if (this.users.GetUserDetails(userName) == null)
            {
                return this.NotFound();
            }

            var userInfo = new UserDetailsResponseModel
            {
                UserName = userName.Substring(0, userName.IndexOf('@')),
                RealEstates = this.users.GetRealEstatesPerUser(userName),
                Comments = this.users.GetCommentsPerUser(userName),
                Rating = this.users.GetAvgUserRating(userName)
            };

            return this.Ok(userInfo);
        }
    }
}