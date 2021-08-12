using Ecommerce.Shared.Domain;
using Ecommerce.Shop.Products.Domain;
using Ecommerce.Shop.Users.Domain;

namespace Ecommerce.Shop.ShoppingCarts.Domain
{
    public class CartItem : BaseEntity
    {
        public  User User { get; private set; }
        public Product Product { get; private set; }
        public uint Quantity { get; private set; }
        public decimal Total => Product.Price * Quantity;

        public CartItem()
        {
        }

        public CartItem(User user, Product product, uint quantity)
        {
            User = user;
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

        public void UpdateQuantity(uint quantity)
        {
            Quantity = quantity;
        }
        
    }
}