using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace CoffeeShop.Data
{
	public class RepositoryContext : DbContext
	{
		public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
		{

		}

		
		public DbSet<CoffeeMenu> CoffeeMenus { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Login> Logins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CoffeeMenu>()
                .HasData(
                  new CoffeeMenu() { CoffeeMenuId = 1, CoffeeMenuName = "LATTE", CoffeeMenuPrice = 17.50, CoffeeMenuDescription = "Espresso with lots of steamed milk and a light foam.", CoffeeMenuUrl = "/image/latte.jpg" },
                    new CoffeeMenu() { CoffeeMenuId = 2, CoffeeMenuName = "ESPRESSO", CoffeeMenuPrice = 15.99, CoffeeMenuDescription = "Intense and quickly brewed concentrated coffee", CoffeeMenuUrl = "/image/espresso.jpg" },
                    new CoffeeMenu() { CoffeeMenuId = 3, CoffeeMenuName = "CAPPUCINO", CoffeeMenuPrice = 9.99, CoffeeMenuDescription = "Espresso with steamed milk and a frothy layer.", CoffeeMenuUrl = "/image/cappucino.jpg" },
                    new CoffeeMenu() { CoffeeMenuId = 4, CoffeeMenuName = "MOCHA", CoffeeMenuPrice = 10.75, CoffeeMenuDescription = "Espresso combined with steamed milk and chocolate.", CoffeeMenuUrl = "/image/mocha.jpg" },
                    new CoffeeMenu() { CoffeeMenuId = 5, CoffeeMenuName = "MACCHIATO", CoffeeMenuPrice = 11.99, CoffeeMenuDescription = "Espresso stained with a dollop of frothy milk.", CoffeeMenuUrl = "/image/macchiato.jpg" },
                    new CoffeeMenu() { CoffeeMenuId = 6, CoffeeMenuName = "AMERICANO", CoffeeMenuPrice = 12.50, CoffeeMenuDescription = "A strong espresso diluted with hot water.", CoffeeMenuUrl = "/image/americano.jpg" }

                );
        }
    }
}
