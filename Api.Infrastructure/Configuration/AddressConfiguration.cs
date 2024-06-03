using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    internal class AddressConfiguration : BaseConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);
            builder.ToTable("Address");

            builder.Property(p => p.Number).IsRequired();
            builder.Property(p => p.Street).IsRequired().HasMaxLength(250);


            builder.HasOne(p => p.User)
                  .WithMany(p => p.Addresses)
                  .HasForeignKey(p => p.Id);
        }
    }
}
