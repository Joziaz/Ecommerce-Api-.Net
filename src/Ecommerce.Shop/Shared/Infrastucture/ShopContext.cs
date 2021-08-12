using Ecommerce.Shop.Orders.Domain;
using Ecommerce.Shop.Products.Domain;
using Ecommerce.Shop.Shared.Infrastucture.EntityConfigurations;
using Ecommerce.Shop.ShoppingCarts.Domain;
using Ecommerce.Shop.Stocks.Domain;
using Ecommerce.Shop.Users.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shop.Shared.Infrastucture
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<User> Users { get; private set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

    }
}
