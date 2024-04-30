using Blog.NTierMVC.Core.Entities;

namespace Blog.NTierMVC.Entity.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {
            
        }

        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
