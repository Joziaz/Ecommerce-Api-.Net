using Ecommerce.Shared.Domain;
using Ecommerce.Shop.Users.Domain;

namespace Ecommerce.Shop.ShoppingCarts.Domain
{
    public interface IUserRepository : ICRUDRepository<User>
    {
    }
}