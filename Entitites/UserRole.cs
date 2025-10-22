namespace Entitites
{
    public class UserRole
    {
        public Guid Uuid { get; set; }

        public Guid RoleId { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public User Role { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
