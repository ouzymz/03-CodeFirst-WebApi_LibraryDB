using _03_CodeFirst_WebApi_LibraryDB.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _03_CodeFirst_WebApi_LibraryDB.EntityTypeConfigurations
{
    public class BookTypeConfiguration : BaseEntityTypeConfiguration<BookType>
    {
        public override void Configure(EntityTypeBuilder<BookType> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Book)
                .WithMany(x => x.BookTypes)
                .HasForeignKey(x => x.BookId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);//silme islemi yapildigindaki davraniz

            builder.HasOne(x => x.Type)
                .WithMany(x => x.BookTypes)
                .HasForeignKey(x => x.BookId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);//silme islemi yapildigindaki davraniz
        }
    }
}
