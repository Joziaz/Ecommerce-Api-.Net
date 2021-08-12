using System;
using Ecommerce.Shared.Domain;
using Ecommerce.Shop.Products.Domain;

namespace Ecommerce.Shop.Orders.Domain
{
    public class OrderDetail 
    {
        public Order Order { get; private set; }
        public Product Product { get; private set; }
        public uint Quantity { get; private set; }
        public decimal Price { get; private set;  }
        public decimal Total => Price * Quantity;

        public OrderDetail()
        {
        }

        public OrderDetail(Order order, Product product, uint quantity)
        {
            Order = order;
            Product = product;
            Quantity = quantity;

            Price = product.Price;
        }
        
        public void AddQuantity(uint quantity)
        {
            Quantity += quantity;
        }
        public void SubtractQuantity(uint quantity)
        {
            if (Quantity < quantity)
                throw new NotEnoughQuantity("Not enough quantity");

            Quantity -= quantity;
        }

    }
}