namespace Mission_11_zhang.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
