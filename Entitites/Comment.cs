namespace Entitites
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int PostId { get; set; }

        public Common.StatusEnum.Status Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
