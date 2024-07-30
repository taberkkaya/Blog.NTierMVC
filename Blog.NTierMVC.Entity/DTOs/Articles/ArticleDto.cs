using Blog.NTierMVC.Entity.DTOs.Categories;
using Blog.NTierMVC.Entity.Entities;

namespace Blog.NTierMVC.Entity.DTOs.Articles
{
    public class ArticleDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Entities.Image Image { get; set; }
        public CategoryDto Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public AppUser User { get; set; }
        public int ViewCount { get; set; }
    }
}
