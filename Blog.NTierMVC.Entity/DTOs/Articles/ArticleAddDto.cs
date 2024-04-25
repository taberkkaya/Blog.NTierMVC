using Blog.NTierMVC.Entity.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Entity.DTOs.Articles
{
    public class ArticleAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        public IList<CategoryDto> Categories { get; set; }
    }
}
