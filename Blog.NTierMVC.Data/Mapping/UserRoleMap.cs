using Blog.NTierMVC.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.NTierMVC.Data.Mapping
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("CDD65005-D394-4B48-8BA4-C5526518F76F"),
                RoleId = Guid.Parse("C685C5AB-F989-4372-B46E-0BEA49D44098")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("5499DD26-468D-4606-BE18-1ABE347582FF"),
                RoleId = Guid.Parse("97B28373-BF1C-4188-A833-03379FD3679F")
            });
        }
    }
}
