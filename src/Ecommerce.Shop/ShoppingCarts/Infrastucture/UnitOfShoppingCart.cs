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
        public readonly IShoppingCartRepository ShoppingCartRepository;

        public UnitOfShoppingCart(IUserRepository userRepository, IShoppingCartRepository shoppingCartRepository)
        {
            UserRepository = userRepository;
            ShoppingCartRepository = shoppingCartRepository;
        }
    }
}
