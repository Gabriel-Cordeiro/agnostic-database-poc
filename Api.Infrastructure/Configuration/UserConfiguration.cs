using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configuration
{
    internal class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.ToTable("Users");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Test).HasMaxLength(10);
            builder.HasData(
                new User(1, "Seed", "Seed", DateTime.UtcNow) {Test = ""},
                new User(2, "Seed 2", "Seed 2", DateTime.UtcNow ) {Test = ""}
                );
        }
    }
}
