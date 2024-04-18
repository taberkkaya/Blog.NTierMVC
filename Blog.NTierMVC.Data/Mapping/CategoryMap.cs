using Blog.NTierMVC.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.NTierMVC.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("6DA1AEE9-4CEB-4F36-B668-97E94FFDA000"),
                Name = "What is Lorem Ipsum?",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
            new Category
            {
                Id = Guid.Parse("FFBF1647-F1E9-4CCA-B37C-C0988CD73AB7"),
                Name = "Why do we use it?",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            }
            );
        }
    }
}
