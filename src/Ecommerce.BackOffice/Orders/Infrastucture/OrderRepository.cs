using Ecommerce.Shared.Infrastructure.Persistance;
using Ecommerce.BackOffice.Orders.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.BackOffice.Orders.Infrastucture
{
    public class OrderRepository : CRUDRepository<Order> 
    {
        public OrderRepository(DbContext context) : base(context)
        {
        }
    }
}
