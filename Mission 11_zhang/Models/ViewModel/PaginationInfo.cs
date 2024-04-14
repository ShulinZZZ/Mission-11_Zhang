namespace Mission_11_zhang.Models.ViewModel
{
    public class PaginationInfo
    {
        public int ItemPerPage { get; set; }
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int) (Math.Ceiling((decimal) TotalItems / ItemPerPage)); 
    }
}
