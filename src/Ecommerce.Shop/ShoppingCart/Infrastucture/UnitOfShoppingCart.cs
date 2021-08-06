using Ecommerce.Shared.Infrastructure.Persistance;
using Ecommerce.Shop.Orders.Domain;
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
        public readonly IOrderRepository OrderRepository;

        public UnitOfShoppingCart(IUserRepository userRepository,
                                  ICartItemRepository cartItemRepository,
                                  IOrderRepository orderRepository,
                                  PContext context): base(context)
        {
            UserRepository = userRepository;
            CartItemRepository = cartItemRepository;
            OrderRepository = orderRepository;
        }
    }
}
