namespace Entitites
{
    public class User
    {
        public Guid Uuid { get; set; }

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }

        public string? AvatarUrl { get; set; }

        public Common.StatusEnum.Status Status { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
