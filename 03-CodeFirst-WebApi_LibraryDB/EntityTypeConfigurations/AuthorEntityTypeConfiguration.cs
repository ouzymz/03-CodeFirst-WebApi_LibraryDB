using _03_CodeFirst_WebApi_LibraryDB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _03_CodeFirst_WebApi_LibraryDB.EntityTypeConfigurations
{
    public class AuthorEntityTypeConfiguration:BaseEntityTypeConfiguration<Author> //T type verildi
    {
        public override void Configure(EntityTypeBuilder<Author> builder)
        {
            base.Configure(builder); //override yaparken base entitydeki kurallari cagirmak icin bu kodu biraktik.
            builder.Property(x=>x.FirstName).IsRequired();
            builder.Property(x=>x.LastName).IsRequired();

        }
    }
}
