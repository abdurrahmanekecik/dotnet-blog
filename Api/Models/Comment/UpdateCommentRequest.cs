namespace Api.Models.Comment
{
    public class UpdateCommentRequest
    {
        public Guid Uuid { get; set; }
        public string Content { get; set; } = string.Empty;
        public Common.StatusEnum.Status Status { get; set; }
    }
}
