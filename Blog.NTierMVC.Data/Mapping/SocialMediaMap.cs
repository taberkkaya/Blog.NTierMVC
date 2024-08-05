using Blog.NTierMVC.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Data.Mapping
{
    public class SocialMediaMap : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder.HasData(new SocialMedia
            {
                Id = Guid.Parse("EEAB62C1-E84E-4527-8482-052D8B8C1760"),
                Name = "Github",
                Url = " ",
                Icon = "fa-brands fa-github",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
            new SocialMedia
            {
                Id = Guid.Parse("A7EA51B6-550D-40B6-A66A-E7A4E85344E0"),
                Name = "Github",
                Url = " ",
                Icon = "fa-brands fa-github",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            }
            );
        }
    }
}
