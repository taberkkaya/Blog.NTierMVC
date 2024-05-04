using Blog.NTierMVC.Core.Entities;
using System.Globalization;

namespace Blog.NTierMVC.Entity.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {
            
        }

        public Category(string name, string createdBy)
        {
            Name = name;
            CreatedBy = createdBy;
        }

        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
