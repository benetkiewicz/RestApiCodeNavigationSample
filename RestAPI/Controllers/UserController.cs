namespace RestAPI.Controllers
{
    using System.Web.Http;

    using Common;
    using Common.Dto;

    [RoutePrefix("api/v1/user")]
    public class UserController : ApiController, IUserService
    {
        [Route("{userId}")]
        public UserDto GetUser(int userId)
        {
            if (userId < 1)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }

            var user = new UserDto();
            user.Id = userId;
            user.Username = "username";
            user.Email = "foo@bar.com";

            return user;
        }
    }
}
