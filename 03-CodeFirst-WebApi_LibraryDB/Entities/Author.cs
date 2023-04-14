namespace _03_CodeFirst_WebApi_LibraryDB.Entities
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<AuthorBook> AuthorBooks { get; set; } //virtual LazyLoading icin kullanildi (lazyloading yaprken loop olusmamasi icin lazyloading kullanilir)

        public Author()
        {
            AuthorBooks = new HashSet<AuthorBook>();
        }

    }
}
