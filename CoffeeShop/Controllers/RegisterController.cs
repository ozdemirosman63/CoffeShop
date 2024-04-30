using CoffeeShop.Data;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RepositoryContext _context;

        public RegisterController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Login model)
        {
        
            if(ModelState.IsValid)
            {
                try
                {
                    _context.Logins.Add(model);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw;
                }

                return RedirectToAction("Index", "Login");
            }

            return View(model);
           
           
        }
    }
}
