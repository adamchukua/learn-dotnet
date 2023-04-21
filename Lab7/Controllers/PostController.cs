using Lab6.Models;
using Lab6.Services.PostData;
using Microsoft.AspNetCore.Mvc;

namespace Lab6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostData _postData;

        public PostController(IPostData postData)
        {
            _postData = postData;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetById(long id)
        {
            var post = await _postData.Get(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }

        [HttpPost]
        public async Task<ActionResult<Post>> Create(Post post)
        {
            var result = await _postData.Post(post);

            if (result == null)
            {
                return BadRequest();
            }

            return result;
        }

        [HttpPut]
        public async Task<ActionResult<Post>> Update(Post post)
        {
            var result = await _postData.Put(post);

            if (result == null)
            {
                return BadRequest();
            }

            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Post>> Delete(long id)
        {
            var post = await _postData.Delete(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }
    }
}
