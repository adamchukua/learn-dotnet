using Lab6.Models;
using Lab6.Services.CommentData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab6.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentData _commentData;

        public CommentController(ICommentData commentData)
        {
            _commentData = commentData;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Comment>> GetById(long id)
        {
            var comment = await _commentData.Get(id);

            if (comment == null)
            {
                return NotFound();
            }

            return comment;
        }

        [HttpPost]
        public async Task<ActionResult<Comment>> Create(Comment comment)
        {
            var result = await _commentData.Post(comment);

            if (result == null)
            {
                return BadRequest();
            }

            return result;
        }

        [HttpPut]
        public async Task<ActionResult<Comment>> Update(Comment comment)
        {
            var result = await _commentData.Put(comment);

            if (result == null)
            {
                return BadRequest();
            }

            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Comment>> Delete(long id)
        {
            var comment = await _commentData.Delete(id);

            if (comment == null)
            {
                return NotFound();
            }

            return comment;
        }
    }
}
