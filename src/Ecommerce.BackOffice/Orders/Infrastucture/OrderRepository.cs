using Ecommerce.BackOffice.Orders.Domain;
using Ecommerce.BackOffice.Shared.Infrastructure;
using Ecommerce.Shared.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.BackOffice.Orders.Infrastucture
{
    public class OrderRepository : CRUDRepository<Order>, IOrderRepository
    {
        public OrderRepository(BackOfficeContext context) : base(context)
        {
        }
    }
}
