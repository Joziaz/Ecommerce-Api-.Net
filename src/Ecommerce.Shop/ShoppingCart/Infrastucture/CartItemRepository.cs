using Ecommerce.Shared.Infrastructure.Persistance;
using Ecommerce.Shop.Products.Domain;
using Ecommerce.Shop.Shared.Infrastucture;
using Ecommerce.Shop.ShoppingCarts.Domain;
using Ecommerce.Shop.Users.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shop.ShoppingCarts.Infrastucture
{
    public class CartItemRepository : CRUDRepository<CartItem>, ICartItemRepository 
    {
        public CartItemRepository(ShopContext context) : base(context)
        {
        }

        public IEnumerable<CartItem> GetUserCartItems(User user)
        {
            return _provider.Where(item => item.User == user);
        }

        public async Task<CartItem> GetCartItem(User user, Product product)
        {
            var cartItem = await _provider.SingleOrDefaultAsync(item => item.User == user && item.Product == product);
            return cartItem;
        }

        public async Task DeleteUserCartItems(User user)
        {
            var items = GetUserCartItems(user);

            _provider.RemoveRange(items);
             await _context.SaveChangesAsync();
        }
    }
}
