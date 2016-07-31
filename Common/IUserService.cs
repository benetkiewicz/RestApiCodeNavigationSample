namespace Common
{
    using Dto;

    public interface IUserService
    {
        IUserDto GetUser(int userId);
    }
}