using Ecommerce.Shared.Domain;
using Ecommerce.Shop.ShoppingCarts.Domain;
using Ecommerce.Shop.Users.Domain;
using System.Collections;
using System.Threading.Tasks;

namespace Ecommerce.Shop.ShoppingCarts.Domain
{
    public interface ICartItemRepository : ICRUDRepository<CartItem>
    {
        IEnumerable GetUserCartItems(User user);
    }
}