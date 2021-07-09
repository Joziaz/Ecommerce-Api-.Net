using System;

namespace Ecommerce.BackOffice.Orders.Domain
{
    class OrderCantBeModify : Exception
    {
        public OrderCantBeModify(string message) : base(message)
        {
        }
    }
}
