namespace Entitites
{
    public class PostCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Post> Posts { get; set; }
        public Common.StatusEnum.Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
