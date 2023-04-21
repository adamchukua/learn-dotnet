using Lab6.Models;
using Lab6.Services.LikeData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab6.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly ILikeData _likeData;

        public LikeController(ILikeData likeData)
        {
            _likeData = likeData;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Like>> GetById(long id)
        {
            var like = await _likeData.Get(id);

            if (like == null)
            {
                return NotFound();
            }

            return like;
        }

        [HttpPost]
        public async Task<ActionResult<Like>> Create(Like like)
        {
            var result = await _likeData.Post(like);

            if (result == null)
            {
                return BadRequest();
            }

            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Like>> Delete(long id)
        {
            var like = await _likeData.Delete(id);

            if (like == null)
            {
                return NotFound();
            }

            return like;
        }
    }
}
