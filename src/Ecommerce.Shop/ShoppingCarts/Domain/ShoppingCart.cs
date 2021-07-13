using Ecommerce.Shared.Domain;
using Ecommerce.Shared.Domain.Exeptions;
using Ecommerce.Shop.Products.Domain;
using Ecommerce.Shop.Users.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shop.ShoppingCarts.Domain
{
    public class ShoppingCart : BaseEntity
    {
        public readonly User User; 
        public decimal Total { get; private set; }
        public List<CartDetail> Items { get; private set; }

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
                CartDetail newItem = new CartDetail(this, product, quantity);
                Items.Add(newItem);
            }
            else
                item.AddQuantity(quantity);
        }

        public void RemoveItem(Product product)
        {
            CartDetail item = Items.FirstOrDefault(item => item.Product == product);
            if (item == null)
                throw new RegistryNotFoundException("Product don't found in the order");
            else
                Items.Remove(item);
        }
    }
}
