namespace Entitites
{
    public class Role
    {
        public Guid Uuid { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public Common.StatusEnum.Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
