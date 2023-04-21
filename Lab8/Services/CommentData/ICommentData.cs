using Lab6.Models;

namespace Lab6.Services.CommentData
{
    public interface ICommentData
    {
        Task<Comment> Get(long id);
        Task<Comment> Post(Comment comment);
        Task<Comment> Put(Comment comment);
        Task<Comment> Delete(long id);
    }
}
