using _03_CodeFirst_WebApi_LibraryDB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _03_CodeFirst_WebApi_LibraryDB.EntityTypeConfigurations
{
    public class BaseEntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity  //BaseEntitydden miras alan T typlar icin gecerli oldugunu belirten bir generic kuruldu.
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).IsRequired().UseIdentityColumn();
        }
    }
}
