using CoffeeShop.Data;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace CoffeeShop.Controllers
{
	public class OrderController : Controller
	{
		private readonly RepositoryContext _context;

		public OrderController(RepositoryContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var ord = await _context.Orders.ToListAsync();
			return View(ord);
		}


		public async Task<IActionResult> Delete(string name)
		{
			var a = await _context.Orders.Where(o => o.OrderName == name).FirstOrDefaultAsync();
			var model2 = await _context.CoffeeMenus.Where(o => o.CoffeeMenuName == name).FirstOrDefaultAsync();

			if (a != null)
			{
				if (a.OrderCount == 1)
				{
					_context.Orders.Remove(a);
					await _context.SaveChangesAsync();

				}
				else
				{
					a.OrderCount -= 1;
					a.OrderPrice = model2.CoffeeMenuPrice * a.OrderCount;
					await _context.SaveChangesAsync();

				}

			}
			return RedirectToAction("Index");


		}

		public IActionResult Detail()
		{
			return View();

		}
		public async Task<IActionResult> Add(string name)
		{
			var a = await _context.Orders.Where(o => o.OrderName == name).FirstOrDefaultAsync();
			var model2 = await _context.CoffeeMenus.Where(o => o.CoffeeMenuName == name).FirstOrDefaultAsync();

			if (a == null)
			{
				var model = await _context.CoffeeMenus.Where(o => o.CoffeeMenuName == name).FirstOrDefaultAsync();
				Order ord = new Order();

				ord.OrderUrl = model.CoffeeMenuUrl;
				ord.OrderName = model.CoffeeMenuName;
				ord.OrderPrice = model.CoffeeMenuPrice;
				ord.OrderCount = 1;

				_context.Orders.Add(ord);
				await _context.SaveChangesAsync();
			}
			else
			{
				a.OrderCount += 1;

				a.OrderPrice = model2.CoffeeMenuPrice * a.OrderCount;
				await _context.SaveChangesAsync();
			}

			return RedirectToAction("Index");
		}
		public async Task<IActionResult> Add2(string name)
		{
			var a = await _context.Orders.Where(o => o.OrderName == name).FirstOrDefaultAsync();
            var model2 = await _context.CoffeeMenus.Where(o => o.CoffeeMenuName == name).FirstOrDefaultAsync();

            if (a == null)
			{
				var model = await _context.CoffeeMenus.Where(o => o.CoffeeMenuName == name).FirstOrDefaultAsync();
				Order ord = new Order();

				ord.OrderUrl = model.CoffeeMenuUrl;
				ord.OrderName = model.CoffeeMenuName;
				ord.OrderPrice = model.CoffeeMenuPrice;
				ord.OrderCount = 1;

				_context.Orders.Add(ord);
				await _context.SaveChangesAsync();
			}
			else
			{
				a.OrderCount += 1;
                a.OrderPrice = model2.CoffeeMenuPrice * a.OrderCount;
                await _context.SaveChangesAsync();
			}

			return Redirect("~/CoffeeMenu/Index");
		}


	}
}
