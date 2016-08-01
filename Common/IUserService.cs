namespace Common
{
    using Dto;

    public interface IUserService
    {
        UserDto GetUser(int userId);
    }
}