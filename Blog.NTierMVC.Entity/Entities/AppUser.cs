using Microsoft.AspNetCore.Identity;

namespace Blog.NTierMVC.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ImageId { get; set; } = Guid.Parse("644A194E-8811-474C-92E4-796D3140AF23");
        public Image Image { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
