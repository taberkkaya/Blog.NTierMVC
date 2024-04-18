using Blog.NTierMVC.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.NTierMVC.Data.Mapping
{
    public class UserTokenMap : IEntityTypeConfiguration<AppUserToken>
    {
        public void Configure(EntityTypeBuilder<AppUserToken> builder)
        {
            // Composite primary key consisting of the UserId, LoginProvider and Name
            builder.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });

            // Limit the size of the composite key columns due to common DB restrictions
            builder.Property(t => t.LoginProvider).HasMaxLength(maxKeyLength);
            builder.Property(t => t.Name).HasMaxLength(maxKeyLength);

            // Maps to the AspNetUserTokens table
            builder.ToTable("AspNetUserTokens");
        }
    }
}
