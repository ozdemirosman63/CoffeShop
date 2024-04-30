using CoffeeShop.Data;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class LoginController : Controller
    {
        private readonly RepositoryContext _context;

        public LoginController(RepositoryContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult Index(Login model)
        {
            if (ModelState.IsValid)
            {
             
                    
              var a =_context.Logins.Where(o=>o.Email==model.Email && o.Password== model.Password).FirstOrDefault();


          

                if (a != null)
                {
                    return RedirectToAction("Index", "Home");
                }

               
               
            }

            return View(model);
            
        }
    }
}
