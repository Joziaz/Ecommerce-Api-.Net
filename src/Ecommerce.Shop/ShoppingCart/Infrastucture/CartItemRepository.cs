using Ecommerce.Shared.Infrastructure.Persistance;
using Ecommerce.Shop.Products.Domain;
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
        public CartItemRepository(PContext context) : base(context)
        {
        }

        public IEnumerable<CartItem> GetUserCartItems(User user)
        {
            return _provider.Where(item => item.User == user);
        }

        public async Task<CartItem> GetCartItemAsync(User user, Product product)
        {
            var cartItem = await _provider.SingleOrDefaultAsync(item => item.User == user && item.Product == product);
            return cartItem;
        }

        public void DeleteUserCartItems(User user)
        {
            var items = GetUserCartItems(user);

            _provider.RemoveRange(items);
        }
    }
}
