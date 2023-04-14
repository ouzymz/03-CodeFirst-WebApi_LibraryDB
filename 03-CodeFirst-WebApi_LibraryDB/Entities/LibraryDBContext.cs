using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace _03_CodeFirst_WebApi_LibraryDB.Entities
{
    public class LibraryDBContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Typee> Types { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<BookType> BookTypes { get; set; }

        public LibraryDBContext(DbContextOptions<LibraryDBContext> options):base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //coklu configuration dosyalarini eklemek icin kullanilir.
        }
    }
}
