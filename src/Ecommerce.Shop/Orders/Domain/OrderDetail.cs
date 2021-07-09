using Ecommerce.Shared.Domain;
using Ecommerce.Shop.Products.Domain;

namespace Ecommerce.Shop.Orders.Domain
{
    public class OrderDetail : BaseEntity
    {
        public readonly Order Order;
        public Product Product { get; private set; }
        public uint Quantity { get; private set; }
        public float Price { get; private set; }
        public float Total => GetTotal();


        public OrderDetail(Order order, Product product, uint quantity)
        {
            Order = order;
            Product = product;
            Quantity = quantity;
        }

        public void AddQuantity(uint quantity)
        {
            Quantity += quantity;
        }
        public void SubstractQuantity(uint quantity)
        {
            Quantity -= quantity;
        }
        public float GetTotal()
        {
            if (Price == 0)
                return Product.Price * Quantity;

            return Price * Quantity;
        }
        
        public void SavePrice()
        {
            Price = Product.Price;
        }
    }
}