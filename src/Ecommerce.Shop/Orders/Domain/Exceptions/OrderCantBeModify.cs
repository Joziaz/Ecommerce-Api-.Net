using System;

namespace Ecommerce.BackOffice.Order.Domain
{
    class OrderCantBeModify : Exception
    {
        public OrderCantBeModify(string message) : base(message)
        {
        }
    }
}
