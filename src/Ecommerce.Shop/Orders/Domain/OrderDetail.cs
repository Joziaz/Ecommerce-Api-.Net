using Ecommerce.Shared.Domain;
using Ecommerce.Shop.Products.Domain;

namespace Ecommerce.Shop.Orders.Domain
{
    public class OrderDetail 
    {
        public readonly Order Order;
        public Product Product { get; private set; }
        public uint Quantity { get; private set; }
        public decimal Price { get; private set; }
        public decimal Total => GetTotal();


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
        public void SubtractQuantity(uint quantity)
        {
            Quantity -= quantity;
        }
        public decimal GetTotal()
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