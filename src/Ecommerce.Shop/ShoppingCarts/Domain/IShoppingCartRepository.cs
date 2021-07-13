using Ecommerce.Shared.Domain;
using Ecommerce.Shop.ShoppingCarts.Domain;

namespace Ecommerce.Shop.ShoppingCarts.Domain
{
    public interface IShoppingCartRepository : ICRUDRepository<ShoppingCart>
    {
    }
}