using Microsoft.AspNetCore.Mvc;
using Mission_11_zhang.Models;
using System.Diagnostics;

namespace Mission_11_zhang.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
