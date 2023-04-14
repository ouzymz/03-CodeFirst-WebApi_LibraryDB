namespace _03_CodeFirst_WebApi_LibraryDB.Entities
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<AuthorBook> AuthorBooks { get; set; } //virtual LazyLoading icin kullanildi (lazyloading yaprken loop olusmamasi icin lazyloading kullanilir)

        public virtual ICollection<BookType> BookTypes { get; set; } //virtual LazyLoading icin kullanildi (lazyloading yaprken loop olusmamasi icin lazyloading kullanilir)

        public Book()
        {
            AuthorBooks = new HashSet<AuthorBook>();
            BookTypes = new HashSet<BookType>();
        }
    }
}
