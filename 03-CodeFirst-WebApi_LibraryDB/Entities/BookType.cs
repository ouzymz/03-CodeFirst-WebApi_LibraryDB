namespace _03_CodeFirst_WebApi_LibraryDB.Entities
{
    public class BookType: BaseEntity //aratablo kod icerisinde baglantı create etmek istersem bunu kullanicam (coka cok iliskili)
    {
        public int TypeId { get; set; }
        public Typee Type { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
