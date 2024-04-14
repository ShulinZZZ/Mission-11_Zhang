namespace Mission_11_zhang.Models.ViewModel
{
    public class BookListViewModel
    {
        public IQueryable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}
