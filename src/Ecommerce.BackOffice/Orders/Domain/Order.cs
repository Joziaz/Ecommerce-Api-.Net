using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.Shared.Domain;
using Ecommerce.Shared.Domain.Enums;
using Ecommerce.Shared.Domain.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BackOffice.Orders.Domain
{
    public class Order : BaseEntity
    {
        public float Total { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<OrderDetail> Items { get; private set; }

        public void Complete()
        {
            Status = OrderStatus.Complete;
        }
    }
}
