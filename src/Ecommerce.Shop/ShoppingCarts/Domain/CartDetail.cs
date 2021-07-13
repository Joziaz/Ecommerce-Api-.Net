using Ecommerce.Shop.Products.Domain;

namespace Ecommerce.Shop.ShoppingCarts.Domain
{
    public class CartDetail
    {
        public readonly ShoppingCart Cart;
        public Product Product { get; private set; }
        public uint Quantity { get; private set; }
        public decimal Price { get; private set; }
        public decimal Total => GetTotal();

        public CartDetail(ShoppingCart cart, Product product, uint quantity)
        {
            Cart = cart;
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