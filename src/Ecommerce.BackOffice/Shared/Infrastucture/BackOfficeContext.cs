using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.BackOffice.Orders.Domain;
using Ecommerce.BackOffice.Users.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Ecommerce.BackOffice.Shared.Infrastructure
{
    public class BackOfficeContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        public BackOfficeContext(DbContextOptions<BackOfficeContext> options) : base(options)
        {
        }

    }
}
 