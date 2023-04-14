using _03_CodeFirst_WebApi_LibraryDB.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _03_CodeFirst_WebApi_LibraryDB.EntityTypeConfigurations
{
    public class AuthorBookEntityTypeConfiguration : BaseEntityTypeConfiguration<AuthorBook>
    {
        public override void Configure(EntityTypeBuilder<AuthorBook> builder)
        {
            base.Configure(builder);
            
            builder.HasOne(x => x.Author)
                .WithMany(x => x.AuthorBooks)
                .HasForeignKey(x => x.AuthorId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);//silme islemi yapildigindaki davraniz
            
            builder.HasOne(x => x.Book)
                .WithMany(x => x.AuthorBooks)
                .HasForeignKey(x => x.BookId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);//silme islemi yapildigindaki davraniz
        } 
    }
}
