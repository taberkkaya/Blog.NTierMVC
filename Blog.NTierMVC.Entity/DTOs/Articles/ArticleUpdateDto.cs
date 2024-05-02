using Blog.NTierMVC.Entity.DTOs.Categories;
using Blog.NTierMVC.Entity.Entities;
using Microsoft.AspNetCore.Http;

namespace Blog.NTierMVC.Entity.DTOs.Articles
{
    public class ArticleUpdateDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        public Entities.Image Image { get; set; }
        public IFormFile? Photo { get; set; }
        public IList<CategoryDto> Categories { get; set; }
    }
}
