using Blog.NTierMVC.Core.Entities;

namespace Blog.NTierMVC.Entity.Entities
{
    public class Image : EntityBase
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
