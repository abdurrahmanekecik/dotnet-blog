using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Entitites
{
    public class Setting
    {
        public Guid Uuid { get; set; }
        public required string Name { get; set; }

        public required string Description { get; set; }

        public required string Keywords { get; set; }

        public required string LogoUrl { get; set; }

        public required string FaviconUrl { get; set; }

        public required string Url { get; set; }

        public string? Email { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string? SocialMedia { get; set; }

        public string? Address { get; set; }

        public string? smtpserver { get; set; }
        public int? smtpport { get; set; }
        public string? smtpmail { get; set; }
        public string? smtppassword { get; set; }

        public bool? smtpenablessl { get; set; }
        public required bool Is_Maintenance { get; set; } = true;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
