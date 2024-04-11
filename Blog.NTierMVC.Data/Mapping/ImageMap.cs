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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("644A194E-8811-474C-92E4-796D3140AF23"),
                FileName = "Test",
                FileType = "jpg",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
            new Image
            {
                Id = Guid.Parse("CD6083AB-FAA6-4A2C-BFFA-1C01C46A7B71"),
                FileName = "Lorem_Ipsum",
                FileType = "png",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            }
            );
        }
    }
}
