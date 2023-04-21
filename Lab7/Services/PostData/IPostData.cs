using Lab6.Models;

namespace Lab6.Services.PostData
{
    public interface IPostData
    {
        Task<Post> Get(long id);
        Task<Post> Post(Post post);
        Task<Post> Put(Post post);
        Task<Post> Delete(long id);
    }
}
