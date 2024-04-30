using CoffeeShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Controllers
{
    public class CoffeeMenuController : Controller
	{
		private readonly RepositoryContext _context;

		public CoffeeMenuController(RepositoryContext context)
		{
			_context = context;
		}
		public IActionResult CoffeeMenu()
		{
			return View();
		}


		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var model = await _context.CoffeeMenus.ToListAsync();
			return View(model);
		}

		//[HttpPost]
		//public async Task<IActionResult> Index(CoffeeMenu model)
		//{
		//	_context.CoffeMenus.Add(model);
		//	await _context.SaveChangesAsync();
		//	return RedirectToAction("Index");
		//}
	}
}
