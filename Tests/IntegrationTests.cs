namespace Tests
{
    using Common;
    using Common.Dto;
    using RestClient;
    using Xunit;

    public class IntegrationTests
    {
        [Fact]
        public void ApiShouldReturnUserById()
        {
            const int userId = 2;
            IUserService user = new UserServiceClient();
            UserDto userDto = user.GetUser(userId);
            Assert.Equal<int>(userId, userDto.Id);
        }

        [Fact]
        public void ApiShouldReturnError()
        {
            const int userId = 0;
            IUserService user = new UserServiceClient();
            UserDto userDto = user.GetUser(userId);
            Assert.Null(userDto);
        }
    }
}
