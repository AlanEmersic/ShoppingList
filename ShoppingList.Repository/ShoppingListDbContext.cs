using Microsoft.EntityFrameworkCore;
using ShoppingList.Model;

namespace ShoppingList.Repository
{
    public class ShoppingListDbContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Model.ShoppingList> ShoppingList { get; set; }

        public ShoppingListDbContext(DbContextOptions<ShoppingListDbContext> options)
            : base(options)
        {
        }
    }
}
