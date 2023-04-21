using Lab6.Models;

namespace Lab6.Services.UserData
{
    public interface IUserData
    {
        Task<User> Get(User user);
        Task<User> Post(User user);
        Task<User> Put(User user);
        Task<User> Delete(long id);
    }
}
