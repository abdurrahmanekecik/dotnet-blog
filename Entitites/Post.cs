using System.ComponentModel.DataAnnotations.Schema;

namespace Entitites
{
    public class Post
    {
        public Guid Uuid { get; set; }

        public required string Title { get; set; }

        public required string Slug { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public required string Content { get; set; }

        public string? ImageUrl { get; set; }

        public Guid AuthorId { get; set; }

        public User User { get; set; }

        public Common.StatusEnum.Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
