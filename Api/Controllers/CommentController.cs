using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
using Entitites;
using Api.Models.Comment;


namespace Purchasing.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var comments = _commentService
                .GetAll()
                .Select(c => new CommentListDto
                {
                    Uuid = c.Uuid,
                    Content = c.Content,
                    PostId = c.PostId,
                    Status = c.Status.ToString(),
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt
                })
                .ToList();

            return Ok(comments);
        }


        [HttpGet("{uuid:guid}")]
        public IActionResult GetByUuid(Guid uuid)
        {
            var comment = _commentService.GetByUuid(uuid);
            if (comment == null)
                return NotFound("Yorum bulunamadı.");

            var dto = new CommentDto
            {
                Uuid = comment.Uuid,
                Content = comment.Content,
                PostId = comment.PostId,
                Status = comment.Status.ToString(),
                CreatedAt = comment.CreatedAt,
                UpdatedAt = comment.UpdatedAt
            };

            return Ok(dto);
        }

        // POST: api/comment
        [HttpPost]
        public IActionResult Create([FromBody] CreateCommentRequest request)
        {
            var entity = new Comment
            {
                Uuid = Guid.NewGuid(),
                Content = request.Content,
                PostId = request.PostId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _commentService.Add(entity);
            return CreatedAtAction(nameof(GetByUuid), new { uuid = entity.Uuid }, entity);
        }

        // PUT: api/comment/{uuid}
        [HttpPut("{uuid:guid}")]
        public IActionResult Update(Guid uuid, [FromBody] UpdateCommentRequest request)
        {
            var entity = _commentService.GetByUuid(uuid);
            if (entity == null)
                return NotFound("Yorum bulunamadı.");

            entity.Content = request.Content;
            entity.Status = request.Status;
            entity.UpdatedAt = DateTime.UtcNow;

            _commentService.Update(entity);
            return Ok(entity);
        }


        [HttpDelete("{uuid:guid}")]
        public IActionResult Delete(Guid uuid)
        {
            var entity = _commentService.GetByUuid(uuid);
            if (entity == null)
                return NotFound("Yorum bulunamadı.");

            _commentService.Delete(entity);
            return NoContent();
        }

        [HttpGet("count")]
        public IActionResult Count()
        {
            var count = _commentService.Count();
            return Ok(new { Count = count });
        }
    }
}
