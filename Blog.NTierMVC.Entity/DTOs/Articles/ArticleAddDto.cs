using Blog.NTierMVC.Entity.DTOs.Categories;
using Microsoft.AspNetCore.Http;

namespace Blog.NTierMVC.Entity.DTOs.Articles
{
    public class ArticleAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        public IFormFile Photo {  get; set; }
        public IList<CategoryDto> Categories { get; set; }
    }
}
