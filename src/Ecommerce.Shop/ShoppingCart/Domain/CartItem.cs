using Ecommerce.Shared.Domain;
using Ecommerce.Shop.Products.Domain;
using Ecommerce.Shop.Users.Domain;

namespace Ecommerce.Shop.ShoppingCarts.Domain
{
    public class CartItem : BaseEntity
    {
        public readonly User User;
        public Product Product { get; private set; }
        public uint Quantity { get; private set; }
        public decimal Price { get; private set; }
        public decimal Total => GetTotal();

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
        public void SubstractQuantity(uint quantity)
        {
            Quantity -= quantity;
        }
        public decimal GetTotal()
        {
            if (Price == 0)
                return Product.Price * Quantity;

            return Price * Quantity;
        }
    }
}