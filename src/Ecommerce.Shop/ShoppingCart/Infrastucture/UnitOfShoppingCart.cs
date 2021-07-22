using Ecommerce.Shared.Infrastructure.Persistance;
using Ecommerce.Shop.ShoppingCarts.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shop.ShoppingCarts.Infrastucture
{
    public class UnitOfShoppingCart : UnitOfWork
    {
        public readonly IUserRepository UserRepository;
        public readonly ICartItemRepository CartItemRepository;

        public UnitOfShoppingCart(IUserRepository userRepository, ICartItemRepository cartItemRepository)
        {
            UserRepository = userRepository;
            CartItemRepository = cartItemRepository;
        }
    }
}
