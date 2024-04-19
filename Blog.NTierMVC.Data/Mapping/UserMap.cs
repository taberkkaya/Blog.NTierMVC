using Blog.NTierMVC.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.NTierMVC.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();


            var superAdmin = new AppUser
            {
                Id = Guid.Parse("CDD65005-D394-4B48-8BA4-C5526518F76F"),
                UserName = "superadmin@gmail.com",
                NormalizedUserName = "superadmin@gmail.com",
                Email = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                PhoneNumber = "+905439999999",
                FirstName = "DUMMYUSER",
                LastName = "SUPERADMIN",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = new Guid().ToString(),
                ImageId = Guid.Parse("644A194E-8811-474C-92E4-796D3140AF23")
            };

            superAdmin.PasswordHash = CreatePasswordHash(superAdmin, "123456");

            var admin = new AppUser
            {
                Id = Guid.Parse("5499DD26-468D-4606-BE18-1ABE347582FF"),
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                PhoneNumber = "+905438888888",
                FirstName = "DUMMYUSER",
                LastName = "ADMIN",
                PhoneNumberConfirmed = true,
                EmailConfirmed = false,
                SecurityStamp = new Guid().ToString(),
                ImageId = Guid.Parse("CD6083AB-FAA6-4A2C-BFFA-1C01C46A7B71")
            };

            superAdmin.PasswordHash = CreatePasswordHash(superAdmin, "123456");
            admin.PasswordHash = CreatePasswordHash(admin, "123456");

            builder.HasData(superAdmin, admin);

        }

        private string CreatePasswordHash(AppUser user, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
