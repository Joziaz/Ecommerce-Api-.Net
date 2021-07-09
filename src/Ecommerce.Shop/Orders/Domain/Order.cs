using Ecommerce.Shared.Domain;
using Ecommerce.Shared.Domain.Enums;
using Ecommerce.Shared.Domain.Exeptions;
using Ecommerce.Shop.Products.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shop.Orders.Domain
{
    public class Order : BaseEntity
    {
        public float Total { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<OrderDetail> Items { get; private set; }

        public void CalculateTotal()
        {
            float value = 0f;
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
            }
            else
                item.AddQuantity(quantity);
        }

        public void RemoveItem(Product product)
        {
            OrderDetail item = Items.FirstOrDefault(item => item.Product == product);
            if (item == null)
                throw new RegistryNotFoundException("Product don't found in the order");
            else
                Items.Remove(item);
        }
    }
}
