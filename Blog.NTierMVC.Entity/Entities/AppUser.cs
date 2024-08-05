using Blog.NTierMVC.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Blog.NTierMVC.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ImageId { get; set; } = Guid.Parse("fc7d5f1f-9405-4de9-97be-6b74e201ba49");
        public Image Image { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<SocialMedia> SocialMedias { get; set; }
    }
}
