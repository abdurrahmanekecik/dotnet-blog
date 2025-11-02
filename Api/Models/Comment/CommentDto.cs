namespace Api.Models.Comment
{
    public class CommentDto
    {
        public Guid Uuid { get; set; }
        public string Content { get; set; } = string.Empty;
        public Guid PostId { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
