using System.ComponentModel.DataAnnotations.Schema;

namespace Entitites
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Slug { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public int AuthorId { get; set; }

        public User User { get; set; }

        public Common.StatusEnum.Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
