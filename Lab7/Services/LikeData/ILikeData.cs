using Lab6.Models;

namespace Lab6.Services.LikeData
{
    public interface ILikeData
    {
        Task<Like> Get(long id);
        Task<Like> Post(Like like);
        Task<Like> Delete(long id);
    }
}
