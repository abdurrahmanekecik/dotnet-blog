namespace Entitites
{
    public class Comment
    {
        public Guid Uuid { get; set; }

        public required string Content { get; set; }

        public Guid PostId { get; set; }

        public Common.StatusEnum.Status Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
