namespace Common.Dto
{
    public class UserDto : IUserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}