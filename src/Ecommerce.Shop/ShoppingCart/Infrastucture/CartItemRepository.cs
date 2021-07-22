using Ecommerce.Shared.Infrastructure.Persistance;
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

        public IEnumerable GetUserCartItems(User user) => _provider.Where(item => item.User == user);
    }
}
