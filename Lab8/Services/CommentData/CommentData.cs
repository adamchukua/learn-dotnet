using Lab6.Models;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Lab6.Services.CommentData
{
    public class CommentData : ICommentData
    {
        private readonly List<Comment> _comments = new List<Comment>
        {
            new() { Id = 1, UserId = 10, PostId = 0, Text = "Great post!" },
            new() { Id = 2, UserId = 20, PostId = 0, Text = "I found this really helpful." },
            new() { Id = 3, UserId = 15, PostId = 1, Text = "Thanks for sharing!" },
            new() { Id = 4, UserId = 25, PostId = 0, Text = "I have a question about this." },
            new() { Id = 5, UserId = 30, PostId = 2, Text = "I had the same question, thanks for answering!" },
            new() { Id = 6, UserId = 15, PostId = 4, Text = "Цей пріцєл просто імба" },
            new() { Id = 7, UserId = 20, PostId = 0, Text = "This post is amazing, thank you!" },
            new() { Id = 8, UserId = 25, PostId = 0, Text = "I never knew this before, thanks for the insight." },
            new() { Id = 9, UserId = 10, PostId = 7, Text = "I'm glad I could help!" },
            new() { Id = 10, UserId = 30, PostId = 0, Text = "This is really interesting, I'll have to try it out." }
        };

        public async Task<Comment> Get(long id)
        {
            var post = _comments.FirstOrDefault(x => x.Id == id);

            return await Task.FromResult(post);
        }

        public async Task<Comment> Post(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }

            comment.Id = _comments.Max(p => p.Id) + 1;
            _comments.Add(comment);

            return await Task.FromResult(comment);
        }

        public async Task<Comment> Delete(long id)
        {
            var comment = await Get(id);

            if (comment == null)
            {
                throw new NullReferenceException();
            }

            _comments.Remove(comment);

            return await Task.FromResult(comment);
        }

        public async Task<Comment> Put(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }

            var existingComment = await Get(comment.Id);

            if (existingComment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }

            existingComment.Text = comment.Text;

            return await Task.FromResult(existingComment);
        }
    }
}
