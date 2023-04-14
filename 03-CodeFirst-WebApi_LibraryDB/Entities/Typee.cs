namespace _03_CodeFirst_WebApi_LibraryDB.Entities
{
    public class Typee : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<BookType> BookTypes { get; set; } //virtual LazyLoading icin kullanildi (lazyloading yaprken loop olusmamasi icin lazyloading kullanilir)

        public Typee()
        {
            BookTypes = new HashSet<BookType>();
        }
    }
}
