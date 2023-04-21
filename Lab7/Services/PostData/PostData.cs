using Lab6.Models;

namespace Lab6.Services.PostData
{
    public class PostData : IPostData
    {
        private readonly List<Post> _posts = new List<Post>
        {
            new() { Id = 1, UserId = 1, Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
            new() { Id = 2, UserId = 2, Text = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
            new() { Id = 3, UserId = 1, Text = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
            new() { Id = 4, UserId = 3, Text = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." },
            new() { Id = 5, UserId = 2, Text = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
            new() { Id = 6, UserId = 3, Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
            new() { Id = 7, UserId = 1, Text = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
            new() { Id = 8, UserId = 2, Text = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." },
            new() { Id = 9, UserId = 1, Text = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." },
            new() { Id = 10, UserId = 3, Text = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." }
        };

        public async Task<Post> Get(long id)
        {
            var post = _posts.FirstOrDefault(x => x.Id == id);

            return await Task.FromResult(post);
        }

        public async Task<Post> Post(Post post)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            post.Id = _posts.Max(p => p.Id) + 1;
            _posts.Add(post);

            return await Task.FromResult(post);
        }

        public async Task<Post> Delete(long id)
        {
            var post = await Get(id);

            if (post == null)
            {
                throw new NullReferenceException();
            }

            _posts.Remove(post);

            return await Task.FromResult(post);
        }

        public async Task<Post> Put(Post post)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            var existingPost = await Get(post.Id);

            if (existingPost == null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            existingPost.Text = post.Text;

            return await Task.FromResult(existingPost);
        }
    }
}
