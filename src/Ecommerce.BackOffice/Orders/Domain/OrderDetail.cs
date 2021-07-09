using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.Shared.Domain;

namespace Ecommerce.BackOffice.Orders.Domain
{
    public class OrderDetail : BaseEntity
    {
        public Order Order { get; }
        public Product Product { get; private set; }
        public uint Quantity { get; private set; }
        public float Price { get; private set; }

        public OrderDetail(Order order, Product product, uint quantity)
        {
            Order = order;
            Product = product;
            Quantity = quantity;
        }
    }
}