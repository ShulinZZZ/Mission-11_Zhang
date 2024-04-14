namespace Mission_11_zhang.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDbContext _bookDbContext;

        public EFBookRepository(BookDbContext temp)
        {
            _bookDbContext = temp;
        }
        public IQueryable<Book> Books => _bookDbContext.Books;
    }
}
