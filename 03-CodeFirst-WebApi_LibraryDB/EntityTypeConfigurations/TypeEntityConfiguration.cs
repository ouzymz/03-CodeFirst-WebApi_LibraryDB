using _03_CodeFirst_WebApi_LibraryDB.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _03_CodeFirst_WebApi_LibraryDB.EntityTypeConfigurations
{
    public class TypeEntityConfiguration : BaseEntityTypeConfiguration<Typee>
    {
        public override void Configure(EntityTypeBuilder<Typee> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
