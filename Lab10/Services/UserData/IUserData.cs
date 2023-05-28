using Lab6.Models;

namespace Lab6.Services.UserData
{
    public interface IUserData
    {
        Task<UserDto> Login(UserDto userDto);
        Task<UserDto> Register(UserDto userDto);
    }
}
