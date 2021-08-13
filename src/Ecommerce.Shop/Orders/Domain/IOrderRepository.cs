using Ecommerce.Shared.Domain;

namespace Ecommerce.Shop.Orders.Domain
{
    public interface IOrderRepository : ICRUDRepository<Order>
    {
    }
}