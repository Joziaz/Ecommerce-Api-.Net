using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.Shared.Domain;

namespace Ecommerce.BackOffice.Orders.Domain
{
    public class OrderDetail 
    {
        public Order Order { get; private set; }
        public Product Product { get; private set; }
        public uint Quantity { get; private set; }
        public decimal Price { get; private set; }

        public OrderDetail()
        {
        }
        
    }
}