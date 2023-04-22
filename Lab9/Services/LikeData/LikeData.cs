using Lab6.Models;
using System.Xml.Linq;

namespace Lab6.Services.LikeData
{
    public class LikeData : ILikeData
    {
        private readonly List<Like> _likes = new List<Like>()
        {
            new() { Id = 1, UserId = 12345, PostId = 100 },
            new() { Id = 2, UserId = 54321, PostId = 101 },
            new() { Id = 3, UserId = 98765, PostId = 102 },
            new() { Id = 4, UserId = 56789, PostId = 103 },
            new() { Id = 5, UserId = 43210, PostId = 104 },
            new() { Id = 6, UserId = 13579, PostId = 105 },
            new() { Id = 7, UserId = 97531, PostId = 106 },
            new() { Id = 8, UserId = 24680, PostId = 107 },
            new() { Id = 9, UserId = 86420, PostId = 108 },
            new() { Id = 10, UserId = 31415, PostId = 109 }
        };

        public async Task<Like> Get(long id)
        {
            var like = _likes.FirstOrDefault(x => x.Id == id);

            return await Task.FromResult(like);
        }

        public async Task<Like> Post(Like like)
        {
            if (like == null)
            {
                throw new ArgumentNullException(nameof(like));
            }

            like.Id = _likes.Max(p => p.Id) + 1;
            _likes.Add(like);

            return await Task.FromResult(like);
        }

        public async Task<Like> Delete(long id)
        {
            var like = await Get(id);

            if (like == null)
            {
                throw new NullReferenceException();
            }

            _likes.Remove(like);

            return await Task.FromResult(like);
        }
    }
}
