using Ecommerce.Shared.Infrastructure.Persistance;
using Ecommerce.Shop.Orders.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Shop.Orders.Infrastucture
{
    public class OrderRepository : CRUDRepository<Order>
    {
        public OrderRepository(DbContext context) : base(context)
        {
        }
    }
}
