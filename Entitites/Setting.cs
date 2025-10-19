using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Entitites
{
    public class Setting
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Keywords { get; set; }

        public string LogoUrl { get; set; }

        public string FaviconUrl { get; set; }

        public string Url { get; set; }

        public string Email { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string SocialMedia { get; set; }

        public string Address { get; set; }

        public string smtpserver { get; set; }
        public int smtpport { get; set; }
        public string smtpmail { get; set; }
        public string smtppassword { get; set; }

        public bool smtpenablessl { get; set; }
        public bool Is_Maintenance { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
