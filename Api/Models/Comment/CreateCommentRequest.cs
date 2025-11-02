namespace Api.Models.Comment
{
    public class CreateCommentRequest
    {
        public string Content { get; set; } = string.Empty;
        public Guid PostId { get; set; }
    }
}
