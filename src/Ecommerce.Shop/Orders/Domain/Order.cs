using Ecommerce.Shared.Domain;
using Ecommerce.Shared.Domain.Enums;
using Ecommerce.Shared.Domain.Exeptions;
using Ecommerce.Shop.Products.Domain;
using Ecommerce.Shop.Users.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Shop.Orders.Domain
{
    public class Order : BaseEntity
    {
        public readonly User User;
        public OrderStatus Status { get; private set; }
        public decimal Total { get; private set; }
        public List<OrderDetail> Items { get; private set; }

        public Order(User user, OrderStatus status)
        {
            User = user;
            Status = status;
        }

        public void CalculateTotal()
        {
            decimal value = 0m;
            Items.ForEach(item => value += item.Total);
            Total = value;
        }

        public void AddItem(Product product, uint quantity)
        {
            var item = Items.FirstOrDefault(item => item.Product == product);
            if (item == null)
            {
                OrderDetail newItem = new OrderDetail(this, product, quantity);
                Items.Add(newItem);
                Total += newItem.Total;
            }
            else
            {
                item.AddQuantity(quantity);
                Total += item.Total;
            }

        }

        public void RemoveItem(Product product)
        {
            OrderDetail item = Items.FirstOrDefault(item => item.Product == product);
            if (item == null)
                throw new RegistryNotFoundException("Product don't found in the order");
            else
                Items.Remove(item);

            Total -= item.Total;
        }
    }
}
