using Microsoft.AspNetCore.Mvc;
using Mission_11_zhang.Models;
using Mission_11_zhang.Models.ViewModel;
using System.Diagnostics;

namespace Mission_11_zhang.Controllers
{
	public class HomeController : Controller
	{
		private IBookRepository _bookRepository;
		public HomeController(IBookRepository bookRepository)
		{
			_bookRepository = bookRepository;	
		}
		public IActionResult Index(int pageNum)
		{
			int pageSize = 5;

			var data = new BookListViewModel
			{
				Books = _bookRepository.Books
				.OrderBy(x => x.BookID)
				.Skip((pageNum - 1) * pageSize)
				.Take(pageSize),

				PaginationInfo = new PaginationInfo
				{
					CurrentPage = pageNum,
					ItemPerPage = pageSize,
					TotalItems = _bookRepository.Books.Count()

				}
			};
			return View(data);
		}
	}
}
