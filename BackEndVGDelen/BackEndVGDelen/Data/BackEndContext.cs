using BackEndVGDelen.Models;
using Microsoft.EntityFrameworkCore;


namespace BackEndVGDelen.Data
{
    public class BackEndContext : DbContext
	{

		public DbSet<Ingredient> Ingredients { get; set; }

		public DbSet<Pizza> Pizzas { get; set; }

		public DbSet<PizzaIngredient> PizzaIngredient { get; set; }

		public BackEndContext(DbContextOptions<BackEndContext> options)
			: base(options)
		{
		}
	}
}
