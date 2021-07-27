using Ecommerce.Shared.Domain;
using Ecommerce.Shop.Products.Domain;
using Ecommerce.Shop.Users.Domain;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Shop.ShoppingCarts.Domain
{
    public interface ICartItemRepository : ICRUDRepository<CartItem>
    {
        IEnumerable<CartItem> GetUserCartItems(User user);

        Task<CartItem> GetCartItemAsync(User user, Product product);
        void DeleteUserCartItems(User user);
    }
}