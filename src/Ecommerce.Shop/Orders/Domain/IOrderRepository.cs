using Ecommerce.Shared.Domain;
using Ecommerce.Shop.Orders.Domain;

namespace Ecommerce.Shop.Orders.Domain
{
    public interface IOrderRepository : ICRUDRepository<Order>
    {
    }
}