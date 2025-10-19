namespace Entitites
{
    public class UserRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Common.StatusEnum.Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
