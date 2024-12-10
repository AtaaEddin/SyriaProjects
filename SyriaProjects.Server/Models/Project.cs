using Microsoft.AspNetCore.Identity;

namespace SyriaProjects.Server.Models
{
    public class Project : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public string? Summary { get; set; } = null!;
        public string? Description { get; set; }
        public int? Likes { get; set; }
        public int? Dislikes { get; set; }

        public int UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
