using Blog.NTierMVC.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.NTierMVC.Data.Mapping
{
    public class RoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("AspNetRoles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new AppRole
            {
                Id = Guid.Parse("C685C5AB-F989-4372-B46E-0BEA49D44098"),
                Name = "Superadmin",
                NormalizedName = "SUPERADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },new AppRole
            {
                Id = Guid.Parse("97B28373-BF1C-4188-A833-03379FD3679F"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new AppRole
            {
                Id = Guid.Parse("5E5B68DD-2512-4600-ADD0-882C842A8B56"),
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            }
            );
        }
    }
}
