namespace Entitites
{
    public class Tag
    {
        public Guid Uuid { get; set; }
        public required string Name { get; set; }
        public required string Slug { get; set; }

        public Common.StatusEnum.Status Status { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
