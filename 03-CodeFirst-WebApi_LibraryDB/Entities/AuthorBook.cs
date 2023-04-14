namespace _03_CodeFirst_WebApi_LibraryDB.Entities
{
    public class AuthorBook: BaseEntity //aratablo kod icerisinde baglantı create etmek istersem bunu kullanicam (coka cok iliskili)
    {
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
